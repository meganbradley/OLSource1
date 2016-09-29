---
title: "LanguagePrimitives.DivideByIntDynamic&lt;&#39;T&gt; Function (F#)"
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
  - "Microsoft.FSharp.Core.LanguagePrimitives.DivideByIntDynamic``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "DivideByIntDynamic function [F#]"
ms.assetid: 32d5d11f-0742-4a96-a76a-6a373e8ab92c
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# LanguagePrimitives.DivideByIntDynamic&lt;&#39;T&gt; Function (F#)
A compiler intrinsic that implements dynamic invocations for the [DivideByInt](../VS_csharp/languageprimitives.dividebyint-^t--function--fsharp-.md) primitive.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.LanguagePrimitives  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
DivideByIntDynamic : 'T -> int -> 'T  
  
// Usage:  
DivideByIntDynamic x y  
```  
  
#### Parameters  
 `x`  
 Type: `'T`  
  
 The dividend, or numerator.  
  
 `y`  
 Type: [int](../VS_csharp/core.int-type-abbreviation--fsharp-.md)  
  
 The divisor, or denominator.  
  
## Return Value  
 The quotient.  
  
## Remarks  
 This function is for use by compiled F# code and should not be used directly.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.LanguagePrimitives Module (F#)](../VS_csharp/core.languageprimitives-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../VS_csharp/microsoft.fsharp.core-namespace--fsharp-.md)