open System
//2
printf "Введите натуральное число: "

let S = string(Console.ReadLine())

let rec t sum i =

    if i = S.Length then
        printf "Кол-во чётных элементов в числе = %i" sum
        sum
    elif int(S[i]) % 2 = 0 then
        t (sum + 1) (i + 1)
    else
        t sum (i + 1)

 