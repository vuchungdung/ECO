(function (app) {
    app.controller('homeController', homeController);

    homeController.$inject = ['$scope', 'ajaxService'];

    function homeController($scope, ajaxService) {

        $scope.getAllNew = function() {
            ajaxService.get('/Product/GetMultiProduct', null, function (res) {
                $scope.listProducts = res.data;
                console.log($scope.listProducts);
            }, function (err) {
                console.log(err);
            });
        }

        $scope.getAllNew();

        
    }
})(angular.module('erp'));
