---
title: "Unchecked.hash&lt;&#39;T&gt; Function (F#)"
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
  - "Unchecked.hash<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.Operators.Unchecked.Hash``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "hash function [F#]"
  - "Unchecked.hash function [F#]"
ms.assetid: b29711ff-269e-474d-9535-3c2c39515a60
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Unchecked.hash&lt;&#39;T&gt; Function (F#)
Perform generic hashing on a value where the type of the value is not statically required to satisfy the equality constraint.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Operators.Unchecked  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
hash : 'T -> int  
  
// Usage:  
hash value  
```  
  
#### Parameters  
 `value`  
 Type: `'T`  
  
 The value to generate a hash for.  
  
## Return Value  
 The computed hash value.  
  
## Remarks  
 This function is named `Hash` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Operators.Unchecked Module (F#)](../vs140/operators.unchecked-module--fsharp-.md)   
 [Microsoft.FSharp.Core.Operators Namespace (F#)](../vs140/core.operators-module--fsharp-.md)