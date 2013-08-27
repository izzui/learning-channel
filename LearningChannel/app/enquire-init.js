﻿function initEnquire() {

	//tablets(landscape), facebook frame in 1024x768px
	enquire.register("all and (max-width: 768px)", {
		deferSetup: true,
		match: function () {
			$('body').addClass('xs');
			$('#btn-topics').addClass('btn-block');
			$('#btn-user').addClass('btn-block');
		},

		unmatch: function () {
			$('body').removeClass('xs');
			$('#btn-topics').removeClass('btn-block');
			$('#btn-user').removeClass('btn-block');
		}
	});

	//tablets(landscape), facebook frame in 1024x768px
    enquire.register("all and (max-width: 1024px)", {
        deferSetup: true,
        match: function () {
            $('body').addClass('sm');
        },

        unmatch: function () {
            $('body').removeClass('sm');
        }
    });

    //medium devices
    enquire.register("all and (min-width: 1025px)", {
        deferSetup: true,
        match: function () {
            $('body').removeClass('sm');
            $('body').addClass('md');
        },

        unmatch: function () {
            $('body').removeClass('md');
        }
    });

    //medium and larger devices
    enquire.register("all and (min-width: 768px)", {
        deferSetup: true,
        match: function () {

        },

        unmatch: function () {

        }
    });
}