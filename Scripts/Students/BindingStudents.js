//define angular module that is used in ng-app for UI
var app = angular.module('studentApp', []);

//create a javascript function that will act as a conroller using $scope & $http for api calls
var studentController = function ($scope, $http) {
    $scope.Student = {
        Id: 0,
        FirstName: '',
        LastName: '',
        DOB: null,
        GPA: 0.0
    };

    $scope.Students = [];

    $http({
        method: 'GET',
        url: 'api/Student/Get',
    }).then(function (response) {
        $scope.Students = response.data; //success
    },function () {
        alert('Something went wrong'); //error
    });

    //add new student details
    $scope.saveStudent = function (isValid) {
        if (!isValid)
            return alert('Please Enter All the Values !!');

        $http.post('api/Student/Post', $scope.Student)
            .then(function (response) {
                $scope.Students = response.data;
                $scope.clear();
            });
    };

    //reset student details
    $scope.clear = function () {
        $scope.Student.Id = 0;
        $scope.Student.FirstName = '';
        $scope.Student.LastName = '';
        $scope.Student.DOB = null;
        $scope.Student.GPA = 0.0;

        $scope.studentForm.$setPristine();
    };
};

//define angular controller by pointing it to the above function
app.controller('studentController', studentController);
