using DesignPatternProject.ChooseMenu.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternProject.ChooseMenu.DsPattern
{
    class MenuItemIterator : IChooseMenuIterator
    {

        IAggregate aggregate = null;

        public MenuItemIterator(IAggregate agg)
        {
            aggregate = agg;
        }

        public ChooseMenuItem FirstItem
        {
            get
            {
                CurrentIndex = 0;
                return aggregate[CurrentIndex];
            }
        }

        public ChooseMenuItem NextItem
        {
            get
            {
                CurrentIndex += 1;

                if (IsDone == false)
                {
                    return aggregate[CurrentIndex];
                }
                else
                {
                    return new ChooseMenuItem();
                }
            }
        }

        public ChooseMenuItem CurrentItem
        {
            get
            {
                return aggregate[CurrentIndex];
            }
        }

        public bool IsDone
        {
            get
            {
                if (CurrentIndex < aggregate.Count)
                {
                    return false;
                }

                return true;
            }
        }

        public int CurrentIndex { get; private set; } = 0;
    }
}

