using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

using System.Windows.Forms;
using System.Collections;
using LinqToExcel;

namespace WindowsFormsApp1
{
    class obExcel
    {
        
        public IEnumerable<Vanos> VanosData(string loc,ExcelQueryFactory book)
        {
            

            var res = (from row in book.Worksheet("VANOS")
                       let item = new Vanos
                       {
                           id = row[0].Cast<string>(),
                           codigo = row[1].Cast<string>(),
                           codigo_subestacion = row[2].Cast<string>(),
                           codigo_localidad = row[3].Cast<string>(),
                           capa_vano = row[4].Cast<string>(),
                           x_inicial = row[5].Cast<double>(),
                           y_inicial = row[6].Cast<double>(),
                           x_final = row[7].Cast<double>(),
                           y_final = row[8].Cast<double>(),
                           conductor = row[9].Cast<string>()
                       }
                       select item).ToList();
            //book.Dispose();
            IEnumerable<Vanos> vanos = from h in res where h.codigo_localidad == loc select h;

            return vanos;


        }
        public IEnumerable<Postes> PostesData(string loc, ExcelQueryFactory book)
        {

            

            var res = (from row in book.Worksheet("POSTES")
                       let item = new Postes
                       {
                           id = row[0].Cast<string>(),
                           codigo_subestacion = row[1].Cast<string>(),
                           codigo_localidad = row[2].Cast<string>(),
                           bloque = row[3].Cast<string>(),
                           x_poste = row[4].Cast<double>(),
                           y_poste = row[5].Cast<double>(),
                           material = row[6].Cast<string>(),
                           altura = row[7].Cast<string>(),
                           estado = row[8].Cast<string>(),
                           cod_poste = row[9].Cast<string>()

                       }
                       select item).ToList();
            //book.Dispose();

            IEnumerable<Postes> postes = from h in res where h.codigo_localidad == loc select h;


            return postes;


        }

        public IEnumerable<Luminarias> LuminariasData(string loc, ExcelQueryFactory book)
        {

           
            var res = (from row in book.Worksheet("LUMINARIAS")
                       let item = new Luminarias
                       {
                           id = row[0].Cast<string>(),
                           codigo_subestacion = row[1].Cast<string>(),
                           codigo_localidad = row[2].Cast<string>(),
                           codigo_vano = row[3].Cast<string>(),
                           codigo_vano_int = row[4].Cast<string>(),
                           x_luminaria = row[5].Cast<double>(),
                           y_luminaria = row[6].Cast<double>(),
                           potencia = row[7].Cast<string>(),
                           altura = row[8].Cast<string>(),
                           codigo_luminaria = row[9].Cast<string>()
                       }
                       select item).ToList();
            //book.Dispose();

            IEnumerable<Luminarias> luminarias = from h in res where h.codigo_localidad == loc select h;


            return luminarias;


        }
    
    public IEnumerable<Subestaciones> SubestacionesData(string loc, ExcelQueryFactory book)
    {


        var res = (from row in book.Worksheet("SED")
                   let item = new Subestaciones
                   {
                       id = row[0].Cast<string>(),
                       codigo_localidad = row[1].Cast<string>(),
                       codigo_interno = row[2].Cast<string>(),
                       numero_sed = row[3].Cast<string>(),
                       codigo_subestacion = row[4].Cast<string>(),
                       bloque = row[5].Cast<string>(),
                       x_subestacion = row[6].Cast<double>(),
                       y_subestacion = row[7].Cast<double>(),
                       numero_fases = row[8].Cast<string>(),
                       tension_mt = row[9].Cast<string>(),
                       potencia = row[10].Cast<string>(),
                       id_subestacion = row[11].Cast<string>()
                   }
                   select item).ToList();
        //book.Dispose();

        IEnumerable<Subestaciones> subestaciones = from h in res where h.codigo_localidad == loc select h;


        return subestaciones;
    }

        public IEnumerable<Layers> LayersData( ExcelQueryFactory book)
        {

         

            var res = (from row in book.Worksheet("LAYERS")
                       let item = new Layers
                       {
                           id = row[0].Cast<string>(),
                           objecto = row[1].Cast<string>(),
                           nombre_capa = row[2].Cast<string>(),
                           red = row[3].Cast<int>(),
                           green = row[4].Cast<int>(),
                           blue = row[5].Cast<int>(),
                           
                       }
                       select item).ToList();
           // book.Dispose();

            IEnumerable<Layers> layers = from h in res where h.id !=null select h;

            return layers;
        }

        public IEnumerable<Localidades> LocalidadesData( ExcelQueryFactory book)
        {

            

            var res = (from row in book.Worksheet("LOCALIDADES")
                       let item = new Localidades
                       {
                           id = row[0].Cast<string>(),
                           nombre_plano = row[1].Cast<string>(),
                           nombre= row[2].Cast<string>(),
                           tipo = row[3].Cast<string>(),
                           provincia = row[4].Cast<string>(),
                           departamento = row[5].Cast<string>(),

                       }
                       select item).ToList();
           // book.Dispose();

            IEnumerable<Localidades> localidades = from h in res where h.id !=  null  select h;

            return localidades;
        }



        public IEnumerable<VistasC> VistasCData( ExcelQueryFactory book)
        {

         

            var res = (from row in book.Worksheet("VISTASC")
                       let item = new VistasC
                       {
                           id_vista = row[0].Cast<string>(),
                           x_centro = row[1].Cast<double>(),
                           y_centro = row[2].Cast<double>(),
                           ancho = row[3].Cast<double>(),
                           largo = row[4].Cast<double>(),
                           x_inicial = row[5].Cast<double>(),
                           y_inicial = row[6].Cast<double>(),
                           x_final = row[7].Cast<double>(),
                           y_final = row[8].Cast<double>(),

                       }
                       select item).ToList();
            //book.Dispose();

            IEnumerable<VistasC> vistasC = from h in res where h.id_vista != null select h;

            return vistasC;
        }

        public IEnumerable<VistasD> VistasDData(string loc, ExcelQueryFactory book)
        {

          

            var res = (from row in book.Worksheet("VISTASD")
                       let item = new VistasD
                       {
                           id_vista = row[0].Cast<string>(),
                           localidad = row[1].Cast<string>(),
                           x_centro = row[2].Cast<double>(),
                           y_centro = row[3].Cast<double>(),
                           ancho = row[4].Cast<double>(),
                           largo = row[5].Cast<double>(),
                           x_inicial = row[6].Cast<double>(),
                           y_inicial = row[7].Cast<double>(),
                           x_final = row[8].Cast<double>(),
                           y_final = row[9].Cast<double>(),

                       }
                       select item).ToList();
            // book.Dispose();

            IEnumerable<VistasD> vistasD = from h in res where h.localidad == loc select h;

            return vistasD;
        }

        public IEnumerable<Cajetines> CajetinesData(string loc, ExcelQueryFactory book)
        {


            var res = (from row in book.Worksheet("CAJETINES")
                       let item = new Cajetines
                       {
                           id_localidad = row[0].Cast<string>(),
                           nombre = row[1].Cast<string>(),
                           tipo = row[2].Cast<string>(),
                           escala = row[3].Cast<string>(),
                           fecha = row[4].Cast<string>(),
                           plano = row[5].Cast<string>(),
                           n_expediente = row[6].Cast<string>(),
                           departamento = row[7].Cast<string>(),
                           provincia = row[8].Cast<string>(),
                           distrito = row[9].Cast<string>(),
                           revisado = row[10].Cast<string>(),
                           aprobado = row[11].Cast<string>(),
                           dibujado = row[12].Cast<string>(),
                           anexo = row[13].Cast<string>(),

                       }
                       select item).ToList();
           // book.Dispose();

            IEnumerable<Cajetines> cajetines = from h in res where h.id_localidad == loc select h;

            return cajetines;
        }
    }


}

           
          



   