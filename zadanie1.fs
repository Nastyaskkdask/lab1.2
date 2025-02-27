open System

//1
printf "Введите размерность списка: "
let n = int(Console.ReadLine())
printfn "Введите числа: "
let list = [
    for i in 0..(n-1) do
        int(Console.ReadLine())
        
    ] 

let list1 = [
        for i in 0..(n-1) do
            -list.Item(i)
    ]        

printfn "Начальный список: %A" list
printfn "Обратный список: %A" list1



