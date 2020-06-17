using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternProject.ChooseMenu
{
    class ClientsMenu
    {
        internal List<ChooseMenuItem> GetClientsMenuItems()
        {
            return new List<ChooseMenuItem>
            {
                new ChooseMenuItem
                {
                    ItemText = "Menu-Примерен  проект за сайт1",
                    SubItems = new List<ChooseMenuItem>
                    {
                        new ChooseMenuItem
                        {
                            ItemText = "ДемоВерсияНаПроектЗаСайт11"
                        },

                        new ChooseMenuItem
                        {
                            ItemText = "ДемоВерсияНаПроектЗаСайт12"
                        }
                    }
                },

                new ChooseMenuItem
                {
                    ItemText = "Menu-Примерен проект за приложение2",
                    SubItems = new List<ChooseMenuItem>
                    {
                        new ChooseMenuItem
                        {
                            ItemText = "ДемоВерсияНаПроект21"
                        },

                        new ChooseMenuItem
                        {
                            ItemText = "ДемоВерсияНаПроект22"
                        }
                    }
                }
            };
        }
    }
}

