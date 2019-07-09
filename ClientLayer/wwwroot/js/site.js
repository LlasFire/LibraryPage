let content;
let head;
let tabs;
let tabsA;
let showTab = document.getElementById('genres');
let headGenre = document.getElementById('headGenr');
let showTabAuth = document.getElementById('authors');
let headAuthor = document.getElementById('headAuthor');

window.addEventListener('load', () => {
    content = document.getElementById('Books');
    tabs = document.getElementsByClassName('Genre');
    tabsA = document.getElementsByClassName('Author');
    head = document.getElementsByClassName('HeadBooks');
    hideTabsContent();
});

function hideTabsContent() {

    content.classList.remove('show');
    content.classList.add('hide');

    for (let i = 0; i < head.length; i++) {
        head[i].classList.remove('show');
        head[i].classList.add('hide');
    }
}

showTab.addEventListener('click', (event) => {
    let target = event.target;
    while (target !== this) {
        if (target.className === "Genre") {
            for (let i = 0; i < tabs.length; i++) {
                if (target === tabs[i]) {
                    let head = tabs[i].querySelector("a");

                    let headG = headGenre.querySelector("h2");
                    headG.innerHTML = 'Books in a genre: ' + head.innerText;

                    GetBooks(head.id, "genre");

                    showGenres();

                    break;
                }
            }
            return;
        }
        target = target.parentNode;
    }
});

function showGenres() {

    hideTabsContent();

    content.classList.remove('hide');
    content.classList.add('show');

    headGenre.classList.remove('hide');
    headGenre.classList.add('show');

}

showTabAuth.addEventListener('click', (event) => {
    let target = event.target;
    while (target !== this) {
        if (target.className === "Author") {
            for (let i = 0; i < tabsA.length; i++) {
                if (target === tabsA[i]) {
                    let heads = tabsA[i].querySelector("a");

                    let headA = headAuthor.querySelector("h2");
                    headA.innerHTML = 'Books in author: ' + heads.innerText;

                    GetBooks(heads.id, "author");

                    showAuthor();

                    break;
                }
            }
            return;
        }
        target = target.parentNode;
    }
});

function showAuthor() {

    hideTabsContent();

    content.classList.remove('hide');
    content.classList.add('show');

    headAuthor.classList.remove('hide');
    headAuthor.classList.add('show');

}

function GetBooks(id, filter) {
    return fetch(`/Genres/BookSearch?filter=${filter}&id=${id}`, { method: 'POST' })
        .then(res => res.text())
        .then(books => document.getElementById('Books').innerHTML = books);
}
