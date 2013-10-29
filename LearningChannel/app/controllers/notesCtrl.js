//VideoPlayer
angular.module('izzuiApp')
	.controller('notesCtrl', ['$scope',
		function ($scope) {

			$scope.notes = ['Visitar lancome.com.br/maquiagem/tutoriais/ para pegar mais informações depois.',
				'Discutir com a Helena sobre 2:34. Ponto importante do vídeo.' ];
			
			$scope.note = '';

			$scope.remove = function (index) {
				$scope.notes.splice(index,1);
			};

			$scope.add = function (note) {
				$scope.notes.push(note);
				console.log($scope.notes);
				$scope.note = '';
			};
		}])