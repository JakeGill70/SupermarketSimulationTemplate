using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace SimulationLogic
{
    public class GuiController : IGuiController
    {
        /// <summary>
        /// Implements <see cref="IGuiController.UpdateUI(Supermarket, string[], List{string}[], ISupermarketStatistics)"/>
        /// </summary>
        public void UpdateUI(Supermarket supermarket, string[] queueLabels, List<string>[] queueOfCustomers, ISupermarketStatistics supermarketStatistics)
        {
            throw new NotImplementedException();
        }
    }
}
