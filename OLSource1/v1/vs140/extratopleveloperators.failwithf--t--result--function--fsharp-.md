---
title: "ExtraTopLevelOperators.failwithf&lt;&#39;T,&#39;Result&gt; Function (F#)"
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
  - "ExtraTopLevelOperators.failwithf<'T,'Result>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.ExtraTopLevelOperators.PrintFormatToStringThenFail``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "ExtraTopLevelOperators.failwithf function [F#]"
  - "ExtraTopLevelOperators.PrintFormatToStringThenFail function [F#]"
  - "PrintFormatToStringThenFail function [F#]"
  - "failwithf function [F#]"
ms.assetid: 677781f0-fb69-4dfe-9d18-8fb1a7fc7aed
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ExtraTopLevelOperators.failwithf&lt;&#39;T,&#39;Result&gt; Function (F#)
Print to a string buffer and raise an exception with the given result. Helper printers must return strings.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.ExtraTopLevelOperators  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
failwithf : StringFormat<'T,'Result> -> 'T  
  
// Usage:  
failwithf format  
```  
  
#### Parameters  
 `format`  
 Type: [StringFormat](../vs140/printf.stringformat--t--result--type-abbreviation--fsharp-.md)`<'T,'Result>`  
  
## Return Value  
  
## Remarks  
 This function is named `PrintFormatToStringThenFail` in compiled assemblies. If you are accessing the member from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code example illustrates the use of `failwithf`.  
  
 [!code[FsCoreLib2#4](../vs140/codesnippet/FSharp/extratopleveloperators.failwithf--t--result--function--fsharp-_1.fs)]  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.ExtraTopLevelOperators Module (F#)](../vs140/core.extratopleveloperators-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)