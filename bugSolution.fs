let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d" x y //This will print 20 10

//To swap values in a tuple, return a new tuple:

let swapTuple (x, y) = (y, x)

let myTuple = (10,20)
let swappedTuple = swapTuple myTuple
printf "%A" swappedTuple //This will print (20, 10)
printf "%A" myTuple    //This will print (10,20) - original tuple is unchanged