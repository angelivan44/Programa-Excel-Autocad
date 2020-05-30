
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Autodesk.AutoCAD.Interop.Common;
using Autodesk.AutoCAD.Interop;

using System.Reflection;
using System.Runtime.InteropServices;

using Microsoft.Office.Interop.Excel;
using System.Collections;
using LinqToExcel;
using System.IO;
using WindowsFormsApp1.Clases;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }

        private void button2_Click(object sender, EventArgs e)
        {



        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            BD confi = new BD();
            confi.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            var book = new ExcelQueryFactory(Modulo.RutaExcel);


            obExcel oe = new obExcel();
            IEnumerable<Localidades> localidades = oe.LocalidadesData(book);
            Modulo.localidadesG = (from c in localidades select c.nombre_plano).ToList();
            Modulo.matrizRaiz = localidades;
            Areas area = new Areas();
            area.Show();
            iconButton3.Enabled = true;
           
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

            string nombre;
            foreach (string g in Modulo.listaFinal)
            {
                nombre = Modulo.RutaGuardado + "\\" + g + ".dwg";

                File.Copy(Modulo.RutaAutocad, nombre, true);


            }
            List<Ejecucion> listaEjecucion = new List<Ejecucion>();
            Ejecucion ejecucion;
            foreach (Localidades k in Modulo.matrizRaiz)
            {
                foreach (string z in Modulo.listaFinal)
                {
                    if (z == k.nombre_plano)

                    {
                        ejecucion = new Ejecucion();
                        ejecucion.loc = k.id;
                        ejecucion.ruta = k.nombre_plano;
                        listaEjecucion.Add(ejecucion);

                    }
                }
            }
            ejecucion = null;
            //inicializacion del autocad
            Autodesk.AutoCAD.Interop.AcadApplication AcadApp = new AcadApplication();

            Autodesk.AutoCAD.Interop.AcadDocument doc;
            AcadApp.Visible = true;
            string rutaAutocad;
            //creacion de los objetos en listas

            obExcel f = new obExcel();

            IEnumerable<Vanos> vanos;
            IEnumerable<Postes> postes;
            IEnumerable<Luminarias> luminarias;
            IEnumerable<Subestaciones> subestaciones;
            IEnumerable<VistasC> vistasCajetines;
            IEnumerable<VistasD> vistasDibujo;
            IEnumerable<Layers> capas;
            IEnumerable<Cajetines> cajetienes;
            double[] pto = new double[3];
            double[] pto2 = new double[3];
            double[] pto3 = new double[3];
            double[] pto4 = new double[3];
            pto[2] = 0.0;
            pto2[2] = 0.0;
            pto3[2] = 0.0;
            pto4[2] = 0.0;
            AcadLine lin;
            AcadBlockReference block;
            AcadLayer layer;
            AcadPViewport vistaCajetin;
            AcadPViewport vistaPlano;
            AcadAcCmColor color = null;
            AcadDimAligned dim;
            AcadDimAligned con;


            try
            {
                color = AcadApp.GetInterfaceObject("AutoCAD.AcCmColor.17") as AcadAcCmColor;


            }
            catch { };
            try
            {
                color = AcadApp.GetInterfaceObject("AutoCAD.AcCmColor.18") as AcadAcCmColor;

            }
            catch { };
            try
            {
                color = AcadApp.GetInterfaceObject("AutoCAD.AcCmColor.19") as AcadAcCmColor;
            }
            catch { };
            try
            {
                color = AcadApp.GetInterfaceObject("AutoCAD.AcCmColor.20") as AcadAcCmColor;

            }
            catch { };
            try
            {
                color = AcadApp.GetInterfaceObject("AutoCAD.AcCmColor.21") as AcadAcCmColor;

            }
            catch { };
            try
            {
                color = AcadApp.GetInterfaceObject("AutoCAD.AcCmColor.22") as AcadAcCmColor;

            }
            catch { };
            try
            {
                color = AcadApp.GetInterfaceObject("AutoCAD.AcCmColor.23") as AcadAcCmColor;

            }
            catch { };

            var book = new ExcelQueryFactory(Modulo.RutaExcel);
            listaEjecucion.Distinct<Ejecucion>();


            foreach (Ejecucion loc in listaEjecucion)
            {
                rutaAutocad = Modulo.RutaGuardado + "\\" + loc.ruta + ".dwg";
                doc = AcadApp.Documents.Open(rutaAutocad);



                vanos = f.VanosData(loc.loc, book);
                postes = f.PostesData(loc.loc, book);
                luminarias = f.LuminariasData(loc.loc, book);
                subestaciones = f.SubestacionesData(loc.loc, book);
                vistasCajetines = f.VistasCData(book);
                vistasDibujo = f.VistasDData(loc.loc, book);
                cajetienes = f.CajetinesData(loc.loc, book);
                capas = f.LayersData(book);

                foreach (Layers g in capas)
                {
                    color.SetRGB(g.red, g.green, g.blue);
                    layer = doc.Layers.Add(g.nombre_capa);
                    layer.TrueColor = color;
                }

                //dibujamos los vanos
                if (VanosBox.Checked)
                {
                    foreach (Vanos g in vanos)
                    {
                        pto[0] = g.x_inicial;
                        pto[1] = g.y_inicial;

                        pto2[0] = g.x_final;
                        pto2[1] = g.y_final;

                        pto3[0] = pto[0] / 2 + pto2[0] / 2;
                        pto3[1] = pto[1] / 2 + pto2[1] / 2;

                        lin = doc.ModelSpace.AddLine(pto, pto2);
                        lin.Layer = "_AereoCond";
                        dim = doc.ModelSpace.AddDimAligned(pto, pto2, pto3);
                        dim.StyleName = "ACOT-LP-FRANK";
                        dim.VerticalTextPosition = AcDimVerticalJustification.acAbove;
                        dim.Layer = "_CotaCond";
                        con = doc.ModelSpace.AddDimAligned(pto, pto2, pto3);
                        con.TextOverride = g.conductor;
                        con.StyleName = "ACOT-LP-FRANK";
                        con.VerticalTextPosition = AcDimVerticalJustification.acUnder;
                        con.Layer = "_TipoCond";

                    }
                }
                //metodo de postes
                if (Postesbox.Checked)
                {
                    foreach (Postes g in postes)
                    {
                        pto[0] = g.x_poste;
                        pto[1] = g.y_poste;
                        block = doc.ModelSpace.InsertBlock(pto, g.bloque, 1, 1, 1, 0);
                        block.Layer = "_Postes";
                        var blocAtri = block.GetAttributes();
                        blocAtri[0].TextString = g.altura;
                        blocAtri[1].TextString = g.estado;
                        blocAtri[2].TextString = g.material;
                        blocAtri[3].TextString = g.cod_poste;

                    }
                }
                //metodo de luminarias
                if (LumBox.Checked)
                {
                    foreach (Luminarias g in luminarias)
                    {
                        pto[0] = g.x_luminaria;
                        pto[1] = g.y_luminaria;
                        block = doc.ModelSpace.InsertBlock(pto, "luminaria", 1, 1, 1, 0);
                        block.Layer = "_Luminaria";
                        var blocAtri = block.GetAttributes();
                        blocAtri[0].TextString = g.potencia;
                        blocAtri[1].TextString = g.altura;
                        blocAtri[2].TextString = g.codigo_luminaria;
                    }
                }
                //metodo de subestaciones
                if (SedBox.Checked)
                {
                    foreach (Subestaciones g in subestaciones)
                    {
                        pto[0] = g.x_subestacion;
                        pto[1] = g.y_subestacion;
                        block = doc.ModelSpace.InsertBlock(pto, g.bloque, 25, 25, 25, 0);
                        block.Layer = "_Seds";
                        var blocAtri = block.GetAttributes();
                        blocAtri[0].TextString = g.potencia;
                        blocAtri[1].TextString = g.codigo_subestacion;
                    }
                }

                //metodo de creacion de vistas en cajetines

                if (CajBox.Checked)
                {
                    foreach (VistasC g in vistasCajetines)
                    {
                        pto[0] = g.x_centro;
                        pto[1] = g.y_centro;
                        pto2[0] = g.x_inicial;
                        pto2[1] = g.y_inicial;
                        pto3[0] = g.x_final;
                        pto3[1] = g.y_final;
                        doc.ActiveSpace = AcActiveSpace.acPaperSpace;
                        vistaCajetin = doc.PaperSpace.AddPViewport(pto, g.ancho, g.largo);
                        vistaCajetin.Display(true);
                        vistaCajetin.ViewportOn = true;
                        doc.MSpace = true;
                        AcadApp.ActiveDocument.ActivePViewport = vistaCajetin;
                        AcadApp.ZoomWindow(pto2, pto3);
                        doc.MSpace = false;
                    }

                    //metodo de creacion de vistas en planos


                    foreach (VistasD g in vistasDibujo)
                    {
                        pto[0] = g.x_centro;
                        pto[1] = g.y_centro;
                        pto2[0] = g.x_inicial;
                        pto2[1] = g.y_inicial;
                        pto3[0] = g.x_final;
                        pto3[1] = g.y_final;
                        doc.ActiveSpace = AcActiveSpace.acPaperSpace;
                        vistaPlano = doc.PaperSpace.AddPViewport(pto, g.ancho, g.largo);
                        vistaPlano.Display(true);
                        vistaPlano.ViewportOn = true;
                        doc.MSpace = true;
                        AcadApp.ActiveDocument.ActivePViewport = vistaPlano;
                        AcadApp.ZoomWindow(pto2, pto3);
                        doc.MSpace = false;
                    }

                    //metodo de cajetines

                    foreach (Cajetines g in cajetienes)
                    {
                        pto[0] = 0;
                        pto[1] = 0;
                        block = doc.PaperSpace.InsertBlock(pto, "cajetin", 1, 1, 1, 0);
                        block.Layer = "_MarcoPlano";
                        var blocAtri = block.GetAttributes();
                        blocAtri[0].TextString = g.escala;
                        blocAtri[1].TextString = g.fecha;
                        blocAtri[2].TextString = g.plano;
                        blocAtri[3].TextString = g.n_expediente;
                        blocAtri[4].TextString = g.departamento;
                        blocAtri[5].TextString = g.provincia;
                        blocAtri[6].TextString = g.distrito;
                        blocAtri[7].TextString = g.revisado;
                        blocAtri[8].TextString = g.aprobado;
                        blocAtri[9].TextString = g.dibujado;
                        blocAtri[10].TextString = g.anexo;
                    }
                }
                doc.Save();
                doc.Close();

            }
            book.Dispose();
            AcadApp.Quit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}  

