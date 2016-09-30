---
title: "Seq.windowed&lt;&#39;T&gt; Function (F#)"
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
  - "Seq.windowed<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.SeqModule.Windowed``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "windowed function [F#]"
  - "Seq.windowed function [F#]"
ms.assetid: 8b565b8f-d645-4dba-be22-099075fe4744
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Seq.windowed&lt;&#39;T&gt; Function (F#)
Returns a sequence that yields sliding windows of containing elements drawn from the input sequence. Each window is returned as a fresh array.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Seq  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The number of elements in each window.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Type: [seq](../vs140/collections.seq--t--type-abbreviation--fsharp-.md)<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
 The input sequence.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|\<xref:System.ArgumentException*>|Thrown when the input sequence is empty.|  
|\<xref:System.ArgumentNullException*>|Thrown when the input sequence is null.|  
  
## Return Value  
 The result sequence.  
  
## Remarks  
 This function is named <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following example demonstrates the use of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> as part of a computation of a moving average for a sequence of numbers.  
  
 [!code[FsSequences#180](../vs140/codesnippet/FSharp/seq.windowed--t--function--fsharp-_1.fs)]  
  
 **Initial sequence:**   
**1.0 1.5 2.0 1.5 1.0 1.5**   
**Windows of length 3:**   
**[&#124;1.0; 1.5; 2.0&#124;] [&#124;1.5; 2.0; 1.5&#124;] [&#124;2.0; 1.5; 1.0&#124;] [&#124;1.5; 1.0; 1.5&#124;]**   
**Moving average:**   
**1.5 1.666666667 1.5 1.333333333**    
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Seq Module (F#)](../vs140/collections.seq-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)