using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternProject.ChooseMenu
{
    public class ChooseMenuItem
    {
        public string ItemText { get; set; }

        public List<ChooseMenuItem> SubItems { get; set; } = new List<ChooseMenuItem>();
    }
}
