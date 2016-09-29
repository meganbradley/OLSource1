---
title: "FSharpValue.PreComputeRecordConstructor Method (F#)"
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
  - "FSharpValue.PreComputeRecordConstructor"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Reflection.FSharpValue.PreComputeRecordConstructor"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "FSharpValue.PreComputeRecordConstructor method [F#]"
  - "PreComputeRecordConstructor method [F#]"
ms.assetid: e4029ded-7adb-4ee4-9fad-2f8a7d25f908
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# FSharpValue.PreComputeRecordConstructor Method (F#)
Generates a function for constructing a record value.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Reflection  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member PreComputeRecordConstructor : Type * ?BindingFlags -> obj [] -> obj  
static member PreComputeRecordConstructor : Type * ?bool -> obj [] -> obj  
// Usage:  
FSharpValue.PreComputeRecordConstructor (recordType)  
FSharpValue.PreComputeRecordConstructor (recordType, bindingFlags = bindingFlags)  
  
open FSharpReflectionExtensions  
FSharpValue.PreComputeRecordConstructor (recordType, allowAccessToPrivateRepresentation = false)  
```  
  
#### Parameters  
 `recordType`  
 Type: <xref:System.Type*>  
  
 The type of record to construct.  
  
 `bindingFlags`  
 Type: <xref:System.Reflection.BindingFlags*>  
  
 Optional binding flags.  
  
 `allowAccessToPrivateRepresentation`  
 Type: [bool](../vs140/core.bool-type-abbreviation--fsharp-.md)  
  
 Optional flag that denotes accessibility of the private representation.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|<xref:System.ArgumentException*>|Thrown when the input type is not a record type.|  
  
## Return Value  
 A function to construct records of the given type.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Reflection.FSharpValue Class (F#)](../vs140/reflection.fsharpvalue-class--fsharp-.md)   
 [Microsoft.FSharp.Reflection Namespace (F#)](../vs140/microsoft.fsharp.reflection-namespace--fsharp-.md)