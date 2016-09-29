---
title: "LanguagePrimitives.IntrinsicFunctions Module (F#)"
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
  - "LanguagePrimitives.IntrinsicFunctions"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.LanguagePrimitives.IntrinsicFunctions"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "IntrinsicFunctions module [F#]"
ms.assetid: 1700df47-c8f8-4231-bc57-d7f18dcb14ac
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# LanguagePrimitives.IntrinsicFunctions Module (F#)
The F# compiler emits calls to some of the functions in this module as part of the compiled form of some language constructs  
  
 **Namespace/Module Path**: Microsoft.FSharp.Core.LanguagePrimitives  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
module IntrinsicFunctions  
```  
  
## Remarks  
  
## Values  
  
|Value|Description|  
|-----------|-----------------|  
|[CheckThis](../VS_csharp/intrinsicfunctions.checkthis--t--function--fsharp-.md)|A compiler intrinsic for checking initialization soundness of recursive bindings|  
|[CreateInstance](../VS_csharp/intrinsicfunctions.createinstance--t--function--fsharp-.md)|This function implements calls to default constructors acccessed by 'new' constraints.|  
|[Dispose](../VS_csharp/intrinsicfunctions.dispose--t--function--fsharp-.md)|A compiler intrinsic for the efficient compilation of sequence expressions|  
|[FailInit](../VS_csharp/intrinsicfunctions.failinit-function--fsharp-.md)|A compiler intrinsic for checking initialization soundness of recursive bindings|  
|[FailStaticInit](../VS_csharp/intrinsicfunctions.failstaticinit-function--fsharp-.md)|A compiler intrinsic for checking initialization soundness of recursive static bindings|  
|[GetArray](../VS_csharp/intrinsicfunctions.getarray--t--function--fsharp-.md)|The standard overloaded associative (indexed) lookup operator|  
|[GetArray2D](../VS_csharp/intrinsicfunctions.getarray2d--t--function--fsharp-.md)|The standard overloaded associative (2-indexed) lookup operator|  
|[GetArray3D](../VS_csharp/intrinsicfunctions.getarray3d--t--function--fsharp-.md)|The standard overloaded associative (3-indexed) lookup operator|  
|[GetArray4D](../VS_csharp/intrinsicfunctions.getarray4d--t--function--fsharp-.md)|The standard overloaded associative (4-indexed) lookup operator|  
|[GetString](../VS_csharp/intrinsicfunctions.getstring-function--fsharp-.md)|Primitive used by pattern match compilation|  
|[MakeDecimal](../VS_csharp/intrinsicfunctions.makedecimal-function--fsharp-.md)|This function implements parsing of decimal constants|  
|[SetArray](../VS_csharp/intrinsicfunctions.setarray--t--function--fsharp-.md)|The standard overloaded associative (indexed) mutation operator|  
|[SetArray2D](../VS_csharp/intrinsicfunctions.setarray2d--t--function--fsharp-.md)|The standard overloaded associative (2-indexed) mutation operator|  
|[SetArray3D](../VS_csharp/intrinsicfunctions.setarray3d--t--function--fsharp-.md)|The standard overloaded associative (3-indexed) mutation operator|  
|[SetArray4D](../VS_csharp/intrinsicfunctions.setarray4d--t--function--fsharp-.md)|The standard overloaded associative (4-indexed) mutation operator|  
|[TypeTestFast](../VS_csharp/intrinsicfunctions.typetestfast--t--function--fsharp-.md)|A compiler intrinsic that implements the ':?' operator|  
|[TypeTestGeneric](../VS_csharp/intrinsicfunctions.typetestgeneric--t--function--fsharp-.md)|A compiler intrinsic that implements the ':?' operator|  
|[UnboxFast](../VS_csharp/intrinsicfunctions.unboxfast--t--function--fsharp-.md)|A compiler intrinsic that implements the ':?>' operator|  
|[UnboxGeneric](../VS_csharp/intrinsicfunctions.unboxgeneric--t--function--fsharp-.md)|A compiler intrinsic that implements the ':?>' operator|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core.LanguagePrimitives Namespace (F#)](../VS_csharp/core.languageprimitives-module--fsharp-.md)