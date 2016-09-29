---
title: "FSharpType.GetUnionCases Method (F#)"
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
  - "FSharpType.GetUnionCases"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Reflection.FSharpType.GetUnionCases"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "FSharpType.GetUnionCases method [F#]"
  - "GetUnionCases method [F#]"
ms.assetid: a1d0f854-48ac-4e61-a80b-2db11d7d2c1a
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# FSharpType.GetUnionCases Method (F#)
Gets the cases of a union type.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Reflection  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member GetUnionCases : Type * ?BindingFlags -> UnionCaseInfo []  
static member GetUnionCases : Type * ?bool -> UnionCaseInfo []  
  
// Usage:  
FSharpType.GetUnionCases (unionType)  
FSharpType.GetUnionCases (unionType, bindingFlags = bindingFlags)  
  
open FSharpReflectionExtensions  
FSharpType.GetUnionCases (unionType, allowAccessToPrivateRepresentation = false)  
```  
  
#### Parameters  
 `unionType`  
 Type: <xref:System.Type*>  
  
 The input union type.  
  
 `bindingFlags`  
 Type: <xref:System.Reflection.BindingFlags*>  
  
 Optional binding flags.  
  
 `allowAccessToPrivateRepresentation`  
 Type: [bool](../vs140/core.bool-type-abbreviation--fsharp-.md)  
  
 Optional flag that denotes accessibility of the private representation.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|<xref:System.ArgumentException*>|Thrown when the input type is not a union type.|  
  
## Return Value  
 An array of descriptions of the cases ([UnionCaseInfo](../vs140/reflection.unioncaseinfo-class--fsharp-.md) objects) of the given union type.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Reflection.FSharpType Class (F#)](../vs140/reflection.fsharptype-class--fsharp-.md)   
 [Microsoft.FSharp.Reflection Namespace (F#)](../vs140/microsoft.fsharp.reflection-namespace--fsharp-.md)