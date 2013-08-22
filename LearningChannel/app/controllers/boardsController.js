angular.module('izzuiApp')
    .controller('boardsController', function ($scope, boardsService) {
            $scope.boardIsLastMonth = true;
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
        });

