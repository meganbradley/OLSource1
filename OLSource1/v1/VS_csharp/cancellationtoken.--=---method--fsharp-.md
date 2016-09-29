---
title: "CancellationToken.( = ) Method (F#)"
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
  - "CancellationToken.( == )"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "System.Threading.CancellationToken.op_EqualsEquals"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "CancellationToken.op_EqualsEquals operator [F#]"
  - "CancellationToken.( == ) operator [F#]"
  - "op_EqualsEquals operator [F#]"
  - "== operator [F#]"
ms.assetid: 224f2bb1-9365-45c1-b50b-c8957f33fa7a
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CancellationToken.( = ) Method (F#)
Equality operator for tokens.  
  
 **Namespace/Module Path**: System.Threading  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member ( = ) : CancellationToken * CancellationToken -> bool  
  
// Usage:  
token1 = token2  
```  
  
#### Parameters  
 `token1`  
 Type: [CancellationToken](../VS_csharp/threading.cancellationtoken-structure--fsharp-.md)  
  
 `token2`  
 Type: [CancellationToken](../VS_csharp/threading.cancellationtoken-structure--fsharp-.md)  
  
## Return Value  
 True if the two tokens are equal.  
  
## Remarks  
 This API is provided for use only with the F# Core Library Versions that targets .NET Framework 2.0. If you are using .NET Framework 4, use the .NET Framework 4 API with the same name, <xref:System.Threading.CancellationToken.op_Equality*>.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0  
  
## See Also  
 [Threading.CancellationToken Structure (F#)](../VS_csharp/threading.cancellationtoken-structure--fsharp-.md)   
 [System.Threading Namespace (F#)](../VS_csharp/system.threading-namespace--fsharp-.md)