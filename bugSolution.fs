let swap x y =
    let temp = x, y
    (snd temp, fst temp)

let x, y = swap (10, 20)
printf "%d %d" x y //This will print 20 10