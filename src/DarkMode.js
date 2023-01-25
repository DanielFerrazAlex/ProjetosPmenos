function darkMode() {
    var x = document.getElementById("toggle");
    if (x.innerHTML === "Dark Mode") {
        x.innerHTML = "Light Mode";
        var element = document.body;
        element.classList.toggle("dark-mode");
    }
    else {
        x.innerHTML = "Dark Mode";
        var element = document.body;
        element.classList.toggle("dark-mode");
    }
}