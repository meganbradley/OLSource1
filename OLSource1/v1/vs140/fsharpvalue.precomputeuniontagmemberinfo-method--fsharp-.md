---
title: "FSharpValue.PreComputeUnionTagMemberInfo Method (F#)"
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
  - "FSharpValue.PreComputeUnionTagMemberInfo"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Reflection.FSharpValue.PreComputeUnionTagMemberInfo"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "PreComputeUnionTagMemberInfo method [F#]"
  - "FSharpValue.PreComputeUnionTagMemberInfo method [F#]"
ms.assetid: bde85ca4-fa0b-44a1-b893-0d5bbf6b6d9f
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# FSharpValue.PreComputeUnionTagMemberInfo Method (F#)
Generates a property or static method for reading an integer representing the case tag of a union type.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Reflection  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member PreComputeUnionTagMemberInfo : Type * ?BindingFlags -> MemberInfo  
static member PreComputeUnionTagMemberInfo : Type * ?bool -> MemberInfo  
  
// Usage:  
FSharpValue.PreComputeUnionTagMemberInfo (unionType)  
FSharpValue.PreComputeUnionTagMemberInfo (unionType, bindingFlags = bindingFlags)  
  
open FSharpReflectionExtensions  
FSharpValue.PreComputeUnionTagMemberInfo (unionType, allowAccessToPrivateRepresentation = false)  
```  
  
#### Parameters  
 `unionType`  
 Type: <xref:System.Type*>  
  
 The type of union to read.  
  
 `bindingFlags`  
 Type: <xref:System.Reflection.BindingFlags*>  
  
 Optional binding flags.  
  
 `allowAccessToPrivateRepresentation`  
 Type: [bool](../vs140/core.bool-type-abbreviation--fsharp-.md)  
  
 Optional flag that denotes accessibility of the private representation.  
  
## Return Value  
 The description of the union case reader as a <xref:System.Reflection.MemberInfo*> object.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Reflection.FSharpValue Class (F#)](../vs140/reflection.fsharpvalue-class--fsharp-.md)   
 [Microsoft.FSharp.Reflection Namespace (F#)](../vs140/microsoft.fsharp.reflection-namespace--fsharp-.md)