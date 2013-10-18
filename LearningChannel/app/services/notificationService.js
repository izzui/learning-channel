angular.module('izzuiApp')
    .service('notificationService', function () {
        var badges = [];
        badges['maqNiv4'] = '<div class="noty noty_message clearfix"><div class="noty-img pull-left"><img class="img-responsive" src="img/badges/maquiagem-nv4.png" /></div><div class="noty-info pull-left top-near"><div class="enriqueta white em1-8"><strong>Congrats!</strong></div><p class="noty_text top-near"></p></div><div class="noty_close"></div></div>';
        badges['maqNiv5'] = '<div class="noty noty_message clearfix"><div class="noty-img pull-left"><img class="img-responsive" src="img/badges/maquiagem-nv5.png" /></div><div class="noty-info pull-left top-near"><div class="enriqueta white em1-8"><strong>Marvelous!</strong></div><p class="noty_text top-near"></p></div><div class="noty_close"></div></div>';

        var notes = [];
        notes['maqNiv4'] = "You've just won the badge <strong>Maquiagem: nível 4</strong>!";
        notes['maqNiv5'] = "You've just won the badge <strong>Maquiagem: nível 5</strong>!";

        this.notify = function (options) {
            noty({
                animation: {
                    open: { height: 'toggle' },
                    close: { height: 'toggle' },
                    easing: 'swing',
                    speed: 500 // opening & closing animation speed
                },
                dismissQueue: true,
                layout: options['layout'] || 'topCenter',
                type: options['type'] || 'information',
                text: notes[options['badge'] || 'maqNiv4'],
                template: badges[options['badge'] || 'maqNiv4']
            });
            
        };
    });


