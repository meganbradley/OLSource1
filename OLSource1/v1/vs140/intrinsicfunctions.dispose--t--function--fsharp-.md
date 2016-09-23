---
title: "IntrinsicFunctions.Dispose&lt;&#39;T&gt; Function (F#)"
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
  - Microsoft.FSharp.Core.LanguagePrimitives.IntrinsicFunctions.Dispose
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - Dispose function [F#]
ms.assetid: dd267de8-2699-440b-afe9-a2bda5986e91
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IntrinsicFunctions.Dispose&lt;&#39;T&gt; Function (F#)
A compiler intrinsic for the efficient compilation of sequence expressions.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.LanguagePrimitives.IntrinsicFunctions  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Dispose : 'T -> unit (requires 'T :> IDisposable)  
  
// Usage:  
Dispose resource  
```  
  
#### Parameters  
 `resource`  
 Type: `'T`  
  
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