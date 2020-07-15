using System;
using System.Collections.Generic;
using System.Text;

namespace HLesson_Inheritance
{
    class Boat : Vehicle
    {
        #region Properties and Fields
        private bool blnHasRutters { get; set; }
        private bool blnHasSails { get; set; }
        private string boatType { get; set; }

        #endregion

        #region Constructors
        // Example of a constructor being used to create an object (a constructor is a method)
        public Boat(bool blnHasRutters, bool blnHasSails, string boatType,
                    int doors, int seats, string color, int wheels, int yearMade) : base(doors, seats, color, wheels, yearMade)
        {
            this.blnHasRutters = blnHasRutters;
            this.blnHasSails = blnHasSails;
            this.boatType = boatType;

        }
        #endregion

        #region Methods
        public override void Start()
        {
            base.Start();
            Console.WriteLine("The Boat started with a key and button.");
        }

        public override void GetVehicleDetails()
        {
            base.GetVehicleDetails();

            StringBuilder textSummaryBuilder = new StringBuilder();

            textSummaryBuilder.Append($"{this.GetType().ToString()} has rutters: {blnHasRutters} \n");
            textSummaryBuilder.Append($"{this.GetType().ToString()} has sails: {blnHasSails} \n");
            textSummaryBuilder.Append($"{this.GetType().ToString()} boat type: {boatType} \n");


            Console.WriteLine(textSummaryBuilder.ToString());

        }

        #endregion
    }
}
