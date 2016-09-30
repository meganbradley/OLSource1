---
title: "FSharpValue.PreComputeRecordReader Method (F#)"
ms.custom: na
ms.date: "09/23/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
apiname: 
  - "FSharpValue.PreComputeRecordReader"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Reflection.FSharpValue.PreComputeRecordReader"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "FSharpValue.PreComputeRecordReader method [F#]"
  - "PreComputeRecordReader method [F#]"
ms.assetid: e0bbaa8b-746f-422f-9b54-9ef60ad6418b
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# FSharpValue.PreComputeRecordReader Method (F#)
Precompute a function for reading all the fields from a record.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Reflection  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member PreComputeRecordReader : Type * ?BindingFlags -> obj -> obj []  
static member PreComputeRecordReader : Type * ?bool -> obj -> obj []  
  
// Usage:  
FSharpValue.PreComputeRecordReader (recordType)  
FSharpValue.PreComputeRecordReader (recordType, bindingFlags = bindingFlags)  
  
open FSharpReflectionExtensions  
FSharpValue.PreComputeRecordReader (recordType, allowAccessToPrivateRepresentation = false)  
```  
  
#### Parameters  
 `recordType`  
 Type: \<xref:System.Type*>  
  
 The type of record to read.  
  
 `bindingFlags`  
 Type: \<xref:System.Reflection.BindingFlags*>  
  
 Optional binding flags.  
  
 `allowAccessToPrivateRepresentation`  
 Type: [bool](../vs140/core.bool-type-abbreviation--fsharp-.md)  
  
 Optional flag that denotes accessibility of the private representation.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|\<xref:System.ArgumentException*>|Thrown when the input type is not a record type.|  
  
## Return Value  
 An optimized reader for the given record type.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Reflection.FSharpValue Class (F#)](../vs140/reflection.fsharpvalue-class--fsharp-.md)   
 [Microsoft.FSharp.Reflection Namespace (F#)](../vs140/microsoft.fsharp.reflection-namespace--fsharp-.md)