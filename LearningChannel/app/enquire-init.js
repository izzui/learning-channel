function initEnquire() {

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
            $('#lb-icon').addClass('icon-4x');
            $('#my-badges-icon').addClass('icon-4x');
        },

        unmatch: function () {
            $('body').removeClass('md');
            $('#lb-icon').removeClass('icon-4x');
            $('#my-badges-icon').removeClass('icon-4x');
        }
    });

    //medium and larger devices
    enquire.register("all and (min-width: 768px)", {
        deferSetup: true,
        match: function () {
            $('#col-navbar-form').addClass('col-sm-push-2');
            $('#col-btn-topics').addClass('col-sm-pull-4');
        },

        unmatch: function () {
            $('#col-navbar-form').removeClass('col-sm-push-2');
            $('#col-btn-topics').removeClass('col-sm-pull-4');
        }
    });
}