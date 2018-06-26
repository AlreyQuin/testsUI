using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoItX3Lib;

namespace addressbook_tests_autoit
{
    public class ApplicationManager
    {
        public static string WINTITLE = "Free Address Book";
        private GroupHelper groupHelper;
        private AutoItX3 aux;

        public ApplicationManager()
        {
            aux = new AutoItX3();
            aux.Run(@"D:\Tests\Progs\AddressBook\AddressBook.exe", "", aux.SW_SHOW);
            aux.WinWait(WINTITLE);
            aux.WinActivate(WINTITLE);
            aux.WinWaitActive(WINTITLE);
            groupHelper = new GroupHelper(this);
        }

        public void Stop()
        {
            aux.ControlClick(WINTITLE, "Exit", "WindowsForms10.BUTTON.app.0.2c908d510");
        }

        public AutoItX3 Aux
        {
            get
            {
                return aux;
            }
            set
            {
                aux = value;
            } 
        }

        public GroupHelper Groups
        {
            get
            {
                return groupHelper;
            }
        }

    }
}
