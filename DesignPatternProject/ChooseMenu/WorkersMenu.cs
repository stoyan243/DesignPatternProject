using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternProject.ChooseMenu
{
    class WorkersMenu
    {
        internal List<ChooseMenuItem> GetWorkersMenuItems()
        {
            return new List<ChooseMenuItem>
            {
                new ChooseMenuItem
                {
                    ItemText = "Menu-Всички проекти за разбратка на сайтове1",
                    SubItems = new List<ChooseMenuItem>
                    {
                        new ChooseMenuItem
                        {
                            ItemText = "СайтЗаСчетоводители11"
                        },

                        new ChooseMenuItem
                        {
                            ItemText = "СайтЗаТърговия12"
                        }
                    }
                },

                new ChooseMenuItem
                {
                    ItemText = "Menu-Всички проекти за разработка на приложения2",
                    SubItems = new List<ChooseMenuItem>
                    {
                        new ChooseMenuItem
                        {
                            ItemText = "Приложение (Messanger)21"
                        },

                        new ChooseMenuItem
                        {
                            ItemText = "Приложение (Instagram)22"
                        }
                    }
                }
            };
        }
    }
}

