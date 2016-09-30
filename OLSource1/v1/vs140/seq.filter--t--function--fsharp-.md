---
title: "Seq.filter&lt;&#39;T&gt; Function (F#)"
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
  - "Seq.filter<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.SeqModule.Filter``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "filter function [F#]"
  - "Seq.filter function [F#]"
ms.assetid: 7f2e9850-a660-460c-9831-3bbff5613770
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Seq.filter&lt;&#39;T&gt; Function (F#)
Returns a new collection containing only the elements of the collection for which the given predicate returns <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Seq  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>[bool](../vs140/core.bool-type-abbreviation--fsharp-.md)  
  
 A function to test whether each item in the input sequence should be included in the output.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Type: [seq](../vs140/collections.seq--t--type-abbreviation--fsharp-.md)<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
 The input sequence.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|\<xref:System.ArgumentNullException*>|Thrown when the input sequence is null.|  
  
## Return Value  
 The result sequence.  
  
## Remarks  
 The returned sequence may be passed between threads safely. However, individual <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> values generated from the returned sequence should not be accessed concurrently. The sequence is lazily evaluated. Therefore, effects are delayed until it is enumerated.  
  
 This function is named <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code shows the use of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to filter an infinite sequence of random numbers to select only even numbers.  
  
 [!code[FsSequences#35](../vs140/codesnippet/FSharp/seq.filter--t--function--fsharp-_1.fs)]  
  
 **Sample Output**  
  
 **2140052690 963487404 467169526 1800517368 1225141818**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Seq Module (F#)](../vs140/collections.seq-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)