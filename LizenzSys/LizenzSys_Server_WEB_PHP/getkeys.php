<?php
include 'global.php';
if((isset($_GET['action'])) && (isset($_GET['id']))) {
if ($_GET['action'] == 'ban') {
$query = "UPDATE licence Set
banned = '1'
WHERE id = '".mysql_escape_string($_GET['id'])."'";
$ban = mysql_query($query);
} elseif ($_GET['action'] == 'unban') {
$query = "UPDATE licence Set
banned = '0'
WHERE id = '".mysql_escape_string($_GET['id'])."'";
$unban = mysql_query($query);
echo mysql_error();
}
}
echo "<center><table border=\"1\">";
   echo "<tr>
	<th><b>ID</b></th>
	<th><b>Key</b></th>
	<th><b>HWID</b></th>
	<th><b>Time</b></th>
	<th><b>Valid till</b></th>
	<th><b>Banned</b></th>
	<th><b>Last Checked</b></th>
	<th><b>Tool</b></th>
  </tr>";
$query = "SELECT * FROM licence";
$select = mysql_query($query);
while($row = mysql_fetch_object($select))
   {
   if ($row->banned == '1') {
   $banned = "Yes";
   $action = "unban";
   } else {
   $banned = "No";
   $action = "ban";
   }
   echo '<tr>
    <th>'.htmlspecialchars($row->id).'</th>
    <th>'.htmlspecialchars($row->mkey).'</th>
    <th>'.htmlspecialchars($row->hwid).'</th>
	<th>'.htmlspecialchars($row->time).'</th>
	<th>'.htmlspecialchars($row->till).'</th>
	<th><a href="getkeys.php?action='.$action.'&id='.htmlspecialchars($row->id).'">'.$banned.'</th>
	<th>'.htmlspecialchars($row->last_check).'</th>
	<th>'.htmlspecialchars($row->tool).'</th>
  </tr>';
   }
   echo "</table></center>";
include 'footer.php';
?>