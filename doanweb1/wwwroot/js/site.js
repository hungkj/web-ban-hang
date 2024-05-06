// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// ------------------------- MENU -----------------------------------
//const header = document.querySelector("header")
//window.addEventListener("scroll",function() {
//    scrollY = window.pageYOffset;
//   if (scrollY>0) {
//        header.classList.add("sticky")
//    }
//    else {
//        header.classList.remove("sticky")
//    }
//})
hamburger = document.querySelector(".hamburger");
hamburger.onclick = function () {
    navBar = document.querySelector(".nav-bar");
    navBar.classList.toggle("active");
}





const imgPosition = document.querySelectorAll(".viewer-slide img")
const imgContainer = document.querySelector(".viewer-slide")
const dotItem = document.querySelectorAll(".dot")
let imgNumber = imgPosition.length
let index = 0

imgPosition.forEach(function (image, index) {
    image.style.left = index * 100 + "%"
    dotItem[index].addEventListener("click", function () {
        slider(index)
    })
})
function imgSlide() {
    index++;
    console.log(index)
    if (index >= imgNumber) {
        index = 0
    }
    slider(index)
}
function slider(index) {
    imgContainer.style.left = "-" + index * 100 + "%"
    const dotActive = document.querySelector('.active')
    dotActive.classList.remove("active")
    dotItem[index].classList.add("active")
}
setInterval(imgSlide, 5000)

// ------------------------- CARTEGORY -----------------------------------
const itemsliderbar = document.querySelectorAll(".cartegory-left-li")
itemsliderbar.forEach(function (menu, index) {
    menu.addEventListener("click", function () {
        menu.classList.toggle("block")
    })
})

//----------------------Product------------------------

const bigImg = document.querySelector(".product-content-left-big-img img")
const smallImg = document.querySelectorAll(".product-content-left-small-img img")
smallImg.forEach(function (imgItem, X) {
    imgItem.addEventListener("click", function () {
        bigImg.src = imgItem.src
    })
})

const baoquan = document.querySelector(".baoquan")
const chitiet = document.querySelector(".chitiet")
const gioithieu = document.querySelector(".gioithieu")
if (baoquan) {
    baoquan.addEventListener("click", function () {
        document.querySelector(".product-content-right-bottom-content-gioithieu").style.display = "none"
        document.querySelector(".product-content-right-bottom-content-chitiet").style.display = "none"
        document.querySelector(".product-content-right-bottom-content-baoquan").style.display = "block"
    })
}

if (gioithieu) {
    gioithieu.addEventListener("click", function () {
        document.querySelector(".product-content-right-bottom-content-chitiet").style.display = "none"
        document.querySelector(".product-content-right-bottom-content-baoquan").style.display = "none"
        document.querySelector(".product-content-right-bottom-content-gioithieu").style.display = "block"
    })
}

if (chitiet) {
    chitiet.addEventListener("click", function () {
        document.querySelector(".product-content-right-bottom-content-baoquan").style.display = "none"
        document.querySelector(".product-content-right-bottom-content-gioithieu").style.display = "none"
        document.querySelector(".product-content-right-bottom-content-chitiet").style.display = "block"
    })
}
const buttona = document.querySelector(".product-content-right-bottom-top")
if (buttona) {
    buttona.addEventListener("click", function () {
        document.querySelector(".product-content-right-bottom-content-big").classList.toggle("activeB")
    })
}