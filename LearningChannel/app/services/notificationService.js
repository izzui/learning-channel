angular.module('izzuiApp')
    .service('notificationService', function () {
        var badges = [];
        badges['aggregator'] = '<div class="noty noty_message clearfix"><div class="noty-img pull-left"><img class="img-responsive" src="img/badges/aggregator.png" /></div><div class="noty-info pull-left top-near"><div class="enriqueta white em1-8"><strong>Congrats!</strong></div><p class="noty_text top-near"></p></div><div class="noty_close"></div></div>';
        badges['interested'] = '<div class="noty noty_message clearfix"><div class="noty-img pull-left"><img class="img-responsive" src="img/badges/interested.png" /></div><div class="noty-info pull-left top-near"><div class="enriqueta white em1-8"><strong>Marvelous!</strong></div><p class="noty_text top-near"></p></div><div class="noty_close"></div></div>';

        var notes = [];
        notes['aggregator']		= "You've just won the badge <strong>Agreggator</strong>!";
        notes['interested']		= "You've just won the badge <strong>Interested</strong>!";

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


