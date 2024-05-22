using System.Collections.ObjectModel;

namespace MauiAppBindingComplexObject
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<MyItem> Lista { get; set; } = new ObservableCollection<MyItem>();

        public MainPage()
        {
            InitializeComponent();

            this.BindingContext = this;

            Lista.Add(new MyItem { ID = 1, Name = "Agus", Description = "Developer" });
            Lista.Add(new MyItem { ID = 2, Name = "Agus 2", Description = "werwr" });
            Lista.Add(new MyItem { ID = 3, Name = "Agus 3", Description = "otro" });
            Lista.Add(new MyItem { ID = 4, Name = "Agus 4 ", Description = "chan" });
            Lista.Add(new MyItem { ID = 5, Name = "Agus 5 ", Description = "ooops" });
            Lista.Add(new MyItem { ID = 6, Name = "Agus6", Description = "lorep dasdsade fd  fsd f sdf sd fs f sd fs df " });

            Appearing += (s, e) =>
            {
                Dispatcher.StartTimer(TimeSpan.FromMilliseconds(4000), () => 
                {
                    Lista.Add(new MyItem { ID = 7, Name = "Agus 7", Description = "agregado" });
                    return false; 
                });
            };
        }        
    }
}
