window.addEventListener('DOMContentLoaded', (event) => {

    let navBarElem = document.querySelector('nav');
    let buttonsArr = Array.from(navBarElem.querySelectorAll('button'));
    
    

    function showFlyoutMenu(e) {
        e.preventDefault();
        let menuElem = e.currentTarget.children[1];
        menuElem.classList.remove('hidden')
    }


    function hideFlyoutMenu(e) {
        e.preventDefault();
        let menuElem = e.currentTarget.children[1];
        menuElem.classList.add('hidden')
    }




    buttonsArr.forEach(x => x.parentElement.parentElement.addEventListener('mouseenter', (e) => {

        showFlyoutMenu(e);

    }))

    buttonsArr.forEach(x => x.parentElement.parentElement.addEventListener('mouseleave', (e) => {

        hideFlyoutMenu(e);

    }))




});