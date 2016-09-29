---
title: "FSharpType.GetExceptionFields Method (F#)"
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
  - "FSharpType.GetExceptionFields"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Reflection.FSharpType.GetExceptionFields"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "FSharpType.GetExceptionFields method [F#]"
  - "GetExceptionFields method [F#]"
ms.assetid: 7fb355e6-b345-4c7d-bea0-9af302f60148
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# FSharpType.GetExceptionFields Method (F#)
Reads all the fields from an F# exception declaration, in declaration order.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Reflection  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member GetExceptionFields : Type * ?BindingFlags -> PropertyInfo []  
static member GetExceptionFields : Type * ?bool -> PropertyInfo []  
  
// Usage:  
FSharpType.GetExceptionFields (exceptionType)  
FSharpType.GetExceptionFields (exceptionType, bindingFlags = bindingFlags)  
  
open FSharpReflectionExtensions  
FSharpType.GetExceptionFields (exceptionType, allowAccessToPrivateRepresentation = false)  
```  
  
#### Parameters  
 `exceptionType`  
 Type: <xref:System.Type*>  
  
 The exception type to read.  
  
 `bindingFlags`  
 Type: <xref:System.Reflection.BindingFlags*>  
  
 Optional binding flags.  
  
 `allowAccessToPrivateRepresentation`  
 Type: [bool](../VS_csharp/core.bool-type-abbreviation--fsharp-.md)  
  
 Optional flag that denotes accessibility of the private representation.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|<xref:System.ArgumentException*>|Thrown if the given type is not an exception.|  
  
## Return Value  
 An array containing the <xref:System.Reflection.PropertyInfo*> of each field in the exception.  
  
## Remarks  
 Assumes `exceptionType` is an exception representation type. If not, <xref:System.ArgumentException*> is raised.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Reflection.FSharpType Class (F#)](../VS_csharp/reflection.fsharptype-class--fsharp-.md)   
 [Microsoft.FSharp.Reflection Namespace (F#)](../VS_csharp/microsoft.fsharp.reflection-namespace--fsharp-.md)