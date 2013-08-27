izzuiApp.directive("izRaty", function () {
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
                    path: 'img/raty/' + (attrs.size || 'default'),
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