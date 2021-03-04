// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function handleFormSubmit(event) {
    event.preventDefault();
  
    const data = new FormData(event.target);
  
    const formJSON = Object.fromEntries(data.entries());
  
    const results = document.querySelector('.results pre');
    results.innerText = JSON.stringify(formJSON, null, 2);
  
    console.log(JSON.stringify(formJSON));
  }
  
  const form = document.querySelector('.contact-form');
  form.addEventListener('submit', handleFormSubmit);