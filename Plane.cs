using System;
using System.Collections.Generic;
using System.Text;

namespace HLesson_Inheritance
{
    class Plane : Vehicle
    {
        #region Properties and Fields
        public bool blnLandingGear { get; set; }
        public int NumOfEngines { get; set; }
        public int wingSpan { get; set; }

        #endregion

        #region Constructors
        // Example of a constructor being used to create an object (a constructor is a method)
        public Plane(bool blnLandingGear, int NumOfEngines, int wingSpan, int doors, int seats,
                     string color, int wheels, int yearMade) : base(doors, seats, color, wheels, yearMade)
        {
            this.blnLandingGear = blnLandingGear;
            this.NumOfEngines = NumOfEngines;
            this.wingSpan = wingSpan;

        }
        #endregion

        #region Methods
        public override void Start()
        {
            base.Start();
            Console.WriteLine("The Plane started with switches.");
        }

        // Displays results in console
        public override void GetVehicleDetails()
        {
            base.GetVehicleDetails();

            StringBuilder textSummaryBuilder = new StringBuilder();

            textSummaryBuilder.Append($"\n\n***** START {this.GetType().ToString()} CHILD GetVehicleDetails() VALUES ***** \n\n");

            textSummaryBuilder.Append($"{this.GetType().ToString()} landing gear: {blnLandingGear} \n");
            textSummaryBuilder.Append($"{this.GetType().ToString()} number of engines: {NumOfEngines} \n");
            textSummaryBuilder.Append($"{this.GetType().ToString()} wingspan: {wingSpan} \n");


            Console.WriteLine(textSummaryBuilder.ToString());

        }

        // Returns result to be used elsewhere in the app
        public override string ToString()
        {

            StringBuilder textSummaryBuilder = new StringBuilder();

            textSummaryBuilder.Append(base.ToString());


            textSummaryBuilder.Append($"\n\n***** START {this.GetType().ToString()} CHILD ToString() VALUES ***** \n\n");

            textSummaryBuilder.Append($"{this.GetType().ToString()} landing gear: {blnLandingGear} \n");
            textSummaryBuilder.Append($"{this.GetType().ToString()} number of engines: {NumOfEngines} \n");
            textSummaryBuilder.Append($"{this.GetType().ToString()} wingspan: {wingSpan} \n");

            return textSummaryBuilder.ToString();

        }
        #endregion
    }
}
