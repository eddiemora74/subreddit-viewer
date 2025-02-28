let modal;

function closeModal() {
    modal.hide();
}

function showModal() {
    if (!modal) {
        setGlobalModal();
    }
    modal.show();
}

function setGlobalModal() {
    const modalElem = document.getElementById("search-subreddit-modal");
    modal = new bootstrap.Modal(modalElem);
}
