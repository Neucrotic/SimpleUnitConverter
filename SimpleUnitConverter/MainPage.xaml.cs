using System.Collections.ObjectModel;

namespace SimpleUnitConverter
{
    public partial class MainPage : ContentPage
    {
        List<UnitConverter> unitConverters = new List<UnitConverter>();
        public List<UnitConverter> UnitConverters { get { return unitConverters; } }
        
        //Used by the picker to choose conversion
        public UnitConverter SelectedConverter { get; set; }

        //Store values for converting.
        string from;
        string to;
        UnitConverter.Units fromUnits;
        UnitConverter.Units toUnits;

        public MainPage()
        {
            InitializeComponent();

            unitConverters.Add(new AreaConverter());
            unitConverters.Add(new LengthConverter());
            unitConverters.Add(new SpeedConverter());
            unitConverters.Add(new TemperatureConverter());

            unitTypePicker.ItemsSource = unitConverters;
        }

        private void unitTypePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var uc in unitConverters)
            {
                if (uc == ((Picker)sender).SelectedItem)
                {
                    SelectedConverter = uc;
                }
            }
            unitFromPicker.ItemsSource = SelectedConverter.GetUnitsAsStrings();
            unitToPicker.ItemsSource = SelectedConverter.GetUnitsAsStrings();
        }

        private void unitFromPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            from = (string)picker.SelectedItem;
            fromUnits = SelectedConverter.GetStringsAsUnits(from);
        }

        private void unitToPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            to = (string)picker.SelectedItem;
            toUnits = SelectedConverter.GetStringsAsUnits(to);
        }

        private void valueEntryFrom_TextChanged(object sender, TextChangedEventArgs e)
        {
            int units = Convert.ToInt32(e.NewTextValue);
            double result = SelectedConverter.Convert(fromUnits, toUnits, units);
            valueEntryTo.UpdateText(result.ToString());
        }
    }
}