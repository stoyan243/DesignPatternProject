using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternProject.ChooseMenu.DsPattern
{   
    //This is a design patter Facade class
    class ChooseMenuFacade
    {
        static readonly BossMenu _bossMenu = new BossMenu();
        static readonly WorkersMenu _workersMenu = new WorkersMenu();
        static readonly ClientsMenu _clientsMenu = new ClientsMenu();
       

        /// The 'Subsystem A' class
        public static List<ChooseMenuItem> GetBossMenu()
        {
            return _bossMenu.GetBossMenuItems().Concat(GetWorkersMenu()).ToList();
        }
        /// The 'Subsystem B' class
        public static List<ChooseMenuItem> GetWorkersMenu()
        {
            return _workersMenu.GetWorkersMenuItems().Concat(GetClientsMenu()).ToList();
        }
        /// The 'Subsystem C' class
        public static List<ChooseMenuItem> GetClientsMenu()
        {
            return _clientsMenu.GetClientsMenuItems();
        }
    }
}
