---
title: "IntrinsicFunctions.TypeTestGeneric&lt;&#39;T&gt; Function (F#)"
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
  - "Microsoft.FSharp.Core.LanguagePrimitives.IntrinsicFunctions.TypeTestGeneric"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "TypeTestGeneric function [F#]"
ms.assetid: b1428f64-90cf-44f2-ad44-d88c7c8d3c4c
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IntrinsicFunctions.TypeTestGeneric&lt;&#39;T&gt; Function (F#)
A compiler intrinsic that implements the `:?` operator.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Core.LanguagePrimitives.IntrinsicFunctions  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
TypeTestGeneric : obj -> bool  
  
// Usage:  
TypeTestGeneric source  
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