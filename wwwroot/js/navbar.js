window.addEventListener('DOMContentLoaded', (event) => {

    let navBarElem = document.querySelector('nav');
    let buttonsArr = Array.from(navBarElem.querySelectorAll('button'));
    buttonsArr.forEach(x => x.addEventListener('click', (e) => {
        e.preventDefault();
        let menuElem = e.currentTarget.parentElement.parentElement.children[1];
        if (menuElem.classList.contains('hidden')) {
            menuElem.classList.remove('hidden')
        } else {
            menuElem.classList.add('hidden')
        }
            
    }))

});