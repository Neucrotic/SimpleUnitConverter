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
        string from = null;
        string to = null;
        decimal units;
        UnitConverter.Units fromUnits;
        UnitConverter.Units toUnits;

        string blankResult = "0.0000";

        public MainPage()
        {
            InitializeComponent();

            unitConverters.Add(new AreaConverter());
            unitConverters.Add(new LengthConverter());
            unitConverters.Add(new SpeedConverter());
            unitConverters.Add(new TemperatureConverter());

            unitTypePicker.ItemsSource = unitConverters;
            resultLabel.Text = blankResult;
        }

        private void Picker_OnUnitChanged(object sender, EventArgs e)
        {
            foreach (var uc in unitConverters)
            {
                if (uc == ((Picker)sender).SelectedItem)
                {
                    SelectedConverter = uc;
                }
            }
            unitFromPicker.ItemsSource = SelectedConverter.GetAllUnitsAsStrings();
            unitToPicker.ItemsSource = SelectedConverter.GetAllUnitsAsStrings();
            from = null;
            to = null;
        }

        private void Picker_OnFromChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            from = (string)picker.SelectedItem;

            if(from != null && from == to)
            {
                UnitConverter.Units tempFrom = fromUnits;
                fromUnits = toUnits;
                toUnits = tempFrom;

                unitToPicker.SelectedItem = SelectedConverter.GetUnitAsString(toUnits);
                unitFromPicker.SelectedItem = SelectedConverter.GetUnitAsString(fromUnits);

                units = Convert.ToDecimal(valueInput.Text);
                if (units != 0)
                    ConvertUnits(units);
            }
            else
            {
                fromUnits = SelectedConverter.GetStringsAsUnits(from);

                if (to != null)
                {
                    ConvertUnits(units);
                }
            }
        }

        private void Picker_OnToChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            to = (string)picker.SelectedItem;

            if (to != null && to == from)
            {
                UnitConverter.Units tempFrom = fromUnits;
                fromUnits = toUnits;
                toUnits = tempFrom;

                unitToPicker.SelectedItem = SelectedConverter.GetUnitAsString(toUnits);
                unitFromPicker.SelectedItem = SelectedConverter.GetUnitAsString(fromUnits);

                units = Convert.ToDecimal(valueInput.Text);
                if (units != 0)
                    ConvertUnits(units);
            }
            else
            {
                toUnits = SelectedConverter.GetStringsAsUnits(to);

                if (from != null)
                    ConvertUnits(units);
            }
        }

        private void Entry_OnValueInput(object sender, TextChangedEventArgs e)
        {
            if (e.NewTextValue != "")
            {
                units = Convert.ToDecimal(e.NewTextValue);
                ConvertUnits(units);
            }
            else if (e.NewTextValue == "")
            {
                resultLabel.Text = blankResult;
            }
        }

        private void Button_OnSwapConversion(object sender, EventArgs e)
        {
            if (from != null  && to != null)
            {
                UnitConverter.Units tempFrom = fromUnits;
                fromUnits = toUnits;
                toUnits = tempFrom;

                unitToPicker.SelectedItem = SelectedConverter.GetUnitAsString(toUnits);
                unitFromPicker.SelectedItem = SelectedConverter.GetUnitAsString(fromUnits);

                units = Convert.ToDecimal(valueInput.Text);
                if (units != 0)
                    ConvertUnits(units);
            }
        }

        private void ConvertUnits(decimal units)
        {
            decimal result = SelectedConverter.Convert(fromUnits, toUnits, units);
            result = Decimal.Round(result, 6);
            if (result == 0)
            {
                resultLabel.Text = blankResult;
            }
            else
            {
                resultLabel.Text = result.ToString();
            }
            
        }
    }
}