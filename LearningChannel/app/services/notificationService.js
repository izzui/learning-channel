angular.module('izzuiApp')
    .service('notificationService', function () {
        var badges = [];
        badges['money-saver']	= '<div class="noty noty_message clearfix"><div class="noty-img pull-left"><img class="img-responsive" src="img/badges/money-saver.png" /></div><div class="noty-info pull-left top-near"><div class="enriqueta white em1-8"><strong>Congrats!</strong></div><p class="noty_text top-near"></p></div><div class="noty_close"></div></div>';
        badges['online-broker'] = '<div class="noty noty_message clearfix"><div class="noty-img pull-left"><img class="img-responsive" src="img/badges/online-broker.png" /></div><div class="noty-info pull-left top-near"><div class="enriqueta white em1-8"><strong>Marvelous!</strong></div><p class="noty_text top-near"></p></div><div class="noty_close"></div></div>';

        var notes = [];
        notes['money-saver']		= "You've just won the badge <strong>Money Saver</strong>!";
        notes['online-broker']		= "You've just won the badge <strong>Online Broker</strong>!";

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
                text: notes[options['badge'] || 'interested'],
                template: badges[options['badge'] || 'interested']
            });
            
        };
    });


