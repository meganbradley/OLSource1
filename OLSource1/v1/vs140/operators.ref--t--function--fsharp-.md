---
title: "Operators.ref&lt;&#39;T&gt; Function (F#)"
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
  - "Operators.ref<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.Operators.Ref``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Operators.ref function [F#]"
  - "ref function [F#]"
ms.assetid: 0785a0a0-8e5d-47cf-bd7a-adb2f4074d73
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Operators.ref&lt;&#39;T&gt; Function (F#)
Create a mutable reference cell.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Operators  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
ref : 'T -> 'T ref  
  
// Usage:  
ref value  
```  
  
#### Parameters  
 `value`  
 Type: `'T`  
  
 The value to contain in the cell.  
  
## Return Value  
 The created reference cell.  
  
## Remarks  
 This function is named `Ref` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.Operators Module (F#)](../vs140/core.operators-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)