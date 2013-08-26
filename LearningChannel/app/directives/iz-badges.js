izApp.directive('izBages', function() {
    return {
        restrict: 'E',
        replace: true,
        templateUrl: '/app/directives/iz-badges.html',
        link: function (scope, element, attrs) {
            badges = {
                aggregator: {
                    imgsrc: 'aggregator.png',
                    name: 'Agregador'
                },
                interested: {
                    imgsrc: 'interested.png',
                    name: 'Interessado'
                },
                aggregator: {
                    imgsrc: 'aggregator.png',
                    name: 'Agregador'
                }
            }
        }
    }
});