using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternProject.ChooseMenu.Interface
{
     interface IAggregate
    {  
        //The iterator has IAggregate , which are implemented in ChooseMenuItemAggregate 
       
        IChooseMenuIterator GetIterator();
        ChooseMenuItem this[int itemIndex] { get; set; }
        int Count { get; }
     }
}
