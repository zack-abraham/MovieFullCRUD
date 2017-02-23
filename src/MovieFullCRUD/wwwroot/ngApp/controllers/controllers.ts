namespace MovieFullCRUD.Controllers {

    export class HomeController {
        public message = 'Hello from Home Page'
        public movies;

        constructor(private $http: ng.IHttpService) {
            this.$http.get('/api/movies').then((response => {
                this.movies = response.data;
            }))
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
