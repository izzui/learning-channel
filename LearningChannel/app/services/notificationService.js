angular.module('izzuiApp')
    .service('notificationService', function () {
        var badges = [];
        badges['aggregator'] = '<div class="noty_message clearfix"><div class="noty-img pull-left"><img class="img-100" src="img/badges/aggregator.png" /></div><div class="noty-info pull-left top-near"><div class="white em1-8"><strong>Congratulations!</strong></div><p class="noty_text top-near"></p></div><div class="noty_close"></div></div>';
        badges['interested'] = '<div class="noty_message clearfix"><div class="noty-img pull-left"><img class="img-100" src="img/badges/interested.png" /></div><div class="noty-info pull-left top-near"><div class="white em1-8"><strong>Wonderful!</strong></div><p class="noty_text top-near"></p></div><div class="noty_close"></div></div>';

        var notes = [];
        notes['aggregator'] = 'You just won the <strong>Aggregator</strong> trophy!';
        notes['interested'] = 'You just won the <strong>Interested</strong> trophy!';

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


