function handleFormSubmit(event) {
  event.preventDefault();

  const data = new FormData(event.target);

  const formJSON = Object.fromEntries(data.entries());

  const results = document.querySelector('.results pre');
  results.innerText = JSON.stringify(formJSON, null, 2);

  var request = new XMLHttpRequest();
  var url = "https://saewebsitedatatorage.blob.core.windows.net/regdata/"+formJSON.Email+".txt?sp=racwdl&st=2021-03-02T13:11:11Z&se=2022-04-01T20:11:11Z&spr=https&sv=2020-02-10&sr=c&sig=i4tXmFr6xoX1Kla9Jawz4dUZFhggvsIhj3GJCRhacsc%3D"
  request.open("PUT", url);
  request.setRequestHeader("x-ms-blob-type","BlockBlob");
  request.send(JSON.stringify(formJSON));

  console.log(JSON.stringify(formJSON));
}

const form = document.querySelector('.contact-form');
form.addEventListener('submit', handleFormSubmit);