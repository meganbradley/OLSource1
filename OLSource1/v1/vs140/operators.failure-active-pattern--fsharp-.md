---
title: "Operators.Failure Active Pattern (F#)"
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
  - "Operators.( |Failure|_| )"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.Operators.FailurePattern"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Failureactive pattern [F#]"
ms.assetid: 22287ccd-b1f4-4136-aaef-2700277219f9
caps.latest.revision: 23
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Operators.Failure Active Pattern (F#)
Matches <xref:System.Exception*> objects whose runtime type is precisely <xref:System.Exception*>`.`  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Operators  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
( |Failure|_| ) : exn -> string option  
```  
  
#### Parameters  
 `error`  
 Type: [exn](../vs140/core.exn-type-abbreviation--fsharp-.md)  
  
 The input exception.  
  
## Return Value  
 A string option.  
  
## Remarks  
 This function is named `FailurePattern` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.Operators Module (F#)](../vs140/core.operators-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)