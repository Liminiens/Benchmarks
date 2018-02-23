namespace FSharp

module FindSequenceFSharp =    
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
                    
    let getResult list =                    
        list 
        |> Seq.fold foldFunction [] 
        |> Seq.length
