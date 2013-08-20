var app = angular.module('izzuiApp', ['ngCookies']);

app.config(function ($httpProvider) {
    delete $httpProvider.defaults.headers.common['X-Requested-With'];
});