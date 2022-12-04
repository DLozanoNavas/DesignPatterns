using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    /// <summary>
    /// Product
    /// </summary>
    public abstract class TaxService
    {
        public abstract double Tax { get; }
        public override string ToString() => this.GetType().Name;
    }

    /// <summary>
    /// Concrete Product
    /// </summary>
    public class CountryTaxService : TaxService
    {
        private readonly string _countryCode;
        public CountryTaxService(string countryIdentifier)
        {
            _countryCode = countryIdentifier;
        }

        public override double Tax {
            get
            {
                return _countryCode switch
                {
                    "USA" => 16,
                    "COL" => 19,
                    _ => 0
                };
            }
        }
    }
    
    /// <summary>
    /// Concrete Product
    /// </summary>
    public class StateTaxService : TaxService
    {
        private readonly string _stateCode;
        public StateTaxService(string stateCode)
        {
            _stateCode = stateCode;
        }

        public override double Tax {
            get
            {
                return _stateCode switch
                {
                    "DE" => 0,
                    "FL" => 16,
                    _ => 0
                };
            }
        }
    }

    /// <summary>
    /// Creator
    /// </summary>
    public abstract class TaxFactory
    {
        public abstract TaxService CreateTaxService();
    }

    /// <summary>
    /// Concrete Creator
    /// </summary>
    public  class CountryTaxFactory : TaxFactory
    {
        private readonly string _countryCode;
        public CountryTaxFactory(string countryCode)
        {
            _countryCode = countryCode;
        }

        public override TaxService CreateTaxService()
        {
            return new CountryTaxService(_countryCode);
        }
    }
    
    /// <summary>
    /// Concrete Creator
    /// </summary>
    public  class StateTaxFactory : TaxFactory
    {
        private readonly string _stateCode;

        public StateTaxFactory(string stateCode)
        {
            _stateCode = stateCode;
        }

        public override TaxService CreateTaxService()
        {
            return new StateTaxService(_stateCode);
        }
    }
}
