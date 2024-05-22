namespace MauiAppBindingComplexObject;

public partial class MyView : ContentView
{
	public MyView()
	{
		InitializeComponent();
	}

    public static readonly BindableProperty ItemProperty =
        BindableProperty.Create(nameof(Item), typeof(MyItem), typeof(MyView), defaultValue: null, defaultBindingMode: BindingMode.OneTime, propertyChanged: ItemPropertyChanged);
    public MyItem Item
    {
        get => (MyItem)GetValue(ItemProperty);
        set => SetValue(ItemProperty, value);
    }
    private static void ItemPropertyChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var control = (MyView)bindable;
    }

    //public static readonly BindableProperty IDTextProperty =
    //    BindableProperty.Create(nameof(IDText), typeof(int), typeof(MyView), defaultValue: 0, defaultBindingMode: BindingMode.OneTime, propertyChanged: IDTextPropertyChanged);
    //public int IDText
    //{
    //    get => (int)GetValue(IDTextProperty);
    //    set => SetValue(IDTextProperty, value);
    //}
    //private static void IDTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
    //{
    //    var control = (MyView)bindable;
    //}

    //public static readonly BindableProperty NameTextProperty =
    //BindableProperty.Create(nameof(NameText), typeof(string), typeof(MyView), defaultValue: "", defaultBindingMode: BindingMode.OneTime, propertyChanged: NameTextPropertyChanged);
    //public string NameText
    //{
    //    get => (string)GetValue(NameTextProperty);
    //    set => SetValue(NameTextProperty, value);
    //}
    //private static void NameTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
    //{
    //    var control = (MyView)bindable;
    //}

    //public static readonly BindableProperty DescriptionProperty =
    //BindableProperty.Create(nameof(DescriptionText), typeof(string), typeof(MyView), defaultValue: "", defaultBindingMode: BindingMode.OneTime, propertyChanged: DescriptionTextPropertyChanged);
    //public string DescriptionText
    //{
    //    get => (string)GetValue(DescriptionProperty);
    //    set => SetValue(DescriptionProperty, value);
    //}
    //private static void DescriptionTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
    //{
    //    var control = (MyView)bindable;
    //}
}