---
title: "Unchecked.unbox&lt;&#39;T&gt; Function (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.Operators.Unchecked.Unbox``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "unbox function [F#]"
ms.assetid: c24a9f99-8562-4dba-8c93-d831ecf94795
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Unchecked.unbox&lt;&#39;T&gt; Function (F#)
Unboxes a strongly typed value. This is the inverse of `box`; therefore, `unbox<t>(box<t> a)` equals `a`.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Core.Operators.Unchecked  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
unbox : obj -> 'T  
  
// Usage:  
unbox   
```  
  
#### Parameters  
 `value`  
 Type: [obj](../vs140/core.obj-type-abbreviation--fsharp-.md)  
  
 The value to unbox.  
  
## Return Value  
 The unboxed result.  
  
## Remarks  
 This function is named `Unbox` in the .NET assembly. If accessing the member from a .NET language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Operators.Unchecked Module (F#)](../vs140/operators.unchecked-module--fsharp-.md)   
 [Microsoft.FSharp.Core.Operators Namespace (F#)](../vs140/core.operators-module--fsharp-.md)   
 [Operators.box<'T> Function (F#)](../vs140/operators.box--t--function--fsharp-.md)