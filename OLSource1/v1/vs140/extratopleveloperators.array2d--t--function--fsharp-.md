---
title: "ExtraTopLevelOperators.array2D&lt;&#39;T&gt; Function (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.ExtraTopLevelOperators.array2D"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "array2D function [F#]"
ms.assetid: 1d52503d-2990-49fc-8fd3-6b0e508aa236
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ExtraTopLevelOperators.array2D&lt;&#39;T&gt; Function (F#)
Builds a 2D array from a sequence of sequences of elements.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.ExtraTopLevelOperators  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
array2D : seq<#seq<'T>> -> 'T [,]  
  
// Usage:  
array2D rows  
```  
  
#### Parameters  
 `rows`  
 Type: [seq](../vs140/collections.seq--t--type-abbreviation--fsharp-.md)`<'T>`  
  
 The sequence of sequences for the array rows.  
  
## Return Value  
  
## Remarks  
 This function is named `CreateArray2D` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code shows how to initialize a two-dimensional array using `array2D`.  
  
 [!code[FsCoreLib1#1001](../vs140/codesnippet/FSharp/extratopleveloperators.array2d--t--function--fsharp-_1.fs)]  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.ExtraTopLevelOperators Module (F#)](../vs140/core.extratopleveloperators-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)