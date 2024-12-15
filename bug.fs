let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d" x y //This will print 20 10

//However, if we try to swap values in a function that takes tuples as input, like the following:

let swapTuple (x, y) = 
    let temp = x
    x <- y
    y <- temp

let myTuple = (10,20)
swapTuple myTuple
printf "%A" myTuple // This will print (10,20)