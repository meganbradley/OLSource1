---
title: "Core.UnverifiableAttribute Class (F#)"
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
  - "Core.UnverifiableAttribute"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.UnverifiableAttribute"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "UnverifiableAttribute class [F#]"
  - "Unverifiable attribute [F#]"
ms.assetid: 3a874ac6-dc5e-4da6-82c1-2addaf8b3189
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Core.UnverifiableAttribute Class (F#)
This attribute is used to tag values whose use will result in the generation of unverifiable code. These values are inevitably marked `inline` to ensure that the unverifiable constructs are not present in the actual code for the F# library, but are rather copied to the source code of the caller.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
[<AttributeUsage(AttributeTargets.Method ||| AttributeTargets.Property, AllowMultiple = false)>]  
[<Sealed>]  
type UnverifiableAttribute =  
 class  
  new UnverifiableAttribute : unit -> UnverifiableAttribute  
 end  
```  
  
## Remarks  
 You can also use the short form of the name, `Unverifiable`.  
  
## Constructors  
  
|Member|Description|  
|------------|-----------------|  
|[new](../vs140/core.unverifiableattribute-constructor--fsharp-.md)|Creates an instance of the attribute|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)