using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using shoptList.GUI.Models;

namespace ShopListViewModels
{
      partial class ShopListViewModels : ObservableObject
        {
            [ObservableProperty]
            private string _nombreDelArticulo = string.Empty;
            [ObservableProperty]
            private int _cantidadAComprar = 1;
            [ObservableProperty]
            private Item _SelectedItem;

        public ObservableCollection<Item> item { get; }
       
          
            public ShopListViewModels()
            {
                item = new ObservableCollection<Item>();
                CargarDatos();
              
            }
            [RelayCommand]
            public void AgregarShopListItem()
            {
                if (string.IsNullOrEmpty(NombreDelArticulo) || CantidadAComprar <= 0)
                {
                    return;
                }
                Random generador = new Random();

                var Item = new Item
                {
                    Id = generador.Next(),
                    Nombre = NombreDelArticulo,
                    Cantidad = CantidadAComprar,
                    Comprado = false,
                };
                item.Add(Item);
            NombreDelArticulo = String.Empty;
                CantidadAComprar = 1;
            }

        [RelayCommand]
        public void EleminarShopListItem()
        {
            if (SelectedItem == null)
                return;

            int index = item.IndexOf(SelectedItem);

            item.Remove(SelectedItem);

            // Seleccionar siguiente elemento si existe
            if (item.Count > 0)
            {
                if (index >= item.Count)
                    index = item.Count - 1;

                SelectedItem = item[index];
            }
            else
            {
                SelectedItem = null;
            }
        }

        public void CargarDatos()
            {
            item.Add(new Item()
                {
                    Id = 1,
                    Nombre = "leche",
                    Cantidad = 10,
                    Comprado = false
                });
                item.Add(new Item()
                {
                    Id = 2,
                    Nombre = "Huevo",
                    Cantidad = 22,
                    Comprado = false
                });
                item.Add(new Item()
                {
                    Id = 3,
                    Nombre = "Carne",
                    Cantidad = 32,
                    Comprado = true
                });
            }
          
            }
}

