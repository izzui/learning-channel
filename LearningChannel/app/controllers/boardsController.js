angular.module('izzuiApp')
    .controller('boardsController', ['$scope', 'boardsService',
        function ($scope, boardsService) {
            console.log(1);
            $scope.boardIsLastMonth = true;
            $scope.board;
            $scope.boardLastMonth = function (param) {
                $scope.boardIsLastMonth = param;
                getBoard();//Model do getBoard
            };

            function getBoard() {
                // var userId = $cookies.iz_izzui_userId;
                boardsService.getBoard($scope.boardIsLastMonth)
                    .success(function (board) {
                        $scope.board = board;
                    })
                    .error(function (error) {
                    });
            };
            getBoard();
        }]);

