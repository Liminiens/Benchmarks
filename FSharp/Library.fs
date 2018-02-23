namespace FSharp

module FindSequenceFSharp =   
    let list = [3; 1; 2; 10; 12; 228; 11; 1488; 7; 6; 8] |> List.sort
    
    let (|AddToList|ReplaceListInList|) (numbers, i) = 
        match numbers with   
        |  mainListHead :: _ ->
            match mainListHead with
            | head :: _ when head <> (i - 1) -> 
                AddToList
            | _ ->
                ReplaceListInList
        | [] -> 
            AddToList 

    let foldFunction acc i = 
        match (acc, i) with
        | AddToList -> 
            [[i]] @ acc
        | ReplaceListInList -> 
            match acc with
            | mainListHead :: mainListTail ->
                match mainListHead with 
                | head :: tail -> 
                    (i :: head :: tail) :: mainListTail        
    let getResult =
        (fun () ->                       
            list 
            |> List.fold foldFunction [] 
            |> List.length)
