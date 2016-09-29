---
title: "Operators.raise&lt;&#39;T&gt; Function (F#)"
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
  - "Operators.raise<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.Operators.Raise``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "raise function [F#]"
  - "Operators.raise function [F#]"
ms.assetid: 04e33b68-2f21-4d65-bb1e-9a8b2debbe51
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Operators.raise&lt;&#39;T&gt; Function (F#)
Raises an exception.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Operators  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
raise : Exception -> 'T  
  
// Usage:  
raise exn  
```  
  
#### Parameters  
 `exn`  
 Type: <xref:System.Exception*>  
  
 The exception to raise.  
  
## Return Value  
 The result value.  
  
## Remarks  
 This function is named `Raise` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.Operators Module (F#)](../VS_csharp/core.operators-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../VS_csharp/microsoft.fsharp.core-namespace--fsharp-.md)