---
title: "IntrinsicFunctions.CheckThis&lt;&#39;T&gt; Function (F#)"
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
  - "Microsoft.FSharp.Core.LanguagePrimitives.IntrinsicFunctions.CheckThis"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "CheckThis function [F#]"
ms.assetid: 3f696af0-f912-48fb-8122-51e306e074c2
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IntrinsicFunctions.CheckThis&lt;&#39;T&gt; Function (F#)
A compiler intrinsic for checking initialization soundness of recursive bindings.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.LanguagePrimitives.IntrinsicFunctions  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
CheckThis : 'T -> 'T (requires reference type)  
  
// Usage:  
CheckThis   
```  
  
#### Parameters  
 Type: `'T`  
  
## Return Value  
  
## Remarks  
 This function is for use by compiled F# code and should not be used directly.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [LanguagePrimitives.IntrinsicFunctions Module (F#)](../VS_csharp/languageprimitives.intrinsicfunctions-module--fsharp-.md)   
 [Microsoft.FSharp.Core.LanguagePrimitives Namespace (F#)](../VS_csharp/core.languageprimitives-module--fsharp-.md)