function setClass(number){
    var container = document.getElementsByClassName("container")[0];
    var ul = container.firstElementChild;
    var lis = ul.children;
    
    for(li of lis){
        var a = li.firstElementChild;
        a.classList.remove("active");
    }

    var clicked = lis[number].firstElementChild;
    clicked.className = "active";
}