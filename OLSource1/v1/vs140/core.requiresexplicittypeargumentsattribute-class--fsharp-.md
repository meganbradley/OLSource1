---
title: "Core.RequiresExplicitTypeArgumentsAttribute Class (F#)"
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
  - "Core.RequiresExplicitTypeArgumentsAttribute"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.RequiresExplicitTypeArgumentsAttribute"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "RequiresExplicitTypeArgumentsAttribute class [F#]"
  - "RequiresExplicitTypeArguments attribute [F#]"
ms.assetid: 74f570a0-88f8-4183-a314-2151e3351076
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Core.RequiresExplicitTypeArgumentsAttribute Class (F#)
Adding this attribute to a type, value or member requires that uses of the construct must explicitly instantiate any generic type parameters.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
[<AttributeUsage(AttributeTargets.Method, AllowMultiple = false)>]  
[<Sealed>]  
type RequiresExplicitTypeArgumentsAttribute =  
 class  
  new RequiresExplicitTypeArgumentsAttribute : unit -> RequiresExplicitTypeArgumentsAttribute  
 end  
```  
  
## Remarks  
 You can also use the short form of the name, `RequiresExplicitTypeArguments`.  
  
## Constructors  
  
|Member|Description|  
|------------|-----------------|  
|[new](../vs140/core.requiresexplicittypeargumentsattribute-constructor--fsharp-.md)|Creates an instance of the attribute|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)