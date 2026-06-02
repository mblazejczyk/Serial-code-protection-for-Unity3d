<?php

$connect = mysqli_connect("localhost", "zaqvxmpl_bscp", "Zaq12wsX132", "zaqvxmpl_bscp");

if($connect === false){
  die("ERROR: Could not connect. " . mysqli_connect_error());
}
$urlPath = $_SERVER["REQUEST_URI"];
$serial = array_slice(explode('/', rtrim($urlPath, '/')), -1)[0];
$name = array_slice(explode('/', rtrim($urlPath, '/')), -2)[0];

$sql = "SELECT * FROM `serial_numbers` WHERE `SerialNumber` = '$serial'";

$result = $connect->query($sql);

if ($result->num_rows > 0) {
  while($row = $result->fetch_assoc()) {
    if($row["isValid"] == 1){
      if($row["Name"] == ""){
        echo "noName";
        $sql = "UPDATE `serial_numbers` SET `Name` = '$name' WHERE `SerialNumber` = '$serial'";
        if(mysqli_query($connect, $sql)){
        }
      }else if($row["Name"] == $name){
        echo "inputNameCorrect";
      }else{
        echo "wrongName";
      }
    }else{
      echo "notValid";

    }
  }
} else {
  echo "wrongCode";
}

?>