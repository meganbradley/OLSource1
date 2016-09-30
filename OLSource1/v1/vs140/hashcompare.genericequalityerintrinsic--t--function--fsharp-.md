---
title: "HashCompare.GenericEqualityERIntrinsic&lt;&#39;T&gt; Function (F#)"
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
  - "Microsoft.FSharp.Core.LanguagePrimitives.HashCompare.GenericEqualityERIntrinsic``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "GenericEqualityERIntrinsic function [F#]"
ms.assetid: f06a1ad9-5839-4202-bb77-62770a0c1177
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# HashCompare.GenericEqualityERIntrinsic&lt;&#39;T&gt; Function (F#)
A primitive entry point used by the F# compiler for optimization purposes.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.LanguagePrimitives.HashCompare  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
GenericEqualityERIntrinsic : 'T -> 'T -> bool  
  
// Usage:  
GenericEqualityERIntrinsic x y  
```  
  
#### Parameters  
 `x`  
 Type: `'T`  
  
 The first object to compare.  
  
 `y`  
 Type: `'T`  
  
 The second object to compare.  
  
## Return Value  
 The result of the comparison.  
  
## Remarks  
 This function is for use by compiled F# code and should not be used directly.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [LanguagePrimitives.HashCompare Module (F#)](../vs140/languageprimitives.hashcompare-module--fsharp-.md)   
 [Microsoft.FSharp.Core.LanguagePrimitives Namespace (F#)](../vs140/core.languageprimitives-module--fsharp-.md)