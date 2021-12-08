using DI_EntitiesSolarz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DI_LayoutSolarizr_JuanJosé_MuñozArenas.ViewModels
{
    public class AppoimentsPageViewModel
    {
        private List<Appoiment> appoiments = new List<Appoiment>();

        public AppoimentsPageViewModel(){
            appoiments = DI_DALSolarizr.DALAppoiment.getListOfAppoiments();
        }

        public List<Appoiment> Appoiments
        {
            get { return appoiments; }
        }

    }
}
