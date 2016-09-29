---
title: "Operators.ignore&lt;&#39;T&gt; Function (F#)"
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
  - "Operators.ignore<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.Operators.Ignore``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Operators.ignore function [F#]"
  - "ignore function [F#]"
ms.assetid: 7b42722c-525d-4352-995d-20400234aa99
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Operators.ignore&lt;&#39;T&gt; Function (F#)
Ignore the passed value. This is often used to throw away results of a computation.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Operators  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
ignore : 'T -> unit  
  
// Usage:  
ignore value  
```  
  
#### Parameters  
 `value`  
 Type: `'T`  
  
 The value to ignore.  
  
## Remarks  
 This function is named `Ignore` in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.Operators Module (F#)](../VS_csharp/core.operators-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../VS_csharp/microsoft.fsharp.core-namespace--fsharp-.md)