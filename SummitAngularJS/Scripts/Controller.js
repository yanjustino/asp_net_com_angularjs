var todoController = angular.module('todoController', []);


todoController.controller('todoController', ['$scope', 'Todo', function ($scope, Todo) {
    $scope.todos = Todo.query();
    $scope.teste = 'Lista de Tarefas';

    $scope.add = function () {
        todo = new Todo.Todos({Task:'nova'});
        todo.$save();
    };
    
}]);

var PhoneListCtrl = angular.module('PhoneListCtrl', []);

PhoneListCtrl.controller('PhoneListCtrl', function ($scope) {
    $scope.phones = [
      {
          'name': 'Nexus S',
          'snippet': 'Fast just got faster with Nexus S.'
      },
      {
          'name': 'Motorola XOOM™ with Wi-Fi',
          'snippet': 'The Next, Next Generation tablet.'
      },
      {
          'name': 'MOTOROLA XOOM™',
          'snippet': 'The Next, Next Generation tablet.'
      }
    ];
});