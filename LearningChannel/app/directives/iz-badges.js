izzuiApp.directive('izBadges', function() {
    return {
        scope: true,
        restrict: 'E',
        replace: true,
        templateUrl: '/app/directives/iz-badges.html',
        link: function (scope, element, attrs) {
            var badges = {
                maqNiv1: {
                	src: 'maquiagem-nv1.png',
                    name: 'Maquiagem: nível 1'
                },
                maqNiv2: {
                	src: 'maquiagem-nv2.png',
                	name: 'Maquiagem: nível 2'
                },
                maqNiv3: {
                	src: 'maquiagem-nv3.png',
                	name: 'Maquiagem: nível 3'
                },
                maqNiv4: {
                	src: 'maquiagem-nv4.png',
                	name: 'Maquiagem: nível 4'
                },
                maqNiv5: {
                	src: 'maquiagem-nv5.png',
                	name: 'Maquiagem: nível 5'
                }
            }

            var badgesBag = _.shuffle(_.values(badges));
            scope.badges = _.first(badgesBag, 5);
        }
    }
});