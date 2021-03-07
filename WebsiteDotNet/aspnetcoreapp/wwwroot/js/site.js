// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function handleFormSubmit(event) {
    event.preventDefault();
  
    const data = new FormData(event.target);
  
    const formJSON = Object.fromEntries(data.entries());
  
    const results = document.querySelector('.results pre');
    results.innerText = JSON.stringify(formJSON, null, 2);
  
    var request = new XMLHttpRequest();
    var url = "https://saewebsitedatatorage.blob.core.windows.net/regdataappservice/"+formJSON.Email+".txt?sp=racwdl&st=2021-03-07T18:28:13Z&se=2022-01-01T02:28:13Z&spr=https&sv=2020-02-10&sr=c&sig=0UH6VgaljBVisyQvsbcvGDfE4gJa6bFOpUwO8UdZvqs%3D"
    request.open("PUT", url);
    request.setRequestHeader("x-ms-blob-type","BlockBlob");
    request.send(JSON.stringify(formJSON));
  }
  
  const form = document.querySelector('.contact-form');
  form.addEventListener('submit', handleFormSubmit);