angular.module('izzuiApp')
    .controller('friendsController', function ($scope, facebookService) {
        facebookService.getFriends(10)
            .success(function (data) {
                $scope.friends = data.data;
            })
            .error(function (error) {
            });
    });