using MyCloudProject.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyExperiment
{
    public class ExerimentRequestMessage : IExerimentRequestMessage
    {
        public string ExperimentId { get; set; }
        public string InputFile { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}


/*
 
{
    "ExperimentId" : "exp-id-1234",
    "InputFile" : "null",
    "Name" : "ML 21/22-28",
    Description : "Improve Unit Test(Temporal Memory)"
}
 
 */ 