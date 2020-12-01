(function (app) {
    app.controller('navbarController', navbarController);

    navbarController.$inject = ['$scope', 'ajaxService'];

    function navbarController($scope, ajaxService) {

        $scope.getNavbar = function () {
            ajaxService.get('/ProductCategory/GetAllCategory', null, function (res) {
                $scope.listCategories = res.data;
                console.log($scope.listCategories);
            }, function (err) {
                console.log(err);
            });
        }

        $scope.getNavbar();

        $scope.getProductByCategory = function () {
            ajaxService.get('/Product/GetMultiProductByCategory', null, function (res) {
                $scope.listProductByCategories = res.data;
                console.log($scope.listProducts);
            }, function (err) {
                console.log(err);
            });
        }
    }
})(angular.module('erp'));