// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
function classOnClick(className, fn) {
    let nodes = document.getElementsByClassName(className);
    for (let i = 0; i < nodes.length; i++) {
        let node = nodes[i];
        node.addEventListener("click", function (e) { fn(e) });
    }
}
