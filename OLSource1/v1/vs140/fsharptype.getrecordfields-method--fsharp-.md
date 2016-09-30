---
title: "FSharpType.GetRecordFields Method (F#)"
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
  - "FSharpType.GetRecordFields"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Reflection.FSharpType.GetRecordFields"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "FSharpType.GetRecordFields method [F#]"
  - "GetRecordFields method [F#]"
ms.assetid: 266635db-ea29-481f-9cb7-b7f72b754497
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# FSharpType.GetRecordFields Method (F#)
Reads all the fields from a record value, in declaration order.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Reflection  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member GetRecordFields : Type * ?BindingFlags -> PropertyInfo []  
static member GetRecordFields : Type * ?bool -> PropertyInfo []  
  
// Usage:  
FSharpType.GetRecordFields (recordType)  
FSharpType.GetRecordFields (recordType, bindingFlags = bindingFlags)  
  
open FSharpReflectionExtensions  
FSharpType.GetExceptionFields (recordType, allowAccessToPrivateRepresentation = false)  
```  
  
#### Parameters  
 `recordType`  
 Type: \<xref:System.Type*>  
  
 The input record type.  
  
 `bindingFlags`  
 Type: \<xref:System.Reflection.BindingFlags*>  
  
 Optional binding flags.  
  
 `allowAccessToPrivateRepresentation`  
 Type: [bool](../vs140/core.bool-type-abbreviation--fsharp-.md)  
  
 Optional flag that denotes accessibility of the private representation.  
  
## Return Value  
 An array of descriptions of the properties (\<xref:System.Reflection.PropertyInfo*> objects) of the record type.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|\<xref:System.ArgumentException*>|Thrown if the given type is not an record.|  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Reflection.FSharpType Class (F#)](../vs140/reflection.fsharptype-class--fsharp-.md)   
 [Microsoft.FSharp.Reflection Namespace (F#)](../vs140/microsoft.fsharp.reflection-namespace--fsharp-.md)