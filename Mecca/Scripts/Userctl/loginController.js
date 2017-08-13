app.controller("SignInCtrl", function ($scope, DataPost, $rootScope, $location) {

    
    var _signIn = function (user) {
        DataPost.get("/User/SignIn", user).then(function (data) {
            user.authenticated = true;
            $rootScope.user = user;
            $scope.CurrentUser = user.UserName;
            window.location.href = '/Home/Index';
        }

        , function (errStatus) {
            user.authenticated = false;
            $scope.responseError = true;

            if (errStatus == 403)
                $scope.responseError = "UserName or Password Not Correct !";
            else
                $scope.responseError = "Some problem has occured. Please Try again Later !";
        });
    }
    var _signOut = function (user) {
        DataPost.get("/User/SignOut", user).then(function (data) {
            if (user == null || user == "undefined")
                window.location.href = '/Home/Login';

        });
    }


    // $scope
    $scope.signIn = function () {
        _signIn($scope.user);
    }
    $scope.signOut = function () {
        _signOut($scope.user);
    }



    $scope.getClass = function (path) {
        if (window.location.href.split("/").pop() == path) {
            return 'active';
        } else {
            return '';
        }
    }
});



