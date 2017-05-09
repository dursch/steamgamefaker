<?php
session_start();

include 'settings.php';

if(isset($_GET['login'])){
$login = $_GET['login']; 
} else {
$login = 'false'; }

if($_GET['noheader'] != 'true') {
   echo '<center><a href="getkeys.php">Manage Keys</a> | <a href="login.php?logout=true">Logout</a></center><hr>';
   }

if ($login != 'true') {
if($_SESSION['loggedin'] != 'true') 
   { 
   echo "Bitte erst <a href=\"login.php?login=true\">einloggen</a>";
   echo '<meta http-equiv="refresh" content="0; URL=login.php?login=true">';
   require 'footer.php';
   exit; 
   } 
   }
   ?>