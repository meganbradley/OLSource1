---
title: "Seq.choose&lt;&#39;T,&#39;U&gt; Function (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
apiname: 
  - "Seq.choose<'T,'U>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.SeqModule.Choose``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Seq.choose function [F#]"
  - "choose function [F#]"
ms.assetid: 63b83b06-4b24-4239-bf69-a2c12d891395
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Seq.choose&lt;&#39;T,&#39;U&gt; Function (F#)
Applies the given function to each element of the list and returns the list comprised of the results for each element where the function returns <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> with some value.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.Seq  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>[option](../vs140/core.option--t--union--fsharp-.md)  
  
 A function to transform items of type T into options of type U.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Type: [seq](../vs140/collections.seq--t--type-abbreviation--fsharp-.md)<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
 The input sequence of type T.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|\<xref:System.ArgumentNullException*>|Thrown when the input sequence is null.|  
  
## Return Value  
 The result sequence.  
  
## Remarks  
 The returned sequence may be passed between threads safely. However, individual <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> values generated from the returned sequence should not be accessed concurrently.  
  
 This function is named <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code example demonstrates the use of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to select elements from a sequence by using a lambda expression that uses pattern matching to return an option type.  
  
 [!code[FsSamples101#1008](../vs140/codesnippet/FSharp/seq.choose--t--u--function--fsharp-_1.fs)]  
  
 **numbers = seq [1; 2; 3; 4; ...]**  
**evens = seq [2; 4; 6; 8; ...]**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Seq Module (F#)](../vs140/collections.seq-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)