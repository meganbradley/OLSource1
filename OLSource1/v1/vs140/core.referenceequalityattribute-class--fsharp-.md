---
title: "Core.ReferenceEqualityAttribute Class (F#)"
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
  - "Core.ReferenceEqualityAttribute"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.ReferenceEqualityAttribute"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "ReferenceEquality attribute [F#]"
  - "ReferenceEqualityAttribute class [F#]"
ms.assetid: 6b448574-616f-4825-80c5-ad9334c4d252
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Core.ReferenceEqualityAttribute Class (F#)
Adding this attribute to a record or union type disables the automatic generation of overrides for <xref:System.Object.Equals*>, <xref:System.Object.GetHashCode*> and <xref:System.IComparable*> for the type. The type will by default use reference equality.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
[<AttributeUsage(AttributeTargets.Class, AllowMultiple = false)>]  
[<Sealed>]  
type ReferenceEqualityAttribute =  
 class  
  new ReferenceEqualityAttribute : unit -> ReferenceEqualityAttribute  
 end  
```  
  
## Remarks  
 You can also use the short form of the name, `ReferenceEquality`.  
  
## Constructors  
  
|Member|Description|  
|------------|-----------------|  
|[new](../vs140/core.referenceequalityattribute-constructor--fsharp-.md)|Creates an instance of the attribute.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)