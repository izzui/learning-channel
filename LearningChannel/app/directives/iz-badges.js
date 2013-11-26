izzuiApp.directive('izBadges', function() {
    return {
        scope: true,
        restrict: 'E',
        replace: true,
        templateUrl: '/app/directives/iz-badges.html',
        link: function (scope, element, attrs) {
            var badges = {
                maqNiv1: {
                	src: 'badge-nv1.png',
                    name: 'Cabeleireiro: nível 1'
                },
                maqNiv2: {
                	src: 'badge-nv2.png',
                	name: 'Cabeleireiro: nível 2'
                },
                maqNiv3: {
                	src: 'badge-nv3.png',
                	name: 'Cabeleireiro: nível 3'
                },
                maqNiv4: {
                	src: 'badge-nv4.png',
                	name: 'Cabeleireiro: nível 4'
                },
                maqNiv5: {
                	src: 'badge-nv5.png',
                	name: 'Cabeleireiro: nível 5'
                }
            }

            var badgesBag = _.shuffle(_.values(badges));
            scope.badges = _.first(badgesBag, 5);
        }
    }
});