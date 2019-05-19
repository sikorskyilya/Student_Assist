using Student_Assist.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
namespace Student_Assist.ViewModel
{
    class RaspView : DependencyObject
    {
        public string FilterRasp
        {
            get { return (string)GetValue(FilterRaspProperty); }
            set { SetValue(FilterRaspProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FilterRasp.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FilterRaspProperty =
             DependencyProperty.Register("FilterRasp", typeof(string), typeof(RaspView), new PropertyMetadata("", FilterRasp_Changed));

        private static void FilterRasp_Changed(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var current = d as RaspView;
            if (current != null)
            {
                current.Items.Filter = null;
                current.Items.Filter = current.FilterPasp;
            }
        }

        public ICollectionView Items
        {
            get { return (ICollectionView)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemsProperty =
            DependencyProperty.Register("Items", typeof(ICollectionView), typeof(RaspView), new PropertyMetadata(null));
        public RaspView()
        {
            Items = CollectionViewSource.GetDefaultView(Rasp.GetDataRas());
            Items.Filter = FilterPasp;
        }
        private bool FilterPasp(object obj)
        {
            bool result = true;
            Rasp dataRas = obj as Rasp;
            if (!string.IsNullOrWhiteSpace(FilterRasp) && !dataRas.Place.Contains(FilterRasp) && dataRas != null && !dataRas.Day.Contains(FilterRasp) && !dataRas.Teacher.Contains(FilterRasp) && !dataRas.Time.Contains(FilterRasp) && !dataRas.Subject.Contains(FilterRasp) && !dataRas.Type.Contains(FilterRasp))
            {
                return false;
            }
            return result;
        }
    }
}
