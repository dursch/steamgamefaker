<?php
if ((isset($_GET['v'])) || (isset($_GET['t']))) {
	$ver = $_GET['v'];
	$tool = $_GET['t'];
}
if ($ver == '1.2.1' && $tool == 'epvpimg_uploader')
	echo 'c9f1a6384b1c466d4612f513bd8e13ea'; //VALID
else if ($ver == '2.0.1' && $tool == 'steam_game_faker')
	echo 'c9f1a6384b1c466d4612f513bd8e13ea'; //VALID
else
	echo '15a8022d0ed9cd9c2a2e756822703eb4'; //UPDATE
?>