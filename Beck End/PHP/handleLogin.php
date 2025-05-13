<?php

$gebruikersnaam = $_POST['username'];
$wachtwoord = $_POST['wachtwoord'];
if($gebruikersnaam == "admin" && $wachtwoord == "admin123") 
{
    echo "je bent ingelogd";
} 
else {
    echo "De gegevens klopen niet";
}
?>