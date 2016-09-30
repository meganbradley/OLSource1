---
title: "Core.AutoSerializableAttribute Class (F#)"
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
  - "Core.AutoSerializableAttribute"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.AutoSerializableAttribute"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "AutoSerializable attribute [F#]"
  - "AutoSerializableAttribute class [F#]"
ms.assetid: e0102c84-9313-4eb4-a992-f39aa01db4bc
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Core.AutoSerializableAttribute Class (F#)
Adding this attribute to a type with value `false` disables the behavior where F# makes the type serializable by default.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
[<AttributeUsage(AttributeTargets.Class, AllowMultiple = false)>]  
[<Sealed>]  
type AutoSerializableAttribute =  
 class  
  new AutoSerializableAttribute : bool -> AutoSerializableAttribute  
  member this.Value :  bool  
 end  
```  
  
## Remarks  
 You can also use the short form of the name, `AutoSerializable`.  
  
## Constructors  
  
|Member|Description|  
|------------|-----------------|  
|[new](../vs140/core.autoserializableattribute-constructor--fsharp-.md)|Creates an instance of the attribute.|  
  
## Instance Members  
  
|Member|Description|  
|------------|-----------------|  
|[Value](../vs140/autoserializableattribute.value-property--fsharp-.md)|The value of the attribute, indicating whether the type is automatically marked serializable or not.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)