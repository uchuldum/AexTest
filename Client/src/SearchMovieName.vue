<template>
        <div class="md-form mt-0">
            <input placeholder="Введите для поиска" v-model="movieName"  type="text"  class="form-control">
        </div>
</template>

<script>
import axios from 'axios'

export default {
    data(){
        return{
            movieName: '',
            movies: []
        }
    },
    methods:{
        FindMovie(name){
            console.log(name);
            axios.get('https://localhost:44321/api/movies/getbymoviename?name='+name)
                    .then(response => {
                        this.movies = response.data,
                        this.$emit('GetMoviesByName', this.movies)
                    })
                    .catch(error => {
                        console.log(error)
                    })
        }
    },
    watch:{
        'movieName': function(name){
            this.FindMovie(name.trim());
        }
    },
    
}
</script>


<style scoped>
</style>