<!Doctype html>
<html>
    <head>
        <title>01.Square Root Sum</title>
    </head>
    <body>
        <table border = 1>
            <thead>
                <tr>
                    <th><b>Number</b></th>
                    <th><b>Square</b></th>
                </tr>
            </thead>
            <tbody>
                <?php $total = 0; ?>
                <?php for($i = 0; $i < 101; $i += 2) : ?>
                <tr>
                    <td><?= $i ?></td>
                    <td><?= $sqrNum = round(sqrt($i), 2) ?></td>
                </tr>
                <?php
                    $total += $sqrNum;
                    endfor;
                ?>
            </tbody>
               <tfoot>
                   <tr>
                       <td><b>Total:</b></td>
                       <td><?= $total ?></td>
                   </tr>
               </tfoot>
        </table>
    </body>
</html>