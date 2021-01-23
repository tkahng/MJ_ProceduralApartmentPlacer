// This code was generated by Hypar.
// Edits to this code will be overwritten the next time you run 'hypar init'.
// DO NOT EDIT THIS FILE.

using Elements;
using Elements.GeoJSON;
using Elements.Geometry;
using Hypar.Functions;
using Hypar.Functions.Execution;
using Hypar.Functions.Execution.AWS;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace MJProceduralApartmentPlacer
{
    public class MJProceduralApartmentPlacerOutputs: ResultsBase
    {
		/// <summary>
		/// Apartment units placed.
		/// </summary>
		[JsonProperty("Units Placed")]
		public double UnitsPlaced {get;}

		/// <summary>
		/// Apartment units remaining/ not placed.
		/// </summary>
		[JsonProperty("Units Remaining")]
		public double UnitsRemaining {get;}



        /// <summary>
        /// Construct a MJProceduralApartmentPlacerOutputs with default inputs.
        /// This should be used for testing only.
        /// </summary>
        public MJProceduralApartmentPlacerOutputs() : base()
        {

        }


        /// <summary>
        /// Construct a MJProceduralApartmentPlacerOutputs specifying all inputs.
        /// </summary>
        /// <returns></returns>
        [JsonConstructor]
        public MJProceduralApartmentPlacerOutputs(double unitsPlaced, double unitsRemaining): base()
        {
			this.UnitsPlaced = unitsPlaced;
			this.UnitsRemaining = unitsRemaining;

		}

		public override string ToString()
		{
			var json = JsonConvert.SerializeObject(this);
			return json;
		}
	}
}