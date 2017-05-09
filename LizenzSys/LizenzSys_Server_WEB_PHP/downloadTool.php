<?php
include 'settings.php';
if ((isset($_GET['t'])) || (isset($_GET['l']))) {
	$tool = $_GET['t'];
	$licence = $_GET['l'];
}
if ($licence == '' || $tool  == '')
	die();
$query = "SELECT * FROM licence WHERE `mkey` = '$licence'";
$show = mysql_query($query);
while($row = mysql_fetch_object($show))
{
	$hwidindb = $row->hwid;
	$banned = $row->banned;
}
if($hwidindb == '') {
	echo "Invalid Licence!";
	die();
}
if($banned == 1) {
	echo "Licence has been banned!";
	die();
}
if ($tool == 'epvpimg_uploader')
{
	$datei = 'ePvPIMG_Uploader.exe';
	header("Content-Type: application/force-download");
	header("Content-Disposition: attachment; filename=\"". urlencode($datei) ."\"");
	header("Content-Length: ". filesize($datei));
	header("Content-Transfer-Encoding: binary");
	readfile($datei);
}
else if ($tool == 'steam_game_faker')
{
		$datei = @'rls/SteamGameFaker_V1.4.4_Release.rar';
		header("Content-Type: application/force-download");
		header("Content-Disposition: attachment; filename=SteamGameFaker_V1.4.4_Release.rar");
		header("Content-Length: ". filesize($datei));
		header("Content-Transfer-Encoding: binary");
		readfile($datei);
}
else
	echo 'Unknown_Error_Tool'; //Unknown Tool
?>