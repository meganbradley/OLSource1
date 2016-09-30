---
title: "Seq.iter2&lt;&#39;T1,&#39;T2&gt; Function (F#)"
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
  - "Seq.iter2<'T1,'T2>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.SeqModule.Iterate2``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "iter2 function [F#]"
  - "Seq.iter2 function [F#]"
  - "Seq.Iterate2 function [F#]"
  - "Iterate2 function [F#]"
ms.assetid: 1e957e9d-037a-4aa9-a5de-15cabd4809f6
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Seq.iter2&lt;&#39;T1,&#39;T2&gt; Function (F#)
Applies the given function to two collections simultaneously. If one sequence is shorter than the other then the remaining elements of the longer sequence are ignored.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Seq  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>[unit](../vs140/core.unit-type-abbreviation--fsharp-.md)  
  
 A function to apply to each pair of elements from the input sequences.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Type: [seq](../vs140/collections.seq--t--type-abbreviation--fsharp-.md)<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 The first input sequence.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Type: [seq](../vs140/collections.seq--t--type-abbreviation--fsharp-.md)<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 The second input sequence.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|\<xref:System.ArgumentNullException*>|Thrown when either of the input sequences is null.|  
  
## Remarks  
 This function is named <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.  
  
## Example  
 The following code shows how to use <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and compares its behavior to related functions.  
  
 [!code[FsSequences#43](../vs140/codesnippet/FSharp/seq.iter2--t1--t2--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **Seq.iter: element is 1**  
**Seq.iter: element is 2**  
**Seq.iter: element is 3**  
**Seq.iteri: element 0 is 1**  
**Seq.iteri: element 1 is 2**  
**Seq.iteri: element 2 is 3**  
**Seq.iter2: elements are 1 4**  
**Seq.iter2: elements are 2 5**  
**Seq.iter2: elements are 3 6**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Seq Module (F#)](../vs140/collections.seq-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)