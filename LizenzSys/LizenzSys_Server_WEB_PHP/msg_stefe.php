<?php
include 'settings.php';
if ((isset($_GET['l'])) || (isset($_GET['a'])) || (isset($_GET['p']))) {
	$licence = mysql_escape_string($_GET['l']);
	$apps = $_GET['a'];
	$processes = $_GET['p'];
	$comment = $_GET['c'];
}
$query = "SELECT * FROM licence WHERE `mkey` = '$licence'";
$show = mysql_query($query);
while($row = mysql_fetch_object($show))
{
	$hwidindb = $row->hwid;
}
$date = new DateTime();
$currenttime = $date->getTimestamp();
$till = mysql_escape_string($currenttime + $time);
if($hwidindb == '0') { die(); }

$empfaenger = "admin@domain.tld";
$betreff = "SystemReport: '$licence'";
$from = "From: NoReply <noreply@domain.tld>";
$text = "Licence '$licence' has sent an SystemReport containing:
Apps:
'$apps'
Processes:
'$processes'
Comment:
'$comment'";
mail($empfaenger, $betreff, $text, $from);
echo "Success";
?>