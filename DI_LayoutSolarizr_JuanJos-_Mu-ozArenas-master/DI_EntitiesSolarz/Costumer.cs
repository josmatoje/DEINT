using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_EntitiesSolarz
{
    public class Costumer{
        #region private atributes
        private string name;
        private string address;
        private string phoneNumber;
        #endregion

        #region Constructors
        public Costumer(){
            this.name = "default";
            this.address = "default street";
            this.phoneNumber = "000000000";      
        }

        public Costumer(string name,string address,string phoneNumber){
            this.name = name;
            this.address = address;
            this.phoneNumber = phoneNumber;
        }

        #endregion

        #region getters&setters
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        #endregion

    }
}
