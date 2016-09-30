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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 In the previous syntax, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is the definition of a function in a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> binding.  
  
 The entry point to a program that is compiled as an executable file is where execution formally starts. You specify the entry point to an F# application by applying the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> attribute to the program's <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function. This function (created by using a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> binding) must be the last function in the last compiled file. The last compiled file is the last file in the project or the last file that is passed to the command line.  
  
 The entry point function has type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. The arguments provided on the command line are passed to the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> function in the array of strings. The first element of the array is the first argument; the name of the executable file is not included in the array, as it is in some other languages. The return value is used as the exit code for the process. Zero usually indicates success; nonzero values indicate an error. There is no convention for the specific meaning of nonzero return codes; the meanings of the return codes are application-specific.  
  
 The following example illustrates a simple <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> function.  
  
 [!code[FsEntryPoint#501](../vs140/codesnippet/FSharp/entry-point--fsharp-_1.fs)]  
  
 When this code is executed with the command line <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, the output is as follows.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Implicit Entry Point  
 When a program has no <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> attribute that explicitly indicates the entry point, the top level bindings in the last file to be compiled are used as the entry point.  
  
## See Also  
 [Functions (F#)](../vs140/functions--fsharp-.md)   
 [Let Bindings (F#)](../vs140/let-bindings--fsharp-.md)