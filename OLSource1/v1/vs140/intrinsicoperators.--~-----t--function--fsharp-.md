---
title: "IntrinsicOperators.( ~&amp; )&lt;&#39;T&gt; Function (F#)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-fsharp
ms.tgt_pltfrm: na
ms.topic: reference
apiname: 
  - IntrinsicOperators.( ~&amp; )<'T>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Core.LanguagePrimitives.IntrinsicOperators.op_AddressOf``1
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - IntrinsicOperators.op_AddressOf operator [F#]
  - IntrinsicOperators.( ~& ) operator [F#]
  - op_AddressOf operator [F#]
  - ~& operator [F#]
ms.assetid: 2a980a73-cb52-41c9-bbfa-096930fc12e8
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IntrinsicOperators.( ~&amp; )&lt;&#39;T&gt; Function (F#)
Returns the address of the argument. Uses of this value may result in the generation of unverifiable code.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.LanguagePrimitives.IntrinsicOperators  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
( ~& ) : 'T -> byref<'T>  
  
// Usage:  
& obj  
```  
  
#### Parameters  
 `obj`  
 Type: `'T`  
  
 The input object.  
  
## Return Value  
 The managed pointer.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [LanguagePrimitives.IntrinsicOperators Module (F#)](../vs140/languageprimitives.intrinsicoperators-module--fsharp-.md)   
 [Microsoft.FSharp.Core.LanguagePrimitives Namespace (F#)](../vs140/core.languageprimitives-module--fsharp-.md)