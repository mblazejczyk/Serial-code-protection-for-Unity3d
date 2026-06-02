<?php

$connect = mysqli_connect("localhost", "zaqvxmpl_bscp", "Zaq12wsX132", "zaqvxmpl_bscp");


if($connect === false){
  die("ERROR: Could not connect. " . mysqli_connect_error());
}

$urlPath = $_SERVER["REQUEST_URI"];

$serial = array_slice(explode('/', rtrim($urlPath, '/')), -1)[0];

$sql = "INSERT INTO `serial_numbers` (`id`, `SerialNumber`, `Name`, `isValid`) VALUES (NULL, '$serial', '', '1')";
if(mysqli_query($connect, $sql)){
    echo "Records added successfully.";
} else{
    echo "ERROR: Could not able to execute $sql. " . mysqli_error($connect);
}

?>