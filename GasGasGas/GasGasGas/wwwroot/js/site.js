// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

// ---------------- MAKE HEADING COLORFUL ----------------
const elem = document.getElementById('mainheading');
let hue = 0;

function changeColor() {
    elem.style.color = `hsl(${hue}, 95%, 50%)`;
    hue = (hue + 1) % 360;
}
setInterval(changeColor, 16);


// ----- CREATE ONE-TIME HOVER EFFECT FORE YT EMBED -----
// get parent element of the youtube embed
const ytparent = document.getElementById('ytparent');
// argument for the transition function
let animationParameter = 0;
// seconds
const duration = .75;

ytparent.addEventListener('mouseover', scaleYTParent);

function scaleYTParent() {
    // scale the bouncy function to match the initial size (75%) and add .25 to end on 100% size
    ytparent.style.transform = `scale(${.75 + .25 * bouncyPolynomial(animationParameter)})`;
    animationParameter += 1 / (60 * duration);

    // setTimeout to restart the function if the end of the animation hasn't been reached
    if (animationParameter <= 1) {
        setTimeout(scaleYTParent, 1000 / 60);
        return;
    }

    // prevent the animation from happening on future mouseovers
    ytparent.removeEventListener('mouseover', scaleYTParent);
}

function bouncyPolynomial(x) {
    if (x >= 1) { return 1 }
    // smoothstep + bouncy curve
    return -3 * ((4 * x * (1 - x)) ** 6) * ((2 * x - 1) ** 3 + (1 - 2 * x)) + x ** 2 * (3 - 2 * x);
}