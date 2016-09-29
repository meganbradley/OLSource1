---
title: "BigInteger.DivRem Method (F#)"
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
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "DivRem method [F#]"
ms.assetid: e21e83de-d515-4c1b-9dca-f74b6ddcfc84
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# BigInteger.DivRem Method (F#)
Compute the ratio and remainder of two big integers  
  
 **Namespace/Module Path**: System.Numerics  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member DivRem : BigInteger * BigInteger * byref<BigInteger> -> BigInteger  
  
// Usage:  
BigInteger.DivRem (x, y, rem)  
```  
  
#### Parameters  
 `x`  
 Type: [BigInteger](../vs140/numerics.biginteger-structure--fsharp-.md)  
  
 `y`  
 Type: [BigInteger](../vs140/numerics.biginteger-structure--fsharp-.md)  
  
 `rem`  
 Type: [byref](../vs140/core.byref--t--type--fsharp-.md)`<`[BigInteger](../vs140/numerics.biginteger-structure--fsharp-.md)`>`  
  
## Return Value  
  
## Remarks  
 This API is provided for use only with the F# Core Library Versions that targets .NET Framework 2.0. If you are using .NET Framework 4, use the .NET Framework 4 API with the same name, <xref:System.Numerics.BigInteger.DivRem*>.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0  
  
## See Also  
 [Numerics.BigInteger Structure (F#)](../vs140/numerics.biginteger-structure--fsharp-.md)   
 [System.Numerics Namespace (F#)](../vs140/system.numerics-namespace--fsharp-.md)