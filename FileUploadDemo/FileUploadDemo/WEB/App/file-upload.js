/// <reference path="../../scripts/angular.js" />

angular.module('fupApp', [])
    .directive('ngFiles', ['$parse', function ($parse) {
    function fn_link(scope, element, attrs) {
        var onChange = $parse(attrs.ngFiles);

        element.on('change', function (event) {
            onChange(scope, { $files: event.target.files });
        })
    }

    return {
        link: fn_link
    }
    
}]).controller('fupController', function ($scope, $http) {
        var formdata = new FormData();

        $scope.getTheFiles = function ($files) {
            $scope.imagesrc = [];

            for (var i = 0; i < $files.length; i++) {
                var reader = new FileReader();
                reader.fileName = $files[i].name;
                reader.onload = function (event) {
                    var image = {};
                    image.Name = event.target.fileName;
                    image.Size = (event.total / 1024).toFixed(2);
                    image.src = event.target.result;
                    $scope.imagesrc.push(image);
                    $scope.$apply();
                }
                reader.readAsDataURL($files[i]);
            }

            angular.forEach($files, function (value, key) {
                formdata.append(key, value);
            })
        }

    $scope.uploadfiles = function () {
        var request = {
            method: 'POST',
            url: '/api/FileUpload',
            data: formdata,
            headers: {
                'Content-Type': undefined
            }
        };

        $http(request).success(function (d) {
            alert(d);
            $scope.reset();
        }).error(function () {
            alert("Error!!!");
            $scope.reset();
        })
    }
      
    $scope.reset = function () {
        angular.forEach(
            angular.element("input [type = 'file']"),
            function (inputElem) {
                angular.element(inputElem).val(null);
            }
        );
        $scope.imagesrc = [];
        formdata = new FormData();

    }
})