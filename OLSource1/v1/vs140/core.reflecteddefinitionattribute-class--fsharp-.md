---
title: "Core.ReflectedDefinitionAttribute Class (F#)"
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
  - "Core.ReflectedDefinitionAttribute"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.ReflectedDefinitionAttribute"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "ReflectedDefinitionAttribute class [F#]"
  - "ReflectedDefinition attribute [F#]"
ms.assetid: 56bb03a2-4deb-4860-b334-f59fdfc95b04
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Core.ReflectedDefinitionAttribute Class (F#)
Add this attribute to the let-binding for the definition of a top-level value to make the quotation expression that implements the value available for use at runtime. Add this attribute to a type or module to make it apply recursively to all the values in the module or all the members of the type.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
[<AttributeUsage(AttributeTargets.Class ||| AttributeTargets.Method ||| AttributeTargets.Property ||| AttributeTargets.Constructor, AllowMultiple = false)>]  
[<Sealed>]  
type ReflectedDefinitionAttribute =  
 class  
  new ReflectedDefinitionAttribute : unit -> ReflectedDefinitionAttribute  
 end  
```  
  
## Remarks  
 You can also use the short form of the name, `ReflectedDefinition`.  
  
## Constructors  
  
|Member|Description|  
|------------|-----------------|  
|[new](../vs140/core.reflecteddefinitionattribute-constructor--fsharp-.md)|Creates an instance of the attribute|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)