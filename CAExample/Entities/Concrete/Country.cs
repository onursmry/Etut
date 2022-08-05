namespace CAExample.Entities.Concrete
{
    public class Country
    {
        private string _countryName;

        public string CountryName
        {
            get { return _countryName; }
            set { _countryName = value; }
        }

        private string _capital;

        private string Capital
        {
            get => _capital;
            set => _capital = value;
        }

        private long _population;

        public long Population
        {
            get => _population;
            set => _population = value;
        }

        private string _currencyUnit;

        public string CurrencyUnit
        {
            get => _currencyUnit;
            set => _currencyUnit = value;
        }
    }
}