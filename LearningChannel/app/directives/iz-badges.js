izzuiApp.directive('izBadges', function() {
    return {
        scope: true,
        restrict: 'E',
        replace: true,
        templateUrl: '/app/directives/iz-badges.html',
        link: function (scope, element, attrs) {
            var badges = {
                aggregator: {
                    src: 'market-share-master.png',
                    name: 'Market Share Master'
                },
                interested: {
                    src: 'money-investitor.png',
                    name: 'Money Investitor'
                },
                targetMaster: {
                    src: 'money-saver.png',
                    name: 'Money Saver'
                },
                aggregator2: {
                	src: 'online-broker.png',
                	name: 'Online Broker'
                },
                interested2: {
                	src: 'sales-master.png',
                	name: 'Sales Master'
                }
            }

            var badgesBag = _.shuffle(_.values(badges));
            scope.badges = _.first(badgesBag, 5);
        }
    }
});