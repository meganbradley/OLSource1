---
title: "Seq.isEmpty&lt;&#39;T&gt; Function (F#)"
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
  - "Seq.isEmpty<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.SeqModule.IsEmpty``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Seq.isEmpty function [F#]"
  - "isEmpty function [F#]"
ms.assetid: 3ff78afc-d065-489c-b580-a6dd4b8deb23
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Seq.isEmpty&lt;&#39;T&gt; Function (F#)
Tests whether a sequence has any elements.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Seq  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Seq.isEmpty : seq<'T> -> bool  
  
// Usage:  
Seq.isEmpty source  
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
 `true` if the input sequence is empty. Otherwise, returns `false`.  
  
## Remarks  
 The first element of the `source` sequence, if there is one, is evaluated on each call. To avoid this, you can create a cached sequence by using [Seq.cache](../vs140/seq.cache--t--function--fsharp-.md).  
  
 This function is named `IsEmpty` in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.  
  
## Example  
 The following code shows how to use Seq.isEmpty.  
  
 [!code[FsSequences#42](../vs140/codesnippet/FSharp/seq.isempty--t--function--fsharp-_1.fs)]  
  
 Output  
  
 **true**  
**false**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Seq Module (F#)](../vs140/collections.seq-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)