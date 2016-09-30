---
title: "Seq.delay&lt;&#39;T&gt; Function (F#)"
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
  - "Seq.delay<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.SeqModule.Delay``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "delay function [F#]"
  - "Seq.delay function [F#]"
ms.assetid: 984c6349-4970-4945-9443-43fc1a3a46e5
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Seq.delay&lt;&#39;T&gt; Function (F#)
Returns a sequence that is built from the given delayed specification of a sequence.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.Seq  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: [unit](../vs140/core.unit-type-abbreviation--fsharp-.md) <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> [seq](../vs140/collections.seq--t--type-abbreviation--fsharp-.md)<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
 The generating function for the sequence.  
  
## Return Value  
 The resulting sequence.  
  
## Remarks  
 The input function is evaluated each time an <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> for the sequence is requested.  
  
 This function is named <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code shows how to use <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to delay the evaluation of a sequence that is created from a collection that is normally evaluated immediately.  
  
 [!code[FsSequences#30](../vs140/codesnippet/FSharp/seq.delay--t--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **Calling makeSequence.**  
**Printing sequences.**  
**Squares:**  
**Evaluating 4.**  
**Evaluating 3.**  
**Evaluating 2.**  
**Evaluating 1.**  
**Evaluating 0.16 9 4 1 Cubes:Evaluating 4.**  
**Evaluating 3.**  
**Evaluating 2.**  
**Evaluating 1.**  
**Evaluating 0.**  
**64 27 8 1**   
## Example  
 The following code example is equivalent to the previous example, except that it does not use <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. Notice the difference in the output.  
  
 [!code[FsSequences#31](../vs140/codesnippet/FSharp/seq.delay--t--function--fsharp-_2.fs)]  
  
 **Output**  
  
 **Calling makeSequence.**  
**Evaluating 4.**  
**Evaluating 3.**  
**Evaluating 2.**  
**Evaluating 1.**  
**Evaluating 0.**  
**Evaluating 4.**  
**Evaluating 3.**  
**Evaluating 2.**  
**Evaluating 1.**  
**Evaluating 0.**  
**Printing sequences.**  
**Squares:**  
**16 9 4 1**   
**Cubes:**  
**64 27 8 1**    
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Seq Module (F#)](../vs140/collections.seq-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)