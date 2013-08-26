angular.module('izzuiApp')
    .controller('friendsCtrl', function ($scope, facebookService) {
        facebookService.getFriends(24)
            .success(function (data) {
                $scope.friends = data.data;
                $scope.countFriends = $scope.friends.length;
            })
            .error(function (error) {
            });
    });
