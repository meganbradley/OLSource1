---
title: "Core.StructuralEqualityAttribute Class (F#)"
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
  - "Core.StructuralEqualityAttribute"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.StructuralEqualityAttribute"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "StructuralEquality attribute [F#]"
  - "StructuralEqualityAttribute class [F#]"
ms.assetid: ce41f6e6-5534-4bb5-98f8-24288d04265a
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Core.StructuralEqualityAttribute Class (F#)
Adding this attribute to a record, union or struct type confirms the automatic generation of overrides for \<xref:System.Object.Equals*> and \<xref:System.Object.GetHashCode*> for the type.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
[<AttributeUsage(AttributeTargets.Class, AllowMultiple = false)>]  
[<Sealed>]  
type StructuralEqualityAttribute =  
 class  
  new StructuralEqualityAttribute : unit -> StructuralEqualityAttribute  
 end  
```  
  
## Remarks  
 You can also use the short form of the name, `StructuralEquality`.  
  
## Constructors  
  
|Member|Description|  
|------------|-----------------|  
|[new](../vs140/core.structuralequalityattribute-constructor--fsharp-.md)|Creates an instance of the attribute|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)