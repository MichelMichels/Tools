using MichelMichels.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhoAmI
{
    public class MainViewModel : BasePropertyChanged
    {
        public MainViewModel()
        {
            Username = Environment.UserName;
        }

        public string Username { get; set; }
    }
}
