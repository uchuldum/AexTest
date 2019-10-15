<template>
    <div class="list-group">
        <a v-for="movie in movies" :key="movie.Id"
        href="#!" class="list-group-item list-group-item-action flex-column align-items-start">
            <div class="d-flex w-100 justify-content-between">
                <h5 class="mb-2 h5">{{movie.name}}</h5>
                <small>{{movie.realeaseYear.substring(-4, 4)}} г.</small>
            </div>
            <p class="mb-2">
                {{movie.description}} 
            </p>
        </a>
    </div>
</template>

<script>

export default {
    props:{
        movies: [] 
    },
    data(){
        return{
        }
    }
}
</script>

<style scoped>
    .list-group, a{
        width: 100%;
    }
    p{
        width: 80%;
    }
</style>