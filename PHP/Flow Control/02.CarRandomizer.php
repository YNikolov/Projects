<!Doctype html>
<html>
    <head>
        <title>02.CarRandomizer</title>
    </head>
    <body>
    <form action="02.CarRandomizer.php" method="post" >
        <label>Enter cars</label>
        <input type="text" name="cars">
        <input type="submit" value="Show result">
    </form>
    <?php
        if(isset($_POST["cars"]) && $_POST["cars"] !== "") : ?>
            <?php
            $cars = explode(", ", htmlentities($_POST["cars"]));
            //var_dump($cars);
            $colors = ['yellow','green','black']; ?>
         <table border="1">
             <thead>
                <tr>
                    <th>Car</th>
                    <th>Color</th>
                    <th>Count</th>
                </tr>
             </thead>
        <?php endif; ?>
        <tbody>
        <?php for($i = 0; $i < count($cars); $i++ ) : ?>
            <tr>
                <td><?= $cars[$i] ?></td>
                <td><?= $colors[rand(0, count($colors) - 1)]; ?></td>
                <td><?= rand(1, 5) ?></td>
            </tr>
    <?php endfor; ?>
    </body>
</html>
<?php
?>