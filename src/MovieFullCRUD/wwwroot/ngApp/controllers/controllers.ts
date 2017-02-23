namespace MovieFullCRUD.Controllers {

    export class HomeController {
        public message = 'Hello from Home Page'
        public movies;

        constructor(private $http: ng.IHttpService, private $state: ng.ui.IStateService) {
            this.$http.get('/api/movies').then((response => {
                this.movies = response.data;
            }))
        }

        public deleteMovie(id: number) {
            this.$http.delete('/api/movies/' + id).then((response) => {
                this.$state.reload();
            })
        }
    }

    export class DetailsController {
        public message = 'Hello from Detail Page'
        public movie;

        constructor(private $http: ng.IHttpService, private $stateParams: ng.ui.IStateParamsService) {
            let mId = this.$stateParams['id'];

            this.$http.get('/api/movies/' + mId).then((response) => {
                this.movie = response.data;
            })
        }
    }

    export class AddMovieController {
        public message = 'Hello from Add Movie Page';
        public movie;

        constructor(private $http: ng.IHttpService, private $state: ng.ui.IStateService) {

        }

        public addMovie() {
            this.$http.post('/api/movies', this.movie).then((response) => {
                this.$state.go('home');
            })
        }
    }

    export class EditMovieController {
        public message = 'Hello from Edit Movie Page';
        public movie;

        constructor(private $http: ng.IHttpService, private $state: ng.ui.IStateService, private $stateParams: ng.ui.IStateParamsService) {
            let mId = this.$stateParams['id'];

            this.$http.get('/api/movies/' + mId).then((response) => {
                this.movie = response.data;
            })
        }

        public editMovie() {
            this.$http.post('/api/movies', this.movie).then((response) => {
                this.$state.go('home');
            })
        }
    }


    export class SecretController {
        public secrets;

        constructor($http: ng.IHttpService) {
            $http.get('/api/secrets').then((results) => {
                this.secrets = results.data;
            });
        }
    }


    export class AboutController {
        public message = 'Hello from the about page!';
    }

}
