using DI_EntitiesSolarz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DI_LayoutSolarizr_JuanJosé_MuñozArenas
{
    public class Appoiment
    {
        #region privates atributes
        private DateTime date;
        private string appoimentType;
        private Costumer costumer;
        #endregion

        #region constructors
        public Appoiment()
        {
            this.date= DateTime.Now;
            this.appoimentType = "default appoiment type";
            this.costumer = new Costumer();
        }
        public Appoiment(DateTime date, string appoimentType, Costumer costumer)
        {
            this.date = date;
            this.appoimentType = appoimentType;
            this.costumer = costumer;
        }
        #endregion

        #region getters & setters
        public DateTime Date { get => date; set => date = value; }
        public string AppoimentType { get => appoimentType; set => appoimentType = value; }
        public Costumer Costumer { get => costumer; set => costumer = value; }
        #endregion
    }
    
}