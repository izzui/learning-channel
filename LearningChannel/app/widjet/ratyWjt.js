angular.widget('jqp:raty', function (tpl) {
    var config = {}, val;
    angular.forEach(['start', 'number'], function (name) {
        if (val = tpl.attr(name)) config[name] = parseInt(val);
    });

    return function (elm) {
        elm.raty(config);
    };
});