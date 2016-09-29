---
title: "HashCompare.FastHashTuple3&lt;&#39;T1,&#39;T2,&#39;T3&gt; Function (F#)"
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
  - "Microsoft.FSharp.Core.LanguagePrimitives.HashCompare.FastHashTuple3``3"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "FastHashTuple3 function [F#]"
ms.assetid: 490a9280-410a-4d79-b455-37906b0c29b9
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# HashCompare.FastHashTuple3&lt;&#39;T1,&#39;T2,&#39;T3&gt; Function (F#)
A primitive entry point used by the F# compiler for optimization purposes.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.LanguagePrimitives.HashCompare  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
FastHashTuple3 : IEqualityComparer -> 'T1 * 'T2 * 'T3 -> int  
  
// Usage:  
FastHashTuple3 comparer tuple  
```  
  
#### Parameters  
 `comparer`  
 Type: <xref:System.Collections.IEqualityComparer*>  
  
 The comparer object.  
  
 `tuple`  
 Type: `'T1 * 'T2 * 'T3`  
  
 A tuple of three elements.  
  
## Return Value  
 The computed hash.  
  
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