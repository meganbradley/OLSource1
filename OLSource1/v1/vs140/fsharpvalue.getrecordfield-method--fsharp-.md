---
title: "FSharpValue.GetRecordField Method (F#)"
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
  - "FSharpValue.GetRecordField"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Reflection.FSharpValue.GetRecordField"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "FSharpValue.GetRecordField method [F#]"
  - "GetRecordField method [F#]"
ms.assetid: 6dacc2db-7425-45c0-bb04-77b84dd0452a
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# FSharpValue.GetRecordField Method (F#)
Reads a field from a record value.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Reflection  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member GetRecordField : obj * PropertyInfo -> obj  
  
// Usage:  
FSharpValue.GetRecordField (record, info)  
```  
  
#### Parameters  
 `record`  
 Type: [obj](../vs140/core.obj-type-abbreviation--fsharp-.md)  
  
 The record object.  
  
 `info`  
 Type: <xref:System.Reflection.PropertyInfo*>  
  
 The <xref:System.Reflection.PropertyInfo*> object describing the field to read.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|<xref:System.ArgumentException*>|Thrown when the input type is not a record type.|  
  
## Return Value  
 The field from the record.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Reflection.FSharpValue Class (F#)](../vs140/reflection.fsharpvalue-class--fsharp-.md)   
 [Microsoft.FSharp.Reflection Namespace (F#)](../vs140/microsoft.fsharp.reflection-namespace--fsharp-.md)