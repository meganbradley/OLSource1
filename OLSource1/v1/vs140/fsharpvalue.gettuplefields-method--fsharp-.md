---
title: "FSharpValue.GetTupleFields Method (F#)"
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
  - "FSharpValue.GetTupleFields"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Reflection.FSharpValue.GetTupleFields"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "FSharpValue.GetTupleFields method [F#]"
  - "GetTupleFields method [F#]"
ms.assetid: 872a1830-3992-4503-b17c-10c995903e87
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# FSharpValue.GetTupleFields Method (F#)
Reads all fields from a tuple.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Reflection  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member GetTupleFields : obj -> obj []  
  
// Usage:  
FSharpValue.GetTupleFields (tuple)  
```  
  
#### Parameters  
 `tuple`  
 Type: [obj](../vs140/core.obj-type-abbreviation--fsharp-.md)  
  
 The input tuple.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|<xref:System.ArgumentException*>|Thrown when the input is not a tuple value.|  
  
## Return Value  
 An array of the fields from the given tuple.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Reflection.FSharpValue Class (F#)](../vs140/reflection.fsharpvalue-class--fsharp-.md)   
 [Microsoft.FSharp.Reflection Namespace (F#)](../vs140/microsoft.fsharp.reflection-namespace--fsharp-.md)