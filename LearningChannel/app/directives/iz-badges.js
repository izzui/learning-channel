izzuiApp.directive('izBadges', function() {
    return {
        scope: true,
        restrict: 'E',
        replace: true,
        templateUrl: '/app/directives/iz-badges.html',
        link: function (scope, element, attrs) {
            var badges = {
                aggregator: {
                    src: 'aggregator.png',
                    name: 'Aggregator'
                },
                interested: {
                    src: 'interested.png',
                    name: 'Interested'
                },
                targetMaster: {
                    src: 'target-master.png',
                    name: 'Expert'
                }
            }

            var badgesBag = _.shuffle(_.values(badges));
            scope.badges = _.first(badgesBag, 2);
        }
    }
});