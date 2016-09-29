---
title: "Operators.unbox&lt;&#39;T&gt; Function (F#)"
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
  - "Operators.unbox<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.Operators.Unbox``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Operators.Unbox function [F#]"
  - "Operators.unbox function [F#]"
  - "unbox function [F#]"
ms.assetid: 7b320e53-f295-4097-bf77-893c7e4f0a0d
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Operators.unbox&lt;&#39;T&gt; Function (F#)
Unboxes a strongly typed value. This is the inverse of `box`, unbox<t\>(box<t\> a) equals a.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Operators  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
unbox : obj -> 'T  
  
// Usage:  
unbox value  
```  
  
#### Parameters  
 `value`  
 Type: [obj](../VS_csharp/core.obj-type-abbreviation--fsharp-.md)  
  
 The boxed value.  
  
## Return Value  
 The unboxed result.  
  
## Remarks  
 This function is named `Unbox` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.Operators Module (F#)](../VS_csharp/core.operators-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../VS_csharp/microsoft.fsharp.core-namespace--fsharp-.md)