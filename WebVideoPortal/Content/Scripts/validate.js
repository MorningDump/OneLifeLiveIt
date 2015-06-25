$(function () {
    var settings = $.data($('.validatable-form')[0], 'validator').settings;
    var oldErrorFunction = settings.errorPlacement;
    var oldSucessFunction = settings.success;
    settings.errorPlacement = function (error, inputElement) {
        $(inputElement).closest('.form-group').addClass('has-error');
        oldErrorFunction(error, inputElement);
    }
    settings.success = function (error, inputElement) {
        $(inputElement).closest('.form-group').removeClass('has-error');
        oldSucessFunction(error, inputElement);
    }
});