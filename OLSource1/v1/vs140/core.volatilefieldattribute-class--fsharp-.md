---
title: "Core.VolatileFieldAttribute Class (F#)"
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
  - "Core.VolatileFieldAttribute"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.VolatileFieldAttribute"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "VolatileFieldAttribute class [F#]"
  - "VolatileField attribute [F#]"
ms.assetid: 1e7ea0f8-4c85-402e-b529-55079bc79d7e
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Core.VolatileFieldAttribute Class (F#)
Adding this attribute to an F# mutable binding causes the `volatile` prefix to be used for all accesses to the field.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
[<AttributeUsage(AttributeTargets.Field, AllowMultiple = false)>]  
[<Sealed>]  
type VolatileFieldAttribute =  
 class  
  new VolatileFieldAttribute : unit -> VolatileFieldAttribute  
 end  
```  
  
## Remarks  
 You can also use the short form of the name, `VolatileField`.  
  
## Constructors  
  
|Member|Description|  
|------------|-----------------|  
|[new](../vs140/core.volatilefieldattribute-constructor--fsharp-.md)|Creates an instance of the attribute|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)