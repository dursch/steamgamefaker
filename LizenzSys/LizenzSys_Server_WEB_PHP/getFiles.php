<?php
if ((isset($_GET['t']))) {
	$tool = $_GET['t'];
}
if ($tool == 'steam_game_faker')
{
	echo 'SteamGameFaker.exe';
	echo '|';
	echo 'GameDummy.exe';
}
else
	echo 'Unknown Error'; //Unknown Tool
?>