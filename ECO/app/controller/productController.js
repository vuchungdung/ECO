(function (app) {
    app.controller('productController', productController);

    productController.$inject = ['$scope', 'ajaxService'];

    function productController($scope, ajaxService) {

        $scope.getProductByCategory = function () {
            ajaxService.get('/Product/GetMultiProductByCategory', null, function (res) {
                $scope.listProductByCategories = res.data;
                console.log($scope.listProductByCategories);
            }, function (err) {
                console.log(err);
            });
        }
        $scope.getProductByCategory();
    }
})(angular.module('erp'));