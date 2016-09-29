---
title: "HashCompare.LimitedGenericHashIntrinsic&lt;&#39;T&gt; Function (F#)"
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
  - "Microsoft.FSharp.Core.LanguagePrimitives.HashCompare.LimitedGenericHashIntrinsic``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "LimitedGenericHashIntrinsic function [F#]"
ms.assetid: 79af2883-9092-4330-bfef-bdbdd10a60c0
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# HashCompare.LimitedGenericHashIntrinsic&lt;&#39;T&gt; Function (F#)
A primitive entry point used by the F# compiler for optimization purposes.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.LanguagePrimitives.HashCompare  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
LimitedGenericHashIntrinsic : int -> 'T -> int  
  
// Usage:  
LimitedGenericHashIntrinsic limit input  
```  
  
#### Parameters  
 `limit`  
 Type: [int](../VS_csharp/core.int-type-abbreviation--fsharp-.md)  
  
 The maximum number of elements to use for hashing.  
  
 `input`  
 Type: `'T`  
  
 The object for which to generate a hash.  
  
## Return Value  
 The hashed value.  
  
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