angular.module('izzuiApp')
    .controller('topicsController', ['$scope', 'topicsService',
        function ($scope, topicsService) {

            $scope.topics;

            function getTopics() {
                topicsService.getTopics()
                    .success(function (data) {

                        $scope.topics = data;
                    })
                    .error(function (error) {
                    });
            };

            getTopics();
        }]);