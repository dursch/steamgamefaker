<?php
include '../settings.php';
if ((isset($_GET['l'])) && (isset($_GET['d']))) {
$key = mysql_escape_string($_GET['l']);
$days = mysql_escape_string($_GET['d'] * 86400);
$add = "INSERT INTO licence
(`mkey`,time)
VALUES
('$key','$days')";
$addkey = mysql_query($add);
}
else
	echo "GTFO";
?>