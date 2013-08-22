angular.module('izzuiApp')
    .controller('groupsCtrl', function ($scope, $window, facebookService) {
        $scope.save = function () {
            angular.element('#btnCreateGroup').button('loading');
            facebookService.createGroup($scope.groupName)
            .success(function (data) {
                $window.location.href = "https://www.facebook.com/groups/" + data.id;
            })
            .error(function (error) {
                $window.alert("Opa! Tivemos um problema pra criar o seu grupo agora. Tente mais tarde.");
                angular.element('#modalCreateGroup').modal('hide');
            });
        }

        function getGroups() {
            facebookService.getGroups().success(function (data) {
                $scope.groups = data.data;
                angular.forEach($scope.groups, function (group) {
                    group.members = Math.round(Math.random() * 1000);
                });
            });
        }
        getGroups();
    });