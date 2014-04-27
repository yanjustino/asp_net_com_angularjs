var todoServices = angular.module('todoServices', ['ngResource']);

todoServices.factory('Todo', ['$resource',
  function ($resource) {
      var Todos = $resource('/api/todo', {}, {
          query: { method: 'GET', params: {}, isArray: true },
      });

      return Todos;
  }]);
