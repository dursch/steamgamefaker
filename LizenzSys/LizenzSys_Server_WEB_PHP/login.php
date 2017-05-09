<?php
include 'global.php';

if ($_GET['logout'] == 'true') {
session_destroy(); 
echo '<meta http-equiv="refresh" content="0; URL=login.php?login=true">';
}


if ($_SESSION['loggedin'] == "true") {

echo 'Already logged in! <a href="getkeys.php">Click here to continue</a>.';
echo '<meta http-equiv="refresh" content="0; URL=getkeys.php">';

} else {

if($login=="true") 
{ 
echo " 
<form action=\"?login=true\" Method=\"post\"> 
Username:<br> 
<input type=\text\" name=\"username\" size=\"35\"><br>
Password:<br>
<input type=\password\" name=\"password\" size=\"35\"><br>
 <input type=\"submit\" value=\"Submit\"> 

</form> ";

if($username == $_POST['username'] && $password == $_POST['password']) {
$_SESSION['loggedin'] = 'true';
echo '<meta http-equiv="refresh" content="0; URL=getkeys.php">';
}
} else {

echo '<meta http-equiv="refresh" content="0; URL=getkeys.php">';
}

}


include 'footer.php';

?>