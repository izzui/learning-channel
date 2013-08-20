describe('Facebook services', function () {
    beforeEach(module('izzuiApp'));

    beforeEach(module(function ($provide) {
        $provide.provider('$cookies', function () {
            this.$get = function() {
                return {};
            };
        });
    }));

    it("gets an app token", inject(function (facebookService) {
        expect(facebookService).not.toBe(null);
        var token = facebookService.getAppToken();
        console.log(token);
        expect(token.length).toBe(16);
    }));
});