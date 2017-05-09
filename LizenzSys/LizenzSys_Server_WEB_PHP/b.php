<?php
include 'settings.php';
if ((isset($_GET['l'])) || (isset($_GET['h'])) || (isset($_GET['t']))) {
	$licence = mysql_escape_string($_GET['l']);
}
$query = "SELECT * FROM licence WHERE `mkey` = '".$licence."'";
$select = mysql_query($query);
while($row = mysql_fetch_object($select))
{
   $hwid = $row->hwid;
   $banned = $row->banned;
   $till = $row->till;
   $tool = $row->tool;
   $perma = $row->time;
}
$datum = date("d.m.Y");
$uhrzeit = date("H:i");
$last_check =  $datum . " " . $uhrzeit . " Uhr";
$query = "UPDATE licence Set
last_check = '$last_check'
WHERE `mkey` = '$licence'";
$activate = mysql_query($query);
if ($activate) {
	echo "";
}
else {
	echo mysql_error();
}
$date = new DateTime();
$currenttime = $date->getTimestamp();
if ($_GET['h'] == $hwid) {
    if($banned == '0')
    {
	    	if($till > $currenttime || $perma == '0')
		{
			if($_GET['t'] == $tool) {
				echo md5("KEY_IS_VALID"); //fa0bc52603cf0346f9c9291067fe156c
			} else {
				echo md5("INVALID_KEY"); //14eddb1ed548833eb26b0325f17b967e // Wrong tool
			}
		} else {
			echo md5("INVALID_KEY"); //14eddb1ed548833eb26b0325f17b967e
		}
	} else {
	    echo md5("BANNED_KEY"); //5d96895af4f86324762c9520d5ae6322
	}
} else {
	echo md5("INVALID_HWID"); //52fef60b81d3cb71a41467155f9948cb
}   
?>