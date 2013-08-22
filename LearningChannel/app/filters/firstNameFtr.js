angular.module('izzuiApp').filter("firstNameFtr", function () {
    return function (value) {
        return value.split(' ')[0];
    };
});