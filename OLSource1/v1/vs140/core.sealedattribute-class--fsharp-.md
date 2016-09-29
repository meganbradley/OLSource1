---
title: "Core.SealedAttribute Class (F#)"
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
  - "Core.SealedAttribute"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.SealedAttribute"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Sealed attribute [F#]"
  - "SealedAttribute class [F#]"
ms.assetid: 375b15c9-c6c4-4466-95db-35cbabb6c1d5
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Core.SealedAttribute Class (F#)
Adding this attribute to class definition makes it sealed, which means it may not be extended or implemented.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
[<AttributeUsage(AttributeTargets.Class, AllowMultiple = false)>]  
type SealedAttribute =  
 class  
  new SealedAttribute : bool -> SealedAttribute  
  new SealedAttribute : unit -> SealedAttribute  
  member this.Value :  bool  
 end  
```  
  
## Remarks  
 You can also use the short form of the name, `Sealed`.  
  
## Constructors  
  
|Member|Description|  
|------------|-----------------|  
|[new](../vs140/core.sealedattribute-constructor--fsharp-.md)|Creates an instance of the attribute|  
  
## Instance Members  
  
|Member|Description|  
|------------|-----------------|  
|[Value](../vs140/sealedattribute.value-property--fsharp-.md)|The value of the attribute, indicating whether the type is sealed or not.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)