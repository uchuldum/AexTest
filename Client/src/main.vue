<template>
    <main class="mt-5">
        <div class="container">
            <section id="best-features" class="text-center">
                <h2 class="mb-5 font-weight-bold">Best Features</h2>
                <div class="row d-flex justify-content-center mb-4">
                    <div class="col-md-8">
                        <p class="grey-text">
                            Lorem ipsum, dolor sit amet consectetur adipisicing elit.
                            Alias voluptatibus sint, ipsa enim vero impedit magni dolor nostrum animi numquam!
                        </p>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-4 mb-5">
                        <i class="fa fa-archive fa-4x grey-text"></i>
                        <h4 class="my-4 font-weight-bold">Archive</h4>
                        <p class="grey-text">Lorem ipsum dolor sit amet consectetur adipisicing elit. Aut voluptatibus inventore mollitia. Dicta, magnam officiis.</p>
                    </div>
                    <div class="col-md-4 mb-5">
                        <i class="fab fa-amazon fa-4x grey-text"></i>
                        <h4 class="my-4 font-weight-bold">Archive</h4>
                        <p class="grey-text">Lorem ipsum dolor sit amet consectetur adipisicing elit. Aut voluptatibus inventore mollitia. Dicta, magnam officiis.</p>
                    </div>
                    <div class="col-md-4 mb-5">
                        <i class="fab fa-bitcoin fa-4x grey-text"></i>
                        <h4 class="my-4 font-weight-bold">Archive</h4>
                        <p class="grey-text">Lorem ipsum dolor sit amet consectetur adipisicing elit. Aut voluptatibus inventore mollitia. Dicta, magnam officiis.</p>
                    </div>
                </div>
            </section>

            <hr class="my-5">

            <section id="examples" class="text-center">
                <h2 class="mb-5 font-weight-bold">Examples</h2>
                <div class="row">
                    <div class="col-lg-4 col-md-12 mb-4">
                        <div class="view overlay zoom">
                            <img src="../src/img/beach-calm-dawn.jpg" alt="" class="img-fluid">
                            <div class="mask flex-center"></div>
                        </div>
                        <h4 class="my-4 font-weight-bold">Heading</h4>
                        <p class="grey-text">Lorem ipsum dolor sit, amet consectetur adipisicing elit. Inventore libero quibusdam modi.</p>
                    </div>
                    <div class="col-lg-4 col-md-6 mb-4">
                        <div class="view overlay ">
                            <img src="../src/img/beach-calm-dawn.jpg" alt="" class="img-fluid">
                            <div class="mask flex-center rgba-red-strong"></div>
                        </div>
                        <h4 class="my-4 font-weight-bold">Heading</h4>
                        <p class="grey-text">Lorem ipsum dolor sit, amet consectetur adipisicing elit. Inventore libero quibusdam modi.</p>
                    </div>
                    <div class="col-lg-4 col-md-6 mb-4">
                        <div class="view overlay hoverable">
                            <img src="../src/img/beach-calm-dawn.jpg" alt="" class="img-fluid">
                            <div class="mask flex-center"></div>
                        </div>
                        <h4 class="my-4 font-weight-bold">Heading</h4>
                        <p class="grey-text">Lorem ipsum dolor sit, amet consectetur adipisicing elit. Inventore libero quibusdam modi.</p>
                    </div>
                </div>
            </section>

            <hr class="my-5">

            <section id="gallery">
                <h2 class="mb-5 font-weight-bold text-center">Gallery</h2>
                <div class="row">
                    <div class="col-md-6 mb-4">
                        <div id="carousel-example-1z" class="carousel slide carousel-fade" data-ride="carousel">
                            <ol class="carousel-indicators">
                                <li data-target="#carousel-example-1z" data-slide-to="0"
                                 class="active"></li>
                                 <li data-target="#carousel-example-1z" data-slide-to="1"
                                 class=""></li>
                                 <li data-target="#carousel-example-1z" data-slide-to="2"
                                 class=""></li>
                            </ol>
                            <div class="carousel-inner z-depth-1-half" role="listbox">
                                <div class="carousel-item active">
                                    <div class="item-responsive item-16by9">
                                        <div class="content" style="background: url(../src/img/beach-calm-dawn.jpg);"></div>
                                    </div>
                                </div>
                                 <div class="carousel-item">
                                    <div class="item-responsive item-16by9">
                                        <div class="content" style="background: url(../src/img/cold-forest-frost.jpg);"></div>
                                    </div>
                                </div>
                                 <div class="carousel-item">
                                    <div class="item-responsive item-16by9">
                                          <div class="content" style="background: url(../src/img/beach-calm-dawn.jpg);"></div>
                                    </div>
                                </div>
                            </div>
                            <a href="#carousel-example-1z" class="carousel-control-prev" role="button" data-slide="prev">
                                <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                            </a>
                             <a href="#carousel-example-1z" class="carousel-control-next" role="button" data-slide="next">
                                <span class="carousel-control-next-icon" aria-hidden="true"></span>
                            </a>
                        </div>
                    </div>
                </div>
            </section>
        </div>
    </main>
</template>

<script>
export default {
    
}
</script>

<style scoped>
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