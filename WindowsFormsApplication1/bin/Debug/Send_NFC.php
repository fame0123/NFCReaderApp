<?php
$line = '';

//$f = fopen('data.txt', 'r');
//$cursor = -1;
//fseek($f, $cursor, SEEK_END);
//$char = fgetc($f);

$myfile = fopen("jam.txt", "r") or die("Unable to open file!");
$char = fread($myfile,filesize("jam.txt"));
fclose($myfile);

//echo $char[];
/**
 * Trim trailing newline chars of the file
 */
//echo $char;
$datas = explode("+", $char);

//print_r($datas[0]); //----> this line print array

$length = count($datas) - 1;

for($i = 0; $i < $length; $i++)
{
	$text = str_replace(array("\n", "\r"), '', $datas[$i]);
	
	SendToServer($text);
	
	//$dataList = $datas[$i];
	//echo $dataList ."-" ;
}


function SendToServer($line) {
    $data_string = $line;
	
	$ch = curl_init('https://jam.document.fish/api/1.1/wf/Import');// where to post        
	curl_setopt($ch, CURLOPT_CUSTOMREQUEST, "POST");
	curl_setopt($ch, CURLOPT_POSTFIELDS, $data_string);
	curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);
	curl_setopt($ch, CURLOPT_HTTPHEADER, array(
		'Content-Type: application/json',
		'Content-Length: ' . strlen($data_string))
	);

	$result = curl_exec($ch);
	//} else {
	//echo "no data sent";
	//}
	echo $data_string;
	
}

$fh = fopen( 'jam.txt', 'w' );
fclose($fh);
//echo $line;


?>