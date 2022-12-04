using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// Builder
    /// </summary>
    public interface ISandwichBuilder
    {
        Sandwich Sandwich { get; set; } // Concrete (or abstract product)
        public void BuildSandwich();
    }

    public abstract class SandwichBuilder : ISandwichBuilder
    {
        public Sandwich Sandwich { get;  set; }
        public SandwichBuilder(string sandwichType)
        {
            Sandwich = new Sandwich(sandwichType);
        }
        public abstract void BuildSandwich();

    }

    /// <summary>
    /// Concrete Builder
    /// </summary>
    public class TunaSandwich : SandwichBuilder
    {
        public TunaSandwich(): base("Tuna")
        {
        }

        public override void BuildSandwich()
        {
            Sandwich.AddLayer("Bread");
            Sandwich.AddLayer("Tuna");
            Sandwich.AddLayer("Bread");
        }
    }

    /// <summary>
    /// Concrete Builder
    /// </summary>
    public class ChickenSandwich : SandwichBuilder
    {
        public ChickenSandwich() : base("Chicken")
        {
        }

        public override void BuildSandwich()
        {
            Sandwich.AddLayer("Bread");
            Sandwich.AddLayer("Chicken");
            Sandwich.AddLayer("Bread");
        }
    }

    /// <summary>
    /// Product
    /// </summary>
    public class Sandwich
    {
        private readonly string _sandwichType;
        private readonly List<string> _layers = new();
        public Sandwich(string sandwichType)
        {
            _sandwichType = sandwichType;
        }

        public void AddLayer(string layer) => _layers.Add(layer);

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"TYPE: {_sandwichType}");
            foreach (var layer in _layers)
            {
                sb.AppendLine(layer);
            }
            return sb.ToString();
        }
    }

}
