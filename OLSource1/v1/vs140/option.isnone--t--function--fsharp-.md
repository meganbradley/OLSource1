---
title: "Option.isNone&lt;&#39;T&gt; Function (F#)"
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
  - Option.isNone<'T>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Core.OptionModule.IsNone``1
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - Option.isNone function [F#]
  - isNone function [F#]
ms.assetid: 73db6a53-15e7-40a6-94f9-a0049e5f4819
caps.latest.revision: 23
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Option.isNone&lt;&#39;T&gt; Function (F#)
Returns `true` if the option is `None`.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Option  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
isNone : 'T option -> bool  
  
// Usage:  
isNone option  
```  
  
#### Parameters  
 `option`  
 Type: `'T`[option](../vs140/core.option--t--union--fsharp-.md)  
  
 The input option.  
  
## Return Value  
 `true` if the option is `None`.  
  
## Remarks  
 This function is named `IsNone` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.Option Module (F#)](../vs140/core.option-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)