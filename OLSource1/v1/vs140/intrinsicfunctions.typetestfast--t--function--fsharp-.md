---
title: "IntrinsicFunctions.TypeTestFast&lt;&#39;T&gt; Function (F#)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-fsharp
ms.tgt_pltfrm: na
ms.topic: reference
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Core.LanguagePrimitives.IntrinsicFunctions.TypeTestFast
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - TypeTestFast function [F#]
ms.assetid: e04d5e7e-4133-48bb-82ff-9fc184b72688
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IntrinsicFunctions.TypeTestFast&lt;&#39;T&gt; Function (F#)
A compiler intrinsic that implements the `:?` operator  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.LanguagePrimitives.IntrinsicFunctions  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
TypeTestFast : obj -> bool  
  
// Usage:  
TypeTestFast source  
```  
  
#### Parameters  
 `source`  
 Type: [obj](../vs140/core.obj-type-abbreviation--fsharp-.md)  
  
 The object to test.  
  
## Return Value  
 `true` if the type matches the specified type; otherwise `false`.  
  
## Remarks  
 This function is for use by compiled F# code and should not be used directly.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [LanguagePrimitives.IntrinsicFunctions Module (F#)](../vs140/languageprimitives.intrinsicfunctions-module--fsharp-.md)   
 [Microsoft.FSharp.Core.LanguagePrimitives Namespace (F#)](../vs140/core.languageprimitives-module--fsharp-.md)