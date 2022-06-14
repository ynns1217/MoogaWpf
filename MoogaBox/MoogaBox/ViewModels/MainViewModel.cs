using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoogaBox.ViewModels
{
    class MainViewModel : ViewModelBase
    {
        private string id;
        private string pw;

        public string Id
        {
            get => id; set
            {
                id = value;
            }
        }   
        public string Pw
        {
            get => pw; set
            {
                pw = value;
            }
        }
        //InsertPW
    }
}
