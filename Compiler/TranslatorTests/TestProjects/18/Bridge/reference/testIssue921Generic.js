﻿(function (globals) {
    "use strict";

    Bridge.define('TestIssue921Generic.Issue921Generic$1', function (T) { return {
        lambaLiftingGeneric: function () {
            return Bridge.Linq.Enumerable.from([1]).select(function (value) {
                return Bridge.getDefaultValue(T);
            });
        }
    }; });
    
    
    
    Bridge.init();
})(this);
