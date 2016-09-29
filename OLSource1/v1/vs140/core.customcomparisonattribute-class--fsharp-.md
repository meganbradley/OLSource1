---
title: "Core.CustomComparisonAttribute Class (F#)"
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
  - "Core.CustomComparisonAttribute"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.CustomComparisonAttribute"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "CustomComparison attribute [F#]"
  - "CustomComparisonAttribute class [F#]"
ms.assetid: e25c43cc-e553-44b2-8229-cff53f4af552
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Core.CustomComparisonAttribute Class (F#)
Adding this attribute to a type indicates it is a type with a user-defined implementation of comparison.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
[<AttributeUsage(AttributeTargets.Class ||| AttributeTargets.Struct, AllowMultiple = false)>]  
[<Sealed>]  
type CustomComparisonAttribute =  
 class  
  new CustomComparisonAttribute : unit -> CustomComparisonAttribute  
 end  
```  
  
## Remarks  
 You can also use the short form of the name, `CustomComparison`.  
  
## Constructors  
  
|Member|Description|  
|------------|-----------------|  
|[new](../vs140/core.customcomparisonattribute-constructor--fsharp-.md)|Creates an instance of the attribute|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)