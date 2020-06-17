using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternProject.ChooseMenu
{
    class BossMenu
    {
        internal List<ChooseMenuItem> GetBossMenuItems()
        {
            return new List<ChooseMenuItem>
            {
                new ChooseMenuItem
                {
                    ItemText = "Menu-Всички видове сайтове1",
                    SubItems = new List<ChooseMenuItem>
                    {
                        new ChooseMenuItem
                        {
                            ItemText = "Нови предложения за сайт11"
                        },

                        new ChooseMenuItem
                        {
                            ItemText = "Нови предложения за сайт12"
                        }
                    }
                },

                new ChooseMenuItem
                {
                    ItemText = "Menu-Всички видове приложения2",
                    SubItems = new List<ChooseMenuItem>
                    {
                        new ChooseMenuItem
                        {
                            ItemText = "Нови предложения за приложения21"
                        },

                        new ChooseMenuItem
                        {
                            ItemText = "Нови предложения за приложения22"
                        }
                    }
                }
            };
        }
    }
}

