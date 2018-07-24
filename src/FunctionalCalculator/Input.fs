namespace Program

open System

module Input = 

  let getFirstVariable = 
      printfn "%s" "Enter first number"
      Console.ReadLine() |> int

  let getOperationType = 
      printfn "%s" "Enter operation type"
      Console.ReadLine()

  let getSecondVariable = 
      printfn "%s" "Enter second number"
      Console.ReadLine() |> int

