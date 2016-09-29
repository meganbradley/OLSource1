---
title: "CustomOperationAttribute.AllowIntoPattern Property (F#)"
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
  - "Microsoft.FSharp.Core.CustomOperationAttribute.AllowIntoPattern"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "CustomOperationAttribute.AllowIntoPattern property [F#]"
ms.assetid: 931ed911-2da0-4a8c-9138-dcce14d0bfdc
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CustomOperationAttribute.AllowIntoPattern Property (F#)
Indicates if the custom operation supports the use of `into` immediately after the use of the operation in a query or other computation expression to consume the results of the operation.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Core  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:member this.AllowIntoPattern : bool with get, set// Usage:customOperationAttribute.AllowIntoPattern  
```  
  
## Property Value  
 `true` if the operation supports the use of `into`.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.CustomOperationAttribute Class (F#)](../VS_csharp/core.customoperationattribute-class--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../VS_csharp/microsoft.fsharp.core-namespace--fsharp-.md)