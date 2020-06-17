using DesignPatternProject.ChooseMenu.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternProject.ChooseMenu.DsPattern
{
    public class ChooseMenuItemAggregate : IAggregate
    {

        List<ChooseMenuItem> menuItems = null;

        public ChooseMenuItemAggregate()
        {
            menuItems = new List<ChooseMenuItem>();
        }

        public ChooseMenuItemAggregate(List<ChooseMenuItem> menuItems)
        {
            this.menuItems = menuItems;
        }

        public IChooseMenuIterator GetIterator()
        {
            return new MenuItemIterator(this);
        }

        public ChooseMenuItem this[int itemIndex]
        {
            get
            {
                if (itemIndex < menuItems.Count)
                {
                    return menuItems[itemIndex];
                }

                return new ChooseMenuItem();
            }
            set
            {
                menuItems.Add(value);
            }
        }

        public int Count
        {
            get
            {
                return menuItems.Count;
            }
        }
    }
}

