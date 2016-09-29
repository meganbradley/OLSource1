    let set1 = Set.ofList [ 1 .. 6 ]
    let set2 = Set.ofList [ 1 .. 5 ]
    let set3 = Set.ofList [ 1 .. 6 ]
    let set4 = Set.ofList [ 5 .. 10 ]
    printfn "%A is a subset of %A: %b" set2 set1 (Set.isSubset set2 set1)
    printfn "%A is a subset of %A: %b" set3 set1 (Set.isSubset set3 set1) 
    printfn "%A is a subset of %A: %b" set4 set1 (Set.isSubset set4 set1) 