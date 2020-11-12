using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartDemo
{
    public class ViewModel
    {
        public ObservableCollection<Model> Data { get; set; }
        private ObservableCollection<Model> Data1 { get; set; }
        private ObservableCollection<Model> Data2 { get; set; }
        private ObservableCollection<Model> Data3 { get; set; }
        private ObservableCollection<Model> Data4 { get; set; }

        public ViewModel()
        {
            Data1 = new ObservableCollection<Model>
            {
                new Model("Toyota", 8),
                new Model("Ford", 12),
                new Model("GM", 17),
                new Model("Renault", 6),
                new Model("Fiat", 3),
                new Model("Hyundai", 16)
            };

            Data2 = new ObservableCollection<Model>
            {
                new Model("Toyota", 7),
                new Model("Chrysler", 12),
                new Model("Nissan", 9),
                new Model("Ford", 15),
                new Model("Tata", 10),
                new Model("Mahindra", 7)
            };

            Data3 = new ObservableCollection<Model>
            {
                new Model("Nissan", 9),
                new Model("Chrysler", 4),
                new Model("Ford", 7),
                new Model("Toyota", 20),
                new Model("Suzuki", 13),
                new Model("Lada", 12),
            };

            Data4 = new ObservableCollection<Model>
            {
                new Model("Hummer", 11),
                new Model("Ford", 5),
                new Model("GM", 12),
                new Model("Chrysler", 3),
                new Model("Jaguar", 9),
                new Model("Fiat", 8),
            };

            Data = new ObservableCollection<Model>
            {
                new Model("SUV", 25,Data1),
                new Model("Car", 37,Data2),
                new Model("Pickup", 15,Data3),
                new Model("Minivan", 23,Data4)
            };
        }
    }
}
