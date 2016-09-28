---
title: "Seq.append&lt;&#39;T&gt; Function (F#)"
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
  - "Seq.append<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.SeqModule.Append``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Seq.append function [F#]"
  - "append function [F#]"
ms.assetid: 6f26b7ad-02bb-438c-be0a-8cf46084f138
caps.latest.revision: 24
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Seq.append&lt;&#39;T&gt; Function (F#)
Wraps the two given enumerations as a single concatenated enumeration.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Seq  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Seq.append : seq<'T> -> seq<'T> -> seq<'T>  
  
// Usage:  
Seq.append source1 source2  
```  
  
#### Parameters  
 `source1`  
 Type: [seq](../vs140/collections.seq--t--type-abbreviation--fsharp-.md)`<'T>`  
  
 The first sequence.  
  
 `source2`  
 Type: [seq](../vs140/collections.seq--t--type-abbreviation--fsharp-.md)`<'T>`  
  
 The second sequence.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|<xref:System.ArgumentNullException*>|Thrown when either of the two provided sequences is null.|  
  
## Return Value  
 The result sequence.  
  
## Remarks  
 The returned sequence may be passed between threads safely. However, individual <xref:System.Collections.Generic.IEnumerator`1*> values generated from the returned sequence should not be accessed concurrently.  
  
 This function is named `Append` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following example hows how to use Seq.append.  
  
 [!code[FsSequences#25](../vs140/codesnippet/FSharp/seq.append--t--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **seq [1; 2; 3; 4; ...]**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Seq Module (F#)](../vs140/collections.seq-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)