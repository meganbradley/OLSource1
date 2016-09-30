---
title: "LanguagePrimitives.GenericComparisonWithComparer&lt;&#39;T&gt; Function (F#)"
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
  - "LanguagePrimitives.GenericComparisonWithComparer<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.LanguagePrimitives.GenericComparisonWithComparer``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "GenericComparisonWithComparer function [F#]"
  - "LanguagePrimitives.GenericComparisonWithComparer function [F#]"
ms.assetid: 7e4ae86f-4f64-4b3d-97b7-53ce2ac6c572
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# LanguagePrimitives.GenericComparisonWithComparer&lt;&#39;T&gt; Function (F#)
Compare two values. May be called as a recursive case from an implementation of <xref:System.IComparable`1*> to ensure consistent NaN comparison semantics.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.LanguagePrimitives  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0</CodeContentPlaceHolder>  
#### Parameters  
 `comp`  
 Type: <xref:System.Collections.IComparer*>  
  
 The function to compare the values.  
  
 `e1`  
 Type: `'T`  
  
 The first value.  
  
 `e2`  
 Type: `'T`  
  
 The second value.  
  
## Return Value  
 The result of the comparison.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.LanguagePrimitives Module (F#)](../vs140/core.languageprimitives-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)