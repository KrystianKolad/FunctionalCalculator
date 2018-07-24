namespace Program

open Calculator

module Logic = 

  let getOperation operationType =
      match operationType with
          | "+" -> add
          | "-" -> subtract
          | "*" -> multiply
          | "/" -> divide
          | _ -> failwith "Incorrect operation type"