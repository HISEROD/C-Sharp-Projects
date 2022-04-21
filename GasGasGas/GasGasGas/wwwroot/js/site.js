// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
let elem = document.getElementById('mainheading');
let hue = 0;

function changeColor() {
    elem.style.color = `hsl(${hue}, 95%, 50%)`;
    hue = (hue + 1) % 360;
    setTimeout(changeColor, 16);
}

changeColor();