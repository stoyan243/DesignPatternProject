using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternProject.ChooseMenu.Interface
{   //The iterator has IChooseMenuItemIterrator, which are implemented in  MenuItemIterrator respectively
    //It defines the interface of the iterator
    public interface IChooseMenuIterator
    {
        ChooseMenuItem FirstItem { get; }

        //Move to the next  element (on the aggregate).Returns false if the end of the sequence is reached
        ChooseMenuItem NextItem { get; }

        //Returns is cuurrent item 
        ChooseMenuItem CurrentItem { get; }
        //Nextitem combines the roles of the next and isDone methods
        bool IsDone { get; }

        int CurrentIndex { get; }
    }
}
