---
title: "FSharpValue.GetRecordFields Method (F#)"
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
  - "FSharpValue.GetRecordFields"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Reflection.FSharpValue.GetRecordFields"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "FSharpValue.GetRecordFields method [F#]"
  - "GetRecordFields method [F#]"
ms.assetid: e328a079-cfd4-4d88-bc17-4523f8a708bf
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# FSharpValue.GetRecordFields Method (F#)
Reads all the fields from a record value.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Reflection  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member GetRecordFields : obj * ?BindingFlags -> obj []  
static member GetRecordFields : obj * ?bool -> obj []  
// Usage:  
FSharpValue.GetRecordFields (record)  
FSharpValue.GetRecordFields (record, bindingFlags = bindingFlags)  
  
open FSharpReflectionExtensions  
FSharpValue.GetRecordFields (record, allowAccessToPrivateRepresentation = false)  
```  
  
#### Parameters  
 `record`  
 Type: [obj](../vs140/core.obj-type-abbreviation--fsharp-.md)  
  
 The record object.  
  
 `bindingFlags`  
 Type: <xref:System.Reflection.BindingFlags*>  
  
 Optional binding flags for the record.  
  
 `allowAccessToPrivateRepresentation`  
 Type: [bool](../vs140/core.bool-type-abbreviation--fsharp-.md)  
  
 Optional flag that denotes accessibility of the private representation.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|<xref:System.ArgumentException*>|Thrown when the input type is not a record type.|  
  
## Return Value  
 The array of fields from the record.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Reflection.FSharpValue Class (F#)](../vs140/reflection.fsharpvalue-class--fsharp-.md)   
 [Microsoft.FSharp.Reflection Namespace (F#)](../vs140/microsoft.fsharp.reflection-namespace--fsharp-.md)