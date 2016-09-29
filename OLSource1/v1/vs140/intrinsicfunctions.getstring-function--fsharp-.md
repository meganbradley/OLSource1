---
title: "IntrinsicFunctions.GetString Function (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
apiname: 
  - "IntrinsicFunctions.GetString"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.LanguagePrimitives.IntrinsicFunctions.GetString"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "IntrinsicFunctions.GetString function [F#]"
  - "GetString function [F#]"
ms.assetid: 745ac5ac-c4fe-4009-9bac-90b8d41117ae
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IntrinsicFunctions.GetString Function (F#)
Primitive used by pattern match compilation.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.LanguagePrimitives.IntrinsicFunctions  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
GetString : string -> int -> char  
  
// Usage:  
GetString source index  
```  
  
#### Parameters  
 `source`  
 Type: [string](../vs140/core.string-type-abbreviation--fsharp-.md)  
  
 The source string.  
  
 `index`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The index into the string.  
  
## Return Value  
 The character at the specified index.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [LanguagePrimitives.IntrinsicFunctions Module (F#)](../vs140/languageprimitives.intrinsicfunctions-module--fsharp-.md)   
 [Microsoft.FSharp.Core.LanguagePrimitives Namespace (F#)](../vs140/core.languageprimitives-module--fsharp-.md)