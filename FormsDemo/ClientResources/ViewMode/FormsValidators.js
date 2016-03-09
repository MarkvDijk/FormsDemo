/// begin main entry execution
(function ($) {
    if (typeof (epi) == 'undefined' || typeof (epi.EPiServer) == 'undefined' || typeof (epi.EPiServer.Forms) == 'undefined') {
        console.error('Forms is not initialized correctly');
        return;
    }
    if (typeof ($) == 'undefined') {
        console.error('Forms cannot work without jQuery');
        return;
    }

    var _utilsSvc = epi.EPiServer.Forms.Utils;

    /// add buildin implementation of validators
    /// ========================================
    var customValidators = {
        Validators: {
            "FormsDemo.Business.Validation.ZipCodeValidator": _utilsSvc.validateRegularExpressionValidator
        }
    };

    $.extend(true, epi.EPiServer.Forms, customValidators);

})($$epiforms || $);  // use the Forms's jQuery before using site's jQuery
