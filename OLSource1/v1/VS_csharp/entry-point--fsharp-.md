---
title: "Entry Point (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "entry points [F#]"
  - "main function [F#]"
  - "EntryPoint attribute [F#]"
ms.assetid: a25e68de-a95b-4128-9bc3-ccacf5b5fb86
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Entry Point (F#)
This topic describes the method that you use to set the entry point to an F# program.  
  
## Syntax  
  
```  
[<EntryPoint>]  
let-function-binding  
```  
  
## Remarks  
 In the previous syntax, `let-function-binding` is the definition of a function in a `let` binding.  
  
 The entry point to a program that is compiled as an executable file is where execution formally starts. You specify the entry point to an F# application by applying the `EntryPoint` attribute to the program's `main` function. This function (created by using a `let` binding) must be the last function in the last compiled file. The last compiled file is the last file in the project or the last file that is passed to the command line.  
  
 The entry point function has type `string array -> int`. The arguments provided on the command line are passed to the `main` function in the array of strings. The first element of the array is the first argument; the name of the executable file is not included in the array, as it is in some other languages. The return value is used as the exit code for the process. Zero usually indicates success; nonzero values indicate an error. There is no convention for the specific meaning of nonzero return codes; the meanings of the return codes are application-specific.  
  
 The following example illustrates a simple `main` function.  
  
 [!code[FsEntryPoint#501](../VS_csharp/codesnippet/FSharp/entry-point--fsharp-_1.fs)]  
  
 When this code is executed with the command line `EntryPoint.exe 1 2 3`, the output is as follows.  
  
```  
Arguments passed to function : [|"1"; "2"; "3"|]  
```  
  
## Implicit Entry Point  
 When a program has no `EntryPoint` attribute that explicitly indicates the entry point, the top level bindings in the last file to be compiled are used as the entry point.  
  
## See Also  
 [Functions (F#)](../VS_csharp/functions--fsharp-.md)   
 [Let Bindings (F#)](../VS_csharp/let-bindings--fsharp-.md)