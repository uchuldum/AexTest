<template>
    <main class="mt-5">
        <div class="container">
            <section id="best-features" class="text-center">
                <h2 class="mb-3 font-weight-bold">Поиск фильмов</h2>
                <div class="row d-flex justify-content-left mb-4">
                    <div class="col-md-4 pl-5 ">
                        <div class="row">
                            <h6 class="font-weight-bold">
                                Поиск по названию
                                <i class="fas fa-caret-down" id="common" @click="ShowSearch($event)"></i>
                            </h6>
                        </div>
                        <div class="container" v-if="isVisibleByName">
                            <search-movie-name @GetMoviesByName="SetMovies"></search-movie-name>
                        </div>
                        <div class="row">
                            <h6 class="font-weight-bold">
                                Расширенный поиск
                                <i class="fas fa-caret-down"  id="extended" @click="ShowSearch($event)"></i>
                            </h6>
                        </div>
                        <div class="container" v-if="isVisibleExtended">
                            <search-movie-genre-actor @GetMoviesByGenreActor="SetMovies"></search-movie-genre-actor>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <movie-list :movies="movies"></movie-list>
                </div>
            </section>

            <hr class="my-5">
        </div>
    </main>
</template>

<script>
import axios from 'axios'
import SearchMovieName from './SearchMovieName.vue'
import SearchMovieGenreActor from './SearchMovieActorGenres.vue'
import MovieList from './MovieList.vue'
export default {
    data(){
        return{
            movies: [],
            isVisibleByName: true,
            isVisibleExtended: false,
        }
    },
    components:{
        SearchMovieName,
        SearchMovieGenreActor,
        MovieList,
    },
    created(){
        axios.get('https://localhost:44321/api/movies/get')
                    .then(response => {
                        this.movies = response.data;
                        console.log(this.movies)
                    })
                    .catch(error => {
                        console.log(error)
                    })
    },
    methods: {
        SetMovies(value){
            this.movies = value;
            console.log(this.movies);
        },
        ShowSearch(e){
            if(e.target.id == "common"){
                this.isVisibleByName = !this.isVisibleByName;
                this.isVisibleExtended = false;
                console.log(this.isVisibleByName);
            }
            else if(e.target.id == "extended"){
                this.isVisibleExtended = !this.isVisibleExtended;
                this.isVisibleByName = false;
            }
        }

    }
}
</script>

<style scoped>
i:hover{
    cursor: pointer;
}
.item-responsive {
  position: relative; /* относительное позиционирование */
}
.item-responsive:before {
  display: block; /* отображать элемент как блок */
  content: ""; /* содержимое псевдоэлемента */
  width: 100%; /* ширина элемента */
}
.item-16by9 {
  padding-top: 150%; /* (9:16)*100% */
}
.item-responsive>.content {
  position: absolute; /* абсолютное положение элемент */
  /* положение элемента */
  top: 0;
  left: 0;
  right: 0;
  bottom: 0;
  background-size: cover !important;
}  
</style>