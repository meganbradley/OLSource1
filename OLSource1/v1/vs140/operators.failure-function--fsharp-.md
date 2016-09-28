---
title: "Operators.Failure Function (F#)"
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
  - "Operators.Failure"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.Operators.Failure"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Failure function [F#]"
  - "Operators.Failure function [F#]"
ms.assetid: 202c0c4c-5786-4cba-9276-f12c5945779d
caps.latest.revision: 22
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Operators.Failure Function (F#)
Creates a <xref:System.Exception*> object.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Operators  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Failure : string -> exn  
  
// Usage:  
Failure message  
```  
  
#### Parameters  
 `message`  
 Type: [string](../vs140/core.string-type-abbreviation--fsharp-.md)  
  
 The message for the Exception.  
  
## Return Value  
 A new <xref:System.Exception*> object.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.Operators Module (F#)](../vs140/core.operators-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)