let x = 10
let y = 20

let swap x y =
    (y, x)

let (x, y) = swap x y
printf "%d %d" x y //This will print 20 10

//Alternatively, using a tuple for swapping
let swapTuple (x, y) = (y, x)
let (x, y) = swapTuple (x, y)
printf "%d %d" x y //This will also print 20 10