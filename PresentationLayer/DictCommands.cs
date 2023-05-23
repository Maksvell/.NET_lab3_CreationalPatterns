using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace PresentationLayer
{
    public class DictCommands : IDictCommands
    {
        private readonly IClient client;
        public DictCommands(IClient c)
        {
            client = c;
        }
        public Dictionary<CommandsEnum, Action> Dict = new Dictionary<CommandsEnum, Action>();

        public void Load()
        {
            Dict[CommandsEnum.SaleBookToKiosk] = new Action(client.SaleBookToKiosk);
            Dict[CommandsEnum.SaleMagazineToKiosk] = new Action(client.SaleMagazineToKiosk);
            Dict[CommandsEnum.SaleBookToLibrary] = new Action(client.SaleBookToLibrary);
            Dict[CommandsEnum.SaleMagazineToLibrary] = new Action(client.SaleMagazineToLibrary);
            Dict[CommandsEnum.ShowProfit] = new Action(client.ShowProfit);
        }

        public void Invoke(int num)
        {
            if (Enum.TryParse((num - 1).ToString(), out CommandsEnum command)) {
                if (Dict.ContainsKey(command))
                {
                    Dict[command]();
                }
                else Console.WriteLine("Wrong input");
            }
            else Console.WriteLine("Wrong input");
        }
    }
}
