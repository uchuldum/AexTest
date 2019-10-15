<template>
   <div class="mybody">
      <my-header></my-header>
      <my-main></my-main>
      <my-footer></my-footer>
    </div>
</template>

<script>
import myHeader from './header.vue';
import myMain from './main.vue'
import myFooter from './footer.vue'
export default {
  components: {
    myHeader,
    myMain,
    myFooter
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
    background: url(../src/img/main.jpg) no-repeat  center center fixed;
    --webkit-background-size: cover;
    background-size: cover;
  }
  .top-nav-collapse{
    background-color: #24355C;
  }
  

</style>
