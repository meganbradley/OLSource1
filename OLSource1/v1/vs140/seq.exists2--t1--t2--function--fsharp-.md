---
title: "Seq.exists2&lt;&#39;T1,&#39;T2&gt; Function (F#)"
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
  - "Seq.exists2<'T1,'T2>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.SeqModule.Exists2``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Seq.exists2 function [F#]"
  - "exists2 function [F#]"
ms.assetid: efdf14a4-27f7-4dc1-9281-52639e66d565
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Seq.exists2&lt;&#39;T1,&#39;T2&gt; Function (F#)
Tests if any pair of corresponding elements of the input sequences satisfies the given predicate.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Seq  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>[bool](../vs140/core.bool-type-abbreviation--fsharp-.md)  
  
 A function to test each pair of items from the input sequences.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Type: [seq](../vs140/collections.seq--t--type-abbreviation--fsharp-.md)<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 The first input sequence.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Type: [seq](../vs140/collections.seq--t--type-abbreviation--fsharp-.md)<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 The second input sequence.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|\<xref:System.ArgumentNullException*>|Thrown when either of the two input sequences is null.|  
  
## Return Value  
 The predicate is applied to matching elements in the two sequences up to the lesser of the two lengths of the collections. If any application returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> then the overall result is <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and no further elements are tested. Otherwise, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is returned.  
  
## Remarks  
 If one sequence is shorter than the other then the remaining elements of the longer sequence are ignored.  
  
 This function is named <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code example shows how to use <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 [!code[FsSequences#34](../vs140/codesnippet/FSharp/seq.exists2--t1--t2--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **Sequences seq [1; 2; 3; 4; ...] and seq [5; 4; 3; 2; ...] have at least one equal element at the same position.**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Seq Module (F#)](../vs140/collections.seq-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)