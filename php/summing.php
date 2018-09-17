<html>
    <head></head>
    <body>
        <form method="post" action="summing.php">
            <input type="text" name="number1" placeholder="Give me a number: ">
            <br><br>
            <input type="submit" value="Sum the numbers">
        </form>
        <?php 
        $sum = 0; 
        $i = 1;
        while (isset($_POST['number1'])){
            $number = $_POST['number1'];
            $sum += intval($number);
            $i += 1; 
            print_r($sum);
            break;
        }
        ?>
    </body>
</html>
