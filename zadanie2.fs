open System

printf "Введите натуральное число:  "

let S = Console.ReadLine()

let rec t sum i =
    if i = S.Length then
        printfn "Кол-во чётных элементов в числе = %i" sum
        sum
    elif int(S.Chars(i)) % 2 = 0 then
        t (sum + 1) (i + 1)
    else
        t sum (i + 1)

t 0 0
