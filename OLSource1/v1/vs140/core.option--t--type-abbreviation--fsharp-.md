---
title: "Core.option&lt;&#39;T&gt; Type Abbreviation (F#)"
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
  - "Core.option<'T> Type Abbreviation"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.option`1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "option type abbreviation [F#]"
ms.assetid: e5b1450c-2779-4c65-ae28-e7f740c37871
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Core.option&lt;&#39;T&gt; Type Abbreviation (F#)
The type of optional values. When used from other .NET Framework languages the empty option is the `null` value. This type is a type abbreviation for [Option](../vs140/core.option--t--union--fsharp-.md).  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
type option<'T> = Option<'T>  
```  
  
## Remarks  
 Use the constructors `Some` and `None` to create values of this type. Use the values in the [Option module](../vs140/core.option-module--fsharp-.md) to manipulate values of this type, or pattern match against the values directly. `None` values will appear as the value `null` to other .NET Framework languages. Instance methods on this type will appear as static methods to other .NET Framework languages due to the use of `null` as a value representation.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)   
 [Option](../vs140/core.option--t--union--fsharp-.md)