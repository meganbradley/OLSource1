---
title: "ExtraTopLevelOperators.double&lt;^T&gt; Function (F#)"
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
  - "ExtraTopLevelOperators.double<^T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.ExtraTopLevelOperators.ToDouble``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "ExtraTopLevelOperators.double function [F#]"
  - "double function [F#]"
  - "ToDouble function [F#]"
  - "ExtraTopLevelOperators.ToDouble function [F#]"
ms.assetid: 21e147c8-fee0-4d59-9620-cbe832d3fde7
caps.latest.revision: 22
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ExtraTopLevelOperators.double&lt;^T&gt; Function (F#)
Converts the argument to 64-bit float. This is a direct conversion for all primitive numeric types. For strings, the input is converted using [Parse](assetId:///M:System.Double.Parse(System.String)?qualifyHint=False&autoUpgrade=True) with <xref:System.Globalization.CultureInfo.InvariantCulture*> settings. Otherwise the operation requires and invokes a `ToDouble` method on the input type  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.ExtraTopLevelOperators  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
double : ^T -> float (requires ^T with static member op_Explicit)  
  
// Usage:  
double value  
```  
  
#### Parameters  
 `value`  
 Type: `^T`  
  
 The value to convert.  
  
## Return Value  
 The converted value of type [float](../vs140/core.float-type-abbreviation--fsharp-.md).  
  
## Remarks  
 This function is named `ToDouble` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.ExtraTopLevelOperators Module (F#)](../vs140/core.extratopleveloperators-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)