using DesignPatternProject.ChooseMenu.DsPattern;
using DesignPatternProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternProject
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                SessionHelpers currentSession = SessionHelpers.GetCurrentSession();

                MenuHelpers.AuthenticateUserMenu();

                ChooseMenuItemAggregate menuItems = MenuHelpers.GetMenuItemsForCurrentUser();

                do
                {
                    MenuHelpers.PrintMenu(menuItems, out int choice);
                    if (choice == 0)
                    {
                        currentSession.LogoutMe();
                        break;
                    }
                    if (choice == -1)
                    {
                        return;
                    }
                    menuItems = new ChooseMenuItemAggregate(menuItems[choice].SubItems);
                } while (true);
            } while (true);
        }
    }
}
