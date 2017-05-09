<?php
$username = 'Username';
$password = 'Passwort';
$mysql_host = '127.0.0.1';
$mysql_user = 'root';
$mysql_pass = 'mysql_Passwort';
$mysql_database = 'Licence';
$dbconnect = @mysql_connect($mysql_host,
$mysql_user, $mysql_pass)
or die ("Can't connect to database!");
   @mysql_select_db($mysql_database)
or die ("Can't select database!");   
   ?>
