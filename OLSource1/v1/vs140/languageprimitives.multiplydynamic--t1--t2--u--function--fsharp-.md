---
title: "LanguagePrimitives.MultiplyDynamic&lt;&#39;T1,&#39;T2,&#39;U&gt; Function (F#)"
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
  - "Microsoft.FSharp.Core.LanguagePrimitives.MultiplyDynamic``3"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "MultiplyDynamic function [F#]"
ms.assetid: be75703d-ac9a-4b79-93cb-0a7067f99a4f
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# LanguagePrimitives.MultiplyDynamic&lt;&#39;T1,&#39;T2,&#39;U&gt; Function (F#)
A compiler intrinsic that implements dynamic invocations to the `*` operator.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.LanguagePrimitives  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
MultiplyDynamic : 'T1 -> 'T2 -> 'U  
  
// Usage:  
MultiplyDynamic x y  
```  
  
#### Parameters  
 `x`  
 Type: `'T1`  
  
 The first operand.  
  
 `y`  
 Type: `'T2`  
  
 The second operand.  
  
## Return Value  
 The product of the two operands.  
  
## Remarks  
 This function is for use by compiled F# code and should not be used directly.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.LanguagePrimitives Module (F#)](../vs140/core.languageprimitives-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)