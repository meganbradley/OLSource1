---
title: "LanguagePrimitives.IntrinsicFunctions Module (F#)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-fsharp
ms.tgt_pltfrm: na
ms.topic: reference
apiname: 
  - LanguagePrimitives.IntrinsicFunctions
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Core.LanguagePrimitives.IntrinsicFunctions
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - IntrinsicFunctions module [F#]
ms.assetid: 1700df47-c8f8-4231-bc57-d7f18dcb14ac
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
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
|[CheckThis](../vs140/intrinsicfunctions.checkthis--t--function--fsharp-.md)|A compiler intrinsic for checking initialization soundness of recursive bindings|  
|[CreateInstance](../vs140/intrinsicfunctions.createinstance--t--function--fsharp-.md)|This function implements calls to default constructors acccessed by 'new' constraints.|  
|[Dispose](../vs140/intrinsicfunctions.dispose--t--function--fsharp-.md)|A compiler intrinsic for the efficient compilation of sequence expressions|  
|[FailInit](../vs140/intrinsicfunctions.failinit-function--fsharp-.md)|A compiler intrinsic for checking initialization soundness of recursive bindings|  
|[FailStaticInit](../vs140/intrinsicfunctions.failstaticinit-function--fsharp-.md)|A compiler intrinsic for checking initialization soundness of recursive static bindings|  
|[GetArray](../vs140/intrinsicfunctions.getarray--t--function--fsharp-.md)|The standard overloaded associative (indexed) lookup operator|  
|[GetArray2D](../vs140/intrinsicfunctions.getarray2d--t--function--fsharp-.md)|The standard overloaded associative (2-indexed) lookup operator|  
|[GetArray3D](../vs140/intrinsicfunctions.getarray3d--t--function--fsharp-.md)|The standard overloaded associative (3-indexed) lookup operator|  
|[GetArray4D](../vs140/intrinsicfunctions.getarray4d--t--function--fsharp-.md)|The standard overloaded associative (4-indexed) lookup operator|  
|[GetString](../vs140/intrinsicfunctions.getstring-function--fsharp-.md)|Primitive used by pattern match compilation|  
|[MakeDecimal](../vs140/intrinsicfunctions.makedecimal-function--fsharp-.md)|This function implements parsing of decimal constants|  
|[SetArray](../vs140/intrinsicfunctions.setarray--t--function--fsharp-.md)|The standard overloaded associative (indexed) mutation operator|  
|[SetArray2D](../vs140/intrinsicfunctions.setarray2d--t--function--fsharp-.md)|The standard overloaded associative (2-indexed) mutation operator|  
|[SetArray3D](../vs140/intrinsicfunctions.setarray3d--t--function--fsharp-.md)|The standard overloaded associative (3-indexed) mutation operator|  
|[SetArray4D](../vs140/intrinsicfunctions.setarray4d--t--function--fsharp-.md)|The standard overloaded associative (4-indexed) mutation operator|  
|[TypeTestFast](../vs140/intrinsicfunctions.typetestfast--t--function--fsharp-.md)|A compiler intrinsic that implements the ':?' operator|  
|[TypeTestGeneric](../vs140/intrinsicfunctions.typetestgeneric--t--function--fsharp-.md)|A compiler intrinsic that implements the ':?' operator|  
|[UnboxFast](../vs140/intrinsicfunctions.unboxfast--t--function--fsharp-.md)|A compiler intrinsic that implements the ':?>' operator|  
|[UnboxGeneric](../vs140/intrinsicfunctions.unboxgeneric--t--function--fsharp-.md)|A compiler intrinsic that implements the ':?>' operator|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core.LanguagePrimitives Namespace (F#)](../vs140/core.languageprimitives-module--fsharp-.md)