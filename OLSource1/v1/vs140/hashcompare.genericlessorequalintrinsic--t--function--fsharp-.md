---
title: "HashCompare.GenericLessOrEqualIntrinsic&lt;&#39;T&gt; Function (F#)"
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
  - "Microsoft.FSharp.Core.LanguagePrimitives.HashCompare.GenericLessOrEqualIntrinsic``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "GenericLessOrEqualIntrinsic function [F#]"
ms.assetid: 7a470278-a21e-4a38-ac37-9c84305b1972
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# HashCompare.GenericLessOrEqualIntrinsic&lt;&#39;T&gt; Function (F#)
A primitive entry point used by the F# compiler for optimization purposes.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Core.LanguagePrimitives.HashCompare  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
GenericLessOrEqualIntrinsic : 'T -> 'T -> bool  
  
// Usage:  
GenericLessOrEqualIntrinsic x y  
```  
  
#### Parameters  
 `x`  
 Type: `'T`  
  
 The first object to compare.  
  
 `y`  
 Type: `'T`  
  
 The second object to compare.  
  
## Return Value  
 `true` if the first object is less than or equal to the second; otherwise, `false`.  
  
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