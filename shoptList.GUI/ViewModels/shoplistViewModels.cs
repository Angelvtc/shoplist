using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using shoptList.GUI.Models;

namespace shoptList.GUI.ViewModels
{
    internal class shoplistViewModels
    {
        public ObservableCollection<item> items { get; }

        public shoplistViewModels()
        {
            items = new ObservableCollection<item>();
            CargarDatos();
        }

        public void CargarDatos()
        {
            items.Add(new item()
            {
                Id = 1,
                Nombre = "Leche",
                Cantidad = 2
            });

            items.Add(new item()
            {
                Id = 2,
                Nombre = "Pan de caja",
                Cantidad = 1
            });

            items.Add(new item()
            {
                Id = 3,
                Nombre = "Jamón",
                Cantidad = 500
            });

        }
    }
}
