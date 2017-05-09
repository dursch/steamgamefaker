<?php
if ((isset($_GET['t'])))
	$tool = $_GET['t'];
if ($tool == 'epvpimg_uploader') {
	$datei = 'ePvPIMG_Uploader.exe';
	header("Content-Type: application/force-download");
	header("Content-Disposition: attachment; filename=\"". urlencode($datei) ."\"");
	header("Content-Length: ". filesize($datei));
	header("Content-Transfer-Encoding: binary");
	readfile($datei);
}
else if ($tool == 'steam_game_faker') {
	$datei = 'SteamGameFaker.exe';
	header("Content-Type: application/force-download");
	header("Content-Disposition: attachment; filename=\"". urlencode($datei) ."\"");
	header("Content-Length: ". filesize($datei));
	header("Content-Transfer-Encoding: binary");
	readfile($datei);
}
?>