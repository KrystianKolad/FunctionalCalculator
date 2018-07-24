namespace Program

open System
open Logic
open Input


module Program = 

  [<EntryPoint>]
  let main argv = 
      try
        printfn "%i" ((getOperation getOperationType) getFirstVariable getSecondVariable)
      with
        | Failure msg -> printfn "%s" msg
        | :? FormatException as ex -> printfn "%s" ex.Message

      printfn "%s" "Press any key..."
      Console.ReadKey() |> ignore
      0 
