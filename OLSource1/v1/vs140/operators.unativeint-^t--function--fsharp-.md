---
title: "Operators.unativeint&lt;^T&gt; Function (F#)"
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
  - "Operators.unativeint<^T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.Operators.ToUIntPtr``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Operators.ToUIntPtr function [F#]"
  - "unativeint function [F#]"
  - "ToUIntPtr function [F#]"
  - "Operators.unativeint function [F#]"
ms.assetid: 5255e9e6-2837-4d00-ac64-ddb6b9b03bba
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Operators.unativeint&lt;^T&gt; Function (F#)
Converts the argument to unsigned native integer using a direct conversion for all primitive numeric types. Otherwise the operation requires an appropriate static conversion method on the input type.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Operators  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
unativeint : ^T -> unativeint (requires ^T with static member op_Explicit)  
  
// Usage:  
unativeint value  
```  
  
#### Parameters  
 `value`  
 Type: `^T`  
  
 The input value.  
  
## Return Value  
 The converted `unativeint` value.  
  
## Remarks  
 This function is named `ToUIntPtr` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.Operators Module (F#)](../vs140/core.operators-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)