<?php
include 'settings.php';
if ((isset($_GET['l'])) || (isset($_GET['h'])) || (isset($_GET['t']))) {
	$licence = mysql_escape_string($_GET['l']);
	$tool = $_GET['t'];
	$hwid = mysql_escape_string($_GET['h']);
}
$query = "SELECT * FROM licence WHERE `mkey` = '$licence'";
$show = mysql_query($query);
while($row = mysql_fetch_object($show))
{
	$hwidindb = $row->hwid;
	$time = $row->time;
	$banned = $row->banned;
}
$date = new DateTime();
$currenttime = $date->getTimestamp();
$till = mysql_escape_string($currenttime + $time);
if($hwidindb != '0' && $hwidindb != '1') {
	echo md5("KEY_ALREADY_USED"); //84909abf7883a5152c49523673f53eb6
	die();
}
if (banned == 1) {
	echo md5("KEY_ALREADY_USED"); //84909abf7883a5152c49523673f53eb6
	die();
}
$query = "UPDATE licence Set
hwid = '$hwid',
till = '$till',
tool = '$tool'
WHERE `mkey` = '$licence'";
$activate = mysql_query($query);
if ($activate) {
	echo md5("KEY_ACTIVATED"); //33a35912e3ea36b74657dd022a17769c
	$empfaenger = "admin@domain.tld";
	$betreff = "Licence '$licence' activated";
	$from = "From: NoReply <noreply@domain.tld>";
	$text = "Licence '$licence' has been actived with hwid '$hwid' and tool '$tool' .";
	mail($empfaenger, $betreff, $text, $from);
} else {
	echo md5("ERROR"); //bb1ca97ec761fc37101737ba0aa2e7c5
}
?>