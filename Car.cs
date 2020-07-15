using System;
using System.Collections.Generic;
using System.Text;

namespace HLesson_Inheritance
{
    // Inherits from Vehicle class
    class Car : Vehicle
    {
        #region Properties and Fields
        private bool blnHasRims { get; set; }
        private bool blnConvertable { get; set; }

        #endregion

        #region Constructors
        // Example of a constructor being used to create an object (a constructor is a method)
        public Car(bool blnHasRims, bool blnConvertable, int doors, int seats, string color, int wheels,
                   int yearMade) : base (doors, seats, color, wheels, yearMade)
        {
            this.blnHasRims = blnHasRims;
            this.blnConvertable = blnConvertable;
        }
        #endregion

        #region Methods
        public override void Start()
        {
            base.Start();
            Console.WriteLine("The Car started with a Key.");
        }
                
        public override void GetVehicleDetails()
        {
            base.GetVehicleDetails();

            StringBuilder textSummaryBuilder = new StringBuilder();

            textSummaryBuilder.Append($"{this.GetType().ToString()} has rims: {blnHasRims} \n");
            textSummaryBuilder.Append($"{this.GetType().ToString()} convertable: {blnConvertable} \n");

            Console.WriteLine(textSummaryBuilder.ToString());

        }

        #endregion
    }
}
