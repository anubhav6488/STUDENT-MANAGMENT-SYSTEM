//const passwordInput = document.getElementById('password');
//const showPasswordToggle = document.getElementById('showPasswordToggle');
//const passwordInput1 = document.getElementById('password1');
//const showPasswordToggle1 = document.getElementById('showPasswordToggle1');

//  showPasswordToggle.addEventListener('click', () => {
//    if (passwordInput.type === 'password') {
//        passwordInput.type = 'text';
//        showPasswordToggle.textContent = 'Hide Password';
//    } else {
//        passwordInput.type = 'password';
//        showPasswordToggle.textContent = 'Show Password';
//    }

//});
//showPasswordToggle1.addEventListener('click', () => {
//    if (passwordInput1.type === 'password1') {
//        passwordInput1.type = 'text';
//            showPasswordToggle.textContent = 'Hide Password';
//    } else {
//        passwordInput1.type = 'password1';
//         showPasswordToggle.textContent = 'Show Password';
//    }
//    createUserName.addEventListener('click', () => {
//        result = [];
        
        
//    })
//});
/**CREATING USER REGISTERATION
 * -signup page
 */
function processInputs() {
    var inputValue = document.getElementById("firstname").value;
    var inputValue1 = document.getElementById("lastname").value;
    var inputValue3 = document.getElementById("emailid").value; 
    var inputValue4 = document.getElementById("password").value;
    var inputValue2 = document.getElementById("username").value;
    var obj = {};
    obj.firstname = inputValue;
    obj.lastname = inputValue1;
    obj.emailid = inputValue3
    obj.password = inputValue4;
    obj.username = inputValue2;
    if (obj.emailid, obj.firstname, obj.lastname, obj.password, obj.username) {
        $.ajax({
            global: true,
            type: "POST",
            url: "/create/testt",
            data: JSON.stringify(obj),
            contentType: "application/json;charset=utf-8",
            dataType: "html",
            success: function (response) {
                if (response.success) {
                    console.log("Data inserted successfully.");
                } else {
                    console.log("Data insertion failed.");
                }
            },
            error: function (xhr, status, error) {
                console.log("AJAX Error:", error);
            }
}
    
        });
    }
//fetch('/url', {
//    method: 'POST',
//    headers: {
//        'Content-Type': 'application/json'
//    },
//    body: JSON.stringify(data)
//}).then(response => response.json())
//    .then(data => {
//        // Handle response data
//    });