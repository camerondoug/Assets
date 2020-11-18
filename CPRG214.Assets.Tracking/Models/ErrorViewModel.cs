using System;

namespace CPRG214.Assets.Tracking.Models
{/*
    * CPRG 214 Assignment 2
    * Purpose: This is the code for the errors view model
    * Author: Doug Cameron and Ini Akpan
    * Date: Aug, 2020
    */
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
