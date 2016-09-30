---
title: "Seq.truncate&lt;&#39;T&gt; Function (F#)"
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
  - "Seq.truncate<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.SeqModule.Truncate``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "truncate function [F#]"
  - "Seq.truncate function [F#]"
ms.assetid: 1892dfeb-308e-45e2-857a-3c3405d02244
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Seq.truncate&lt;&#39;T&gt; Function (F#)
Returns a sequence that when enumerated returns at most N elements.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Seq  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The maximum number of items to enumerate.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Type: [seq](../vs140/collections.seq--t--type-abbreviation--fsharp-.md)<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
 The input sequence.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|\<xref:System.ArgumentNullException*>|Thrown when the input sequence is null.|  
  
## Return Value  
 The result sequence.  
  
## Remarks  
 This function is named <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following example demonstrates the use of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and contrasts the behavior with <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 [!code[FsSequences#16](../vs140/codesnippet/FSharp/seq.truncate--t--function--fsharp-_1.fs)]  
  
 **1 4 9 16 25**   
**1 4 9 16 25 36 49 64 81 100**   
**1 4 9 16 25**   
**1 4 9 16 25 36 49 64 81 100**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Seq Module (F#)](../vs140/collections.seq-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)