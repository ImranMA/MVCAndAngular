//service
app.factory('DataPost', function ($http, $q) {

    return {
        get: function (url, json) {            
            var mydeffered = $q.defer();
            $http.post(url, json)
            .success(mydeffered.resolve).error(function (data, status, headers, config) {              
                mydeffered.reject(status);
            });
            return mydeffered.promise;
        }
    }
});


