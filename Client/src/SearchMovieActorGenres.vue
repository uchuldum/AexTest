<template>
    <div>
        <div class="md-form">
            <div class="row">
                <div class="col-sm-8">
                    <select @click="movieName = ''" @change="SelectActor($event)" >
                            <option value="" id="0" selected>Выберите из списка актера</option>
                            <option
                                v-for = "actor in actors" :id="actor.id" :key="actor.id"
                            >
                            {{actor.firstName}} {{actor.middleName}}
                            </option>
                    </select>
                </div>
                <div class="col-sm-6 mt-2">
                    <select @change="SelectGenre($event)" >
                            <option value="" selected disabled>Выберите из списка жанр</option>
                            <option
                                v-for = "genre in genres" :id="genre.id" :key="genre.id"
                            >
                            {{genre.name}}
                            </option>
                    </select>
                    <ul class="list-group list-group-horizontal">
                        <div
                         v-for = "selectedGenre in selectedGenres" :key="selectedGenre.id"
                         class="list-group-item ml-2">
                        {{selectedGenre.name}}
                        <a class="delete" :id = selectedGenre.id @click="deleteGenre($event)">X</a>
                        </div>
                    </ul>
                </div>
            </div>
            
        </div>
    </div>
</template>

<script>
import axios from 'axios'

export default {
    data(){
        return{
            movies: [],
            actors: [],
            genres: [],
            selectedGenres: [],
            query: '',
            actorquery: '',
            genresquery: ''
        }
    },
    created(){
        axios.get('https://localhost:44321/api/genres')
                    .then(response => {
                        this.genres = response.data;
                    })
                    .catch(error => {
                        console.log(error)
                    });
        axios.get('https://localhost:44321/api/actors')
                    .then(response => {
                        this.actors = response.data;
                    })
                    .catch(error => {
                        console.log(error)
                    })
    },
    methods:{
        FindMovie(query){
            console.log(query);
            axios.get('https://localhost:44321/api/movies/getbycondition?'+query)
                    .then(response => {
                        this.movies = response.data;
                        this.$emit('GetMoviesByGenreActor', this.movies)
                    })
                    .catch(error => {
                        console.log(error)
                    })
        },
        SelectActor(e){
            this.actorquery = '';
            this.actorquery = 'actor='+e.target.options[e.target.options.selectedIndex].id;
            if(e.target.options[e.target.options.selectedIndex].id == 0) this.actorquery = '';
            this.BuildQuery();
        },
        deleteGenre(e){
            for(let i = 0; i < this.selectedGenres.length; i++){
                if(this.selectedGenres[i].id == e.target.id){
                    this.selectedGenres.splice(i,1);
                    break;
                }
            }
            this.BuildGenreQuery();
        },
        BuildGenreQuery(){
            this.genresquery = '';
            for(let i = 0; i < this.selectedGenres.length; i++)
            {
                this.genresquery += 'genre='+this.selectedGenres[i].id+'&';
            }
            this.BuildQuery();
        },
        BuildQuery(){
            this.query = this.genresquery+this.actorquery;
            this.FindMovie(this.query);
        },
        SelectGenre(e){
            let selectedId = e.target.options[e.target.options.selectedIndex].id;
            e.target.value = '';
            let exist = false;
            
            for(let i = 0; i < this.selectedGenres.length; i++)
            {
                if(this.selectedGenres[i].id == selectedId){
                    exist = true;
                    break;
                }
            }
            if(exist == false){
                this.selectedGenres.push(Object.assign({},this.getGenreById(selectedId)));
            }
            this.BuildGenreQuery();
        },
        getGenreById(id){  
            var selectedGenre = {name : '', id : 0};
            for(let i = 0; i < this.genres.length; i++){
                if(this.genres[i].id == id)
                {
                    selectedGenre.name = this.genres[i].name;
                    selectedGenre.id = id;
                    return selectedGenre;
                }
            }
        },
    },
    watch:{
        'movieName': function(name){
            this.FindMovie(name.trim());
        }
    },
    
}
</script>


<style scoped>
    .list-group-item{
        align-content: center;
        padding-top: 0;
        padding-bottom: 0;
        padding-left: 0;
        margin-top: 5px;
        margin-bottom: 0;
    }
    .delete{
        position: absolute;
        margin-top: 0;
        margin-left: 5px;
    }

    .delete:hover{
        background-color: rgb(87, 73, 69);
        transition: all 0.5s ease-in;
    }
    li {
    list-style-type: none; 
    }
    ul {
    margin-left: 2px; /* Отступ слева в браузере IE и Opera */
    padding-left: 2px; /* Отступ слева в браузере Firefox, Safari, Chrome */
   }
</style>