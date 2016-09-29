---
title: "Unchecked.defaultof&lt;&#39;T&gt; Type Function (F#)"
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
  - "Unchecked.defaultof<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.Operators.Unchecked.DefaultOf``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Unchecked.defaultof type function [F#]"
  - "defaultof type function [F#]"
ms.assetid: 9ff97f2a-1bd4-4f4c-afbe-5886a74ab977
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Unchecked.defaultof&lt;&#39;T&gt; Type Function (F#)
Generate a default value for any type. This is `null` for reference types. For structures, this is structure value where all fields have the default value. This function is unsafe in the sense that some F# values do not have proper `null` values.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Operators.Unchecked  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
defaultof<'T> :  'T  
  
// Usage:  
defaultof  
```  
  
## Return Value  
  
## Remarks  
 This function is named `DefaultOf` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Operators.Unchecked Module (F#)](../VS_csharp/operators.unchecked-module--fsharp-.md)   
 [Microsoft.FSharp.Core.Operators Namespace (F#)](../VS_csharp/core.operators-module--fsharp-.md)