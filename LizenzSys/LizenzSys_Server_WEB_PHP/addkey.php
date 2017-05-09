<?php
include 'global.php';
if ((isset($_POST['key'])) && (isset($_POST['days']))) {
$key = mysql_escape_string($_POST['key']);
$days = mysql_escape_string($_POST['days'] * 86400);
$add = "INSERT INTO licence
(`mkey`,time)
VALUES
('$key','$days')";
$addkey = mysql_query($add);
echo '<b><font color="red">'.mysql_error().'</font></b>';
}
echo " 
<form action=\"addkey.php\" Method=\"post\"> 
Key:<br> 
<input type=\text\" name=\"key\" size=\"35\"><br>
Days (enter 0 for unlimited):<br>
<input type=\text\" name=\"days\" size=\"35\"><br>
 <input type=\"submit\" value=\"Submit\"> 

</form> ";
include 'footer.php';
?>