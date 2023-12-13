// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const mainMenu = document.querySelector('.mainMenu');
const openMenu = document.querySelector('.openMenu');
const closeMenu = document.querySelector('.closeMenu');


openMenu.addEventListener('click', show);
closeMenu.addEventListener('click', close);


function show(){
    mainMenu.style.display='flex';
    mainMenu.style.top='0';
}

function close(){
    mainMenu.style.top='-100%';
    
}