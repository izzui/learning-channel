angular.module('izzuiApp')
    .controller('groupsCtrl', function ($scope, facebookService) {
        $scope.save = function () {

            facebookService.createGroup($scope.groupName, 'descricao de grupo', 'OPEN').success(function (data) {
                getGroups();
            })
            .error(function (error) {
               
            });
        }
        $scope.groupName;
        $scope.groups;

        function getGroups() {
            facebookService.getGroups().success(function (data) {
                $scope.groups = data.data;
            });
        }
        getGroups();
    });