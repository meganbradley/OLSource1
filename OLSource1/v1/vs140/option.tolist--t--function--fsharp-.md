---
title: "Option.toList&lt;&#39;T&gt; Function (F#)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-fsharp
ms.tgt_pltfrm: na
ms.topic: reference
apiname: 
  - Option.to_list<'T>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Core.OptionModule.ToList``1
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - Option.toList function [F#]
  - toList function [F#]
ms.assetid: 5f1af295-9fa9-40ad-b4a1-3578d94d44e1
caps.latest.revision: 24
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Option.toList&lt;&#39;T&gt; Function (F#)
Convert the option to a list of length 0 or 1.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Option  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
toList : 'T option -> 'T list  
  
// Usage:  
toList option  
```  
  
#### Parameters  
 `option`  
 Type: `'T`[option](../vs140/core.option--t--union--fsharp-.md)  
  
 The input option.  
  
## Return Value  
 The result [list](../vs140/collections.list--t--type-abbreviation--fsharp-.md).  
  
## Remarks  
 This function is named `ToList` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable, Portable  
  
## See Also  
 [Core.Option Module (F#)](../vs140/core.option-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)