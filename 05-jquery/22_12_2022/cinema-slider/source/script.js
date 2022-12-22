//Başlangıç pozisyonlaması ve indeks.
var cardIndex = 4;
var positionLeft = 0;

//Tüm sliderleri tutan div'e erişme
var cardSlider = document.querySelector("#cardSlider");
console.log(cardSlider);

//Sliderleri içerenin boyutunu alma.
var carouselInnerWidth = $('.carousel-inner')[0].scrollWidth;
console.log("carouselInnerWidth: "+carouselInnerWidth);

var cardItemWidth = $('.carousel-item').width();
console.log("cardItemWidth: "+cardItemWidth);

var countItem = carouselInnerWidth / cardItemWidth;
console.log("countItem: "+countItem);

//When user click next button below code will run
$('.carousel-control-next').on("click", function(){
    if(cardIndex < countItem){
        cardIndex++;
        positionLeft -= cardItemWidth;
    }
    else{}

    $(".carousel-inner").animate({left: positionLeft});
});

$('.carousel-control-prev').on("click", function(){
    if(cardIndex > 4){
        cardIndex--;
        positionLeft += cardItemWidth;
    }
    else{}

    $(".carousel-inner").animate({left: positionLeft});
});