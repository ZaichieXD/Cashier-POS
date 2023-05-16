let validatedUsername = "";
let validatedPassword = "";

// These functions are for the login page
{
    // Logins the user if the data is valid
    function userLogin() {
        var username = document.getElementById("username-text").value;
        var password = document.getElementById("password-text").value;
        if (username == "" || password == "") {
            alert("Please enter username and password");
        }
        else {
            validateUserName(username);
            validatePassword(password);
        }

        clearFields();
    }

    // Deletes the data in the fields
    function clearFields() {
        document.getElementById("username-text").value = "";
        document.getElementById("password-text").value = "";
    }

    // Validates the username and makes sure it has POS
    function validateUserName(username) {
        if (username.includes("POS")) {
            validatedUsername = username;
        }
        else {
            alert("Invalid credentials");
        }

        console.log("User Validated");
    }

    // Validates the password and makes sure it has 090
    function validatePassword(password) {
        if (password.length > 8 && password.includes("090")) {
            validatedPassword = password;

        }
        else {
            alert("Invalid credentials");
        }

        console.log("User Validated");
    }
}
