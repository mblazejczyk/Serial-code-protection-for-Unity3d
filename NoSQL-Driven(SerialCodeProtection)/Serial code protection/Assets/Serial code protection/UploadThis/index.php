<?php

// configuration
$url = 'https://yellowsink.pl/secureAsset/index.php';
$file = 'codes.txt';

// check if form has been submitted
if (isset($_POST['text']))
{
    // save the text contents
    file_put_contents($file, $_POST['text']);

    // redirect to form again
    header(sprintf('Location: %s', $url));
    printf('<a href="%s">Moved</a>.', htmlspecialchars($url));
    exit();
}

// read the textfile
$text = file_get_contents($file);

?>
<p>Here you can add, remove and modify codes that are already working! Have fun!</p>
<text name="generatedHere">You can use one of those (refresh page if need to reshuffle): </text>
<br>
<?php
function randStrGen($len, $hmany) {
	$chars = 'ZAQSWWXECDVRFBTGNYHMUJKILOP1234567890';
	$charactersLength = strlen($chars);
	$randstring = '';
	for($j=0; $j<$hmany ; $j++){
		for ($i = 0; $i < $len; $i++) {
		$randstring .= $chars[rand(0, $charactersLength - 1)];
		}
		$randstring .= " ";
	}
		return $randstring;
}
echo randStrGen(16, 20);

?>
<!-- HTML form -->
<form action="" method="post">
<br>
<text name="generated"><?php echo $randstr ?></text>
<br>
<br>
<br>
<p>Remember to separate codes with (ONE) spacebar</p>
<textarea name="text" rows="40" cols="150"><?php echo htmlspecialchars($text) ?></textarea>
<br>
<input type="submit" />
<br>
<input type="reset" />
</form>