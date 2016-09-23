---
title: "Seq.min&lt;&#39;T&gt; Function (F#)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-fsharp
ms.tgt_pltfrm: na
ms.topic: reference
apiname: 
  - Seq.min<'T>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Collections.SeqModule.Min``1
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - Seq.min function [F#]
  - min function [F#]
ms.assetid: f4e4d078-3174-4505-a62d-b779d6f12d49
caps.latest.revision: 19
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Seq.min&lt;&#39;T&gt; Function (F#)
Returns the lowest of all elements of the sequence, compared by using [Operators.min](../vs140/operators.min--t--function--fsharp-.md).  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Seq  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Seq.min : seq<'T> -> 'T (requires comparison)  
  
// Usage:  
Seq.min source  
```  
  
#### Parameters  
 `source`  
 Type: [seq](../vs140/collections.seq--t--type-abbreviation--fsharp-.md)`<'T>`  
  
 The input sequence.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|<xref:System.ArgumentException?qualifyHint=False>|Thrown when the input sequence is empty.|  
|<xref:System.ArgumentNullException?qualifyHint=False>|Thrown when the input sequence is null.|  
  
## Return Value  
 The result sequence.  
  
## Remarks  
 This function is named `Min` in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Seq Module (F#)](../vs140/collections.seq-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)