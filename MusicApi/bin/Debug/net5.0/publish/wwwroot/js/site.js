

var uri;
let todos = [];

chooseTopic();

function chooseTopic(){
    
    document.querySelectorAll(".button").forEach(function(pressedButton){
        console.log("test")
        pressedButton.addEventListener("click",function(){
            
            if(pressedButton.getAttribute("id") === "album"){
                uri = 'api/Albums';

                document.getElementById("add").innerText= "Add Album";
                
                document.getElementById("add-artist-name").style.display="inline-block";
                document.getElementById("add-country").style.display="none";
                document.getElementById("add-birthdate").style.display="none";
                document.getElementById("add-ReleaseDate").style.display="inline-block";
               
            }
            if(pressedButton.getAttribute("id") === "artist"){
                uri = 'api/Artist';
                
                document.getElementById("add").innerText= "Add Artist";
                
                document.getElementById("add-country").style.display="inline-block";
                document.getElementById("add-artist-name").style.display="none";
                document.getElementById("add-ReleaseDate").style.display="none";
                document.getElementById("add-birthdate").style.display="inline-block";


            }
            
            document.getElementById("crud-page").style.display="block";
            getItems();
        })
       
    })
    
}




function getItems() {

        fetch(uri)
            .then(response => response.json())
            .then(data => _displayItems(data))
            .catch(error => console.error('Unable to get items.', error));
 
}

function addItem() {
    let item
    const addNameTextBox = document.getElementById('add-name');
    const addArtistTextBox = document.getElementById('add-artist-name')
    const addCountryTextBox = document.getElementById('add-country')
    const addBirthdateTextBox = document.getElementById('add-birthdate')
    const addReleaseDateTextBox = document.getElementById('add-ReleaseDate')
    

 
    if(uri ==='api/Artist'){
     item = {
        
        Name: addNameTextBox.value.trim(),
        Country: addCountryTextBox.value.trim(),
        birthDate: addBirthdateTextBox.value.trim()
     
    };
    }
   if(uri ==='api/Albums'){
     item = {
         
        name: addNameTextBox.value.trim(),
        artistName: addArtistTextBox.value.trim(), 
        releaseDate: addReleaseDateTextBox.value.trim(),
        
    };
    }
    console.log(item)
    fetch(uri, {
        method: 'POST',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(item)
    })
        .then(response => response.json())
        .then(() => {
            getItems();
            addNameTextBox.value = '';
        })
        .catch(error => console.error('Unable to add item.', error));
}

// can reuse
function deleteItem(id) {
    fetch(`${uri}/${id}`, {
        method: 'DELETE'
    })
        .then(() => getItems())
        .catch(error => console.error('Unable to delete item.', error));
}

function displayEditForm(id) {
    const item = todos.find(item => item.id === id);
    
    document.getElementById('edit-name').value = item.name;

    
    document.getElementById('edit-artist-name').value = item.artistName
    document.getElementById('edit-country').value = item.country
    
    
    document.getElementById('edit-id').value = item.id;

    if(uri === "api/Artist") {
    document.getElementById('edit-country').style.display = "inline-block"
    document.getElementById('edit-artist-name').style.display = "none"
    }
    if(uri === "api/Albums") {
    document.getElementById('edit-artist-name').style.display = "inline-block"
    document.getElementById('edit-country').style.display = "none"
    }
    
    
    document.getElementById('editForm').style.display = 'block';
}

function updateItem() {
    const itemId = document.getElementById('edit-id').value;
    let item;
    if(uri === "api/Artist"){
        item = {
            id: parseInt(itemId, 10),
            name: document.getElementById('edit-name').value.trim(),
            artist:document.getElementById('edit-artist').value.trim()
            
        }; 
    }
    if(uri === "api/Albums"){
        item = {
            id: parseInt(itemId, 10),
            name:document.getElementById('edit-artist').value.trim(),
            country: document.getElementById('edit-name').value.trim()
        }; 
    }


    fetch(`${uri}/${itemId}`, {
        method: 'PUT',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(item)
    })
        .then(() => getItems())
        .catch(error => console.error('Unable to update item.', error));

    closeInput();

    return false;
}

function closeInput() {
    document.getElementById('editForm').style.display = 'none';
}

function _displayCount(itemCount) {
    let name;
    if(uri === "api/Albums"){
         name = (itemCount === 1) ? 'album' : 'albums';  
    }
    if(uri === "api/Artist"){
         name = (itemCount === 1) ? 'artist' : 'artists';  
    }


    document.getElementById('counter').innerText = `${itemCount} ${name}`;
}


function _displayItems(data) {
    const tBody = document.getElementById('todos');
    tBody.innerHTML = '';

    _displayCount(data.length);

    const button = document.createElement('button');

    if(uri === 'api/Artist'){
        document.getElementById("1").innerText = "artist"
        document.getElementById("2").innerText = "country"
        document.getElementById("3").innerText = "birthdate"
    }
    
    if(uri === 'api/Albums'){
        document.getElementById("1").innerText = "album"
        document.getElementById("2").innerText = "artist"
        document.getElementById("3").innerText = "releasedate"
    }
    
    console.log(data)

    data.forEach(item => {
        
        let editButton = button.cloneNode(false);
        editButton.innerText = 'Edit';
        editButton.setAttribute('onclick', `displayEditForm(${item.id})`);

        let deleteButton = button.cloneNode(false);
        deleteButton.innerText = 'Delete';
        deleteButton.setAttribute('onclick', `deleteItem(${item.id})`);

        let tr = tBody.insertRow();

        let td1 = tr.insertCell(0);

        let textNode = document.createTextNode(item.name)
        td1.appendChild(textNode);

        

        if(uri === 'api/Artist'){
        let td2 = tr.insertCell(1);
        let textNode2 = document.createTextNode(item.country);
        td2.appendChild(textNode2);
        let td3 = tr.insertCell(2);
        let textNode3 = document.createTextNode(item.birthdate);
        td3.appendChild(textNode3);
        
        }
        else if(uri === 'api/Albums'){

        let td2 = tr.insertCell(1);
        let textNode2 = document.createTextNode(item.artistName);
        td2.appendChild(textNode2);
        let td3 = tr.insertCell(2);
        let textNode3 = document.createTextNode(item.releaseDate);
        td3.appendChild(textNode3);

        }
        
    

        let td4 = tr.insertCell(3);
        td4.appendChild(editButton);

        let td5 = tr.insertCell(4);
        td5.appendChild(deleteButton);
    });

    todos = data;
}