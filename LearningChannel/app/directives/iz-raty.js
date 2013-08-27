izzuiApp.directive("izRaty", function () {
    var path = { big: 'img/raty/big/', default: 'img/raty/default/' };
    return {
        restrict: 'E',
        scope: {
            score: '='
        },
        link: function (scope, elem, attrs, $parse) {
            scope.$watch('score', function (value) {
                $(elem).raty(
                {
                    score: scope.score,
                    number: attrs.number,
                    path: path[attrs.size] || path["default"],
                    readOnly: !attrs.readonly && true,
                    click: function (score, evt) {
                        scope.score = score;
                        scope.$apply();
                    }
                });
            });
        }
    }
});