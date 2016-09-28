---
title: "Seq.distinct&lt;&#39;T&gt; Function (F#)"
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
  - "Seq.distinct<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.SeqModule.Distinct``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Seq.distinct function [F#]"
  - "distinct function [F#]"
ms.assetid: 99d01014-7e0e-4e7b-9d0a-41a61d93f401
caps.latest.revision: 21
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Seq.distinct&lt;&#39;T&gt; Function (F#)
Returns a sequence that contains no duplicate entries according to generic hash and equality comparisons on the entries. If an element occurs multiple times in the sequence then the later occurrences are discarded.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Seq  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Seq.distinct : seq<'T> -> seq<'T> (requires equality)  
  
// Usage:  
Seq.distinct source  
```  
  
#### Parameters  
 `source`  
 Type: [seq](../vs140/collections.seq--t--type-abbreviation--fsharp-.md)`<'T>`  
  
 The input sequence.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|<xref:System.ArgumentNullException*>|Thrown when the input sequence is null.|  
  
## Return Value  
 The result sequence.  
  
## Remarks  
 This function is named `Distinct` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following example demonstrates the use of `Seq.distinct`. The example generates the binary representation of a number as a sequence. It then determines that the only unique numbers are 0 and 1.  
  
 [!code[FsSequences#22](../vs140/codesnippet/FSharp/seq.distinct--t--function--fsharp-_1.fs)]  
  
 **[1; 0; 0; 0; 0; 0; 0; 0; 0; 0; 0]**  
**seq [1; 0]**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Seq Module (F#)](../vs140/collections.seq-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)