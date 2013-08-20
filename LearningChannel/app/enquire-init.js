function initEnquire() {
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
        },

        unmatch: function () {
            $('#lb-icon').removeClass('icon-4x');
            $('body').removeClass('md');
        }
    });

    //medium and larger devices
    enquire.register("all and (min-width: 768px)", {
        deferSetup: true,
        match: function () {
            $('#col-navbar-form').addClass('col-sm-push-2');
            $('#col-btn-topics').addClass('col-sm-pull-5');
        },

        unmatch: function () {
            $('#col-navbar-form').removeClass('col-sm-push-2');
            $('#col-btn-topics').removeClass('col-sm-pull-5');
        }
    });
}