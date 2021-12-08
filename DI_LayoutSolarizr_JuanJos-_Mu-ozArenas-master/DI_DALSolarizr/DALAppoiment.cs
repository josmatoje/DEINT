using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI_EntitiesSolarz;
using DI_LayoutSolarizr_JuanJosé_MuñozArenas;

namespace DI_DALSolarizr
{
    public class DALAppoiment
    {

        /// <summary>
        /// Method that simulate a connection to a database, returning a list of appoiments (that should be in the database)
        /// </summary>
        /// <returns> List<Appoiment> appoiments</returns>
        public static List<Appoiment> getListOfAppoiments()
        {
            List<Appoiment> appoiments = new List<Appoiment>();
            appoiments.Add(new Appoiment(new DateTime(2000, 12, 3, 9, 30, 00), "Failure", new Costumer("SDK17", "C/Java lang Autoclosable Nº8 ", "74584538")));
            appoiments.Add(new Appoiment(new DateTime(2000, 12, 22, 18, 15, 00), "Incidence", new Costumer("Microsoft", "C/Windows Forms Nº2 ", "45471552")));
            appoiments.Add(new Appoiment(new DateTime(2000, 12, 6, 19, 45, 00), "Failure", new Costumer("TextBox", "C/.setText Nº27", "54784553")));
            appoiments.Add(new Appoiment(new DateTime(2000, 12, 14, 12, 00, 00), "Instalation", new Costumer("SDK17", "C/Java lang Scanner Nº13 ", "11924538")));
            appoiments.Add(new Appoiment(new DateTime(2000, 11, 13, 9, 15, 00), "Incidence", new Costumer("Microsoft", "C/ASP NET Core Nº6 ", "65477212")));
            appoiments.Add(new Appoiment(new DateTime(2000, 12, 6, 11, 30, 00), "Failure", new Costumer("TextBox", "C/.getText Nº42", "819045532")));
            return appoiments;
        }

    }
}
