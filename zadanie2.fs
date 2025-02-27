open System

printf "Введите натуральное число: "
let S = Console.ReadLine()

let rec t sum i =
    if i = S.Length then
        printf "Кол-во чётных элементов в числе = %i" sum
        sum
    else
        let currentChar = S.[i]
        if Char.IsDigit(currentChar) then
            if (int currentChar - int '0') % 2 = 0 then
                t (sum + 1) (i + 1)
            else
                t sum (i + 1)
        else
            printf "Ошибка ввода"
            sum 

t 0 0
