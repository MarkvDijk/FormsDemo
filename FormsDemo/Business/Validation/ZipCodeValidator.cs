using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Forms.Core.Models;
using EPiServer.Forms.Implementation.Validation;

namespace FormsDemo.Business.Validation
{
    public class ZipCodeValidator : RegularExpressionValidatorBase
    {
        public override IValidationModel Model
        {
            get
            {
                if (_model == null)
                {
                    string str = "^[1-9][0-9]{3}\\s?[a-zA-Z]{2}$"; 
                    _model = GetRegularExpressionValidationModel(str, str);
                }
                return _model;
            }
        }
    }
}