---
title: "Seq.exists&lt;&#39;T&gt; Function (F#)"
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
  - "Seq.exists<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.SeqModule.Exists``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Seq.exists function [F#]"
  - "exists function [F#]"
ms.assetid: 428c97bf-599d-4c39-a5b9-f8717c198ad1
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Seq.exists&lt;&#39;T&gt; Function (F#)
Tests if any element of the sequence satisfies the given predicate.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.Seq  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Seq.exists : ('T -> bool) -> seq<'T> -> bool  
  
// Usage:  
Seq.exists predicate source  
```  
  
#### Parameters  
 `predicate`  
 Type: `'T ->`[bool](../vs140/core.bool-type-abbreviation--fsharp-.md)  
  
 A function to test each item of the input sequence.  
  
 `source`  
 Type: [seq](../vs140/collections.seq--t--type-abbreviation--fsharp-.md)`<'T>`  
  
 The input sequence.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|<xref:System.ArgumentNullException*>|Thrown when the input sequence is null.|  
  
## Return Value  
 The predicate is applied to the elements of the input sequence. If any application returns `true` then the overall result is `true` and no further elements are tested. Otherwise, returns `false`.  
  
## Remarks  
 This function is named `Exists` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code shows how to use `Seq.exists`.  
  
 [!code[FsSequences#33](../vs140/codesnippet/FSharp/seq.exists--t--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **For sequence seq [0; 1; 2; 3], contains zero is true**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Seq Module (F#)](../vs140/collections.seq-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)