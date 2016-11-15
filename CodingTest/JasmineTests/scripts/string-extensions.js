(function () {
    'use strict';

    String.prototype.capitalise = function () {
        return this.charAt(0).toUpperCase() + this.slice(1);
    };

    String.prototype.camelCaseToSpineCase = function () {
        return this
            .replace(/([A-Z])/g, '-$1')
            .toLowerCase()
            .replace(/[ ]/g, '-')
            .replace(/--/g, '-');
    };

    String.prototype.spineCaseToCamelCase = function () {
        var result = this
            .replace('/[  ]/g', ' ')
            .replace(/-/g, ' ')
            .replace(/\w\S*/g, function(stringValue) {
                return stringValue.capitalise();
            })
            .replace(/[ ]/g, '');

        return result.charAt(0).toLowerCase() + result.slice(1);
    };

    String.prototype.format = function () {
        var result = this,
            argumentLength = arguments.length;

        for (var key = 0; key < argumentLength; key++) {
            result = result.replace('{' + key + '}', arguments[key]);
        }

        return result;
    };
})();
