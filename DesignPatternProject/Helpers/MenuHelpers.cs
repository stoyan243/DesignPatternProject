using DesignPatternProject.ChooseMenu;
using DesignPatternProject.ChooseMenu.DsPattern;
using DesignPatternProject.ChooseMenu.Interface;
using DesignPatternProject.Numerate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternProject.Helpers
{
    class MenuHelpers
    {
        static SessionHelpers currentSession = SessionHelpers.GetCurrentSession();

        /// <summary>
        /// Prints all existing roles numbered as in the enum
        /// until the user chooses a valid one, when he does
        /// the method creates session for the user.
        /// Clears the console on each print of the roles list.
        /// </summary>
        /// <param name="currentSession">Session object representing the existing session</param>
        public static void AuthenticateUserMenu()
        {
            do
            {
                int choice;

                do
                {
                    Console.Clear();
                    Console.WriteLine("Please choose your role:");
                    string[] roleNames = Enum.GetNames(typeof(PersonRole));

                    for (int i = 0; i < roleNames.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}.{roleNames[i]}");
                    }
                }
                while (!int.TryParse(Console.ReadLine(), out choice)
                            || !Enum.IsDefined(typeof(PersonRole), choice));

                currentSession.SetSession((PersonRole)choice);

            } while (!currentSession.IsAuthenticated);
        }

        public static ChooseMenuItemAggregate GetMenuItemsForCurrentUser()
        {
            ChooseMenuItemAggregate menuItems = new ChooseMenuItemAggregate();

            switch (currentSession.Role)
            {
                case PersonRole.Boss:
                    menuItems = new ChooseMenuItemAggregate(ChooseMenuFacade.GetBossMenu());
                    break;
                case PersonRole.Workers:
                    menuItems = new ChooseMenuItemAggregate(ChooseMenuFacade.GetWorkersMenu());
                    break;
                case PersonRole.Clients:
                    menuItems = new ChooseMenuItemAggregate(ChooseMenuFacade.GetClientsMenu());
                    break;
                default:
                    throw new NotImplementedException();
            }

            return menuItems;
        }

        public static void PrintMenu(ChooseMenuItemAggregate menuItems, out int choice)
        {
            if (menuItems.Count == 0)
            {
                Console.WriteLine("Нещо не е наред!Необходимо е да се свържете с поддръжката!");
                choice = -1;
                return;
            }

            IChooseMenuIterator iter = menuItems.GetIterator();
            do
            {
                Console.Clear();

                for (ChooseMenuItem s = iter.FirstItem; iter.IsDone == false; s = iter.NextItem)
                {
                    Console.WriteLine($"{iter.CurrentIndex + 1}.{s.ItemText}");
                }

                Console.WriteLine("\n0.LogoutMe");
            } while (!int.TryParse(Console.ReadLine(), out choice)
                            || menuItems.Count < choice || choice < 0);
        }
    }
}

