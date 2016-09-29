---
title: "HashCompare.GenericLessThanIntrinsic&lt;&#39;T&gt; Function (F#)"
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
  - "Microsoft.FSharp.Core.LanguagePrimitives.HashCompare.GenericLessThanIntrinsic``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "GenericLessThanIntrinsic function [F#]"
ms.assetid: 51d56426-444f-4398-b79f-d1077b1185af
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# HashCompare.GenericLessThanIntrinsic&lt;&#39;T&gt; Function (F#)
A primitive entry point used by the F# compiler for optimization purposes.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.LanguagePrimitives.HashCompare  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
GenericLessThanIntrinsic : 'T -> 'T -> bool  
  
// Usage:  
GenericLessThanIntrinsic x y  
```  
  
#### Parameters  
 `x`  
 Type: `'T`  
  
 The first object to compare.  
  
 `y`  
 Type: `'T`  
  
 The second object to compare.  
  
## Return Value  
 `true` if the first object is less than the second; otherwise, `false`.  
  
## Remarks  
 This function is for use by compiled F# code and should not be used directly.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [LanguagePrimitives.HashCompare Module (F#)](../VS_csharp/languageprimitives.hashcompare-module--fsharp-.md)   
 [Microsoft.FSharp.Core.LanguagePrimitives Namespace (F#)](../VS_csharp/core.languageprimitives-module--fsharp-.md)