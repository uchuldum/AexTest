<template>
   <div class="mybody">
      <my-header></my-header>
      <my-main></my-main>
    </div>
</template>

<script>
import myHeader from './header.vue';
import myMain from './main.vue'
export default {
  components: {
    myHeader,
    myMain,
  },
  data () {
    return {
     
    }
  }
}
</script>

<style>
  html, body, .mybody, header, #intro{
    height: 100%; /*TODO*/
  }
  #intro{
    background: url(../src/img/beautiful-bright-hand.jpg) no-repeat  center center fixed;
    --webkit-background-size: cover;
    background-size: cover;
  }
  .top-nav-collapse{
    background-color: #24355C;
  }
  

</style>
