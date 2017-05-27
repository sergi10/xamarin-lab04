﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCLProject
{

    public class AppValidator
    {
        IDialog Dialog;
        public string EMail { get; set; }
        public string Password { get; set; }
        public string Device { get; set; }

        public AppValidator(IDialog plataformDialog)
        {
            Dialog = plataformDialog;
        }

        public async void Validate()
        {
            string Result;
            var ServiceClient = new SALLab04.ServiceClient();
            var SvcResult = await ServiceClient.ValidateAsync(EMail, Password, Device);

            Result = $"{ SvcResult.Status}\n{ SvcResult.Fullname}\n{ SvcResult.Token}";

            Dialog.Show(Result);
        }
    }
}
