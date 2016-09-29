---
title: "Nullable.enum&lt;^U&gt; Function (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Linq.Nullable.enum"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Nullable.enum function [F#]"
ms.assetid: d1149ef9-696f-4cf4-b4cd-94521606926b
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Nullable.enum&lt;^U&gt; Function (F#)
Converts the argument to a particular enum type.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Linq.Nullable  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
enum : Nullable<int32> -> Nullable<^U> when ^U : enum<int32> and ^U : (new : unit ->  ^U) and ^U : struct and ^U :> ValueType  
  
// Usage:  
Nullable.enum value  
```  
  
#### Parameters  
 `value`  
 Type: <xref:System.Nullable`1*><[int32](../vs140/core.int32-type-abbreviation--fsharp-.md)>  
  
 The input value.  
  
## Return Value  
 The converted enum type.  
  
## Remarks  
 This function is named `ToEnum` in the .NET assembly. If accessing the member from a .NET language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 4.0, Portable  
  
## See Also  
 [Linq.Nullable Module (F#)](../vs140/linq.nullable-module--fsharp-.md)   
 [Microsoft.FSharp.Linq Namespace (F#)](../vs140/microsoft.fsharp.linq-namespace--fsharp-.md)   
 [Operators.enum<^U> Function (F#)](../vs140/operators.enum-^u--function--fsharp-.md)   
 [Enumerations (F#)](../vs140/enumerations--fsharp-.md)