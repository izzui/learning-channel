describe('Facebook services', function () {
    beforeEach(module('izzuiApp'));

    it("gets an app token", inject(function (facebookService) {
        expect(facebookService).not.toBe(null);
        facebookService.getAppToken().then(function(token) {
            console.log(token);
            expect(token.length).toBe(10);
        });
    }));
});