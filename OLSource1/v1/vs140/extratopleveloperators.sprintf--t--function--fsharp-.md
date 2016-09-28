---
title: "ExtraTopLevelOperators.sprintf&lt;&#39;T&gt; Function (F#)"
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
  - "ExtraTopLevelOperators.sprintf<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.ExtraTopLevelOperators.PrintFormatToString``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "sprintf function [F#]"
  - "ExtraTopLevelOperators.sprintf function [F#]"
  - "ExtraTopLevelOperators.PrintFormatToString function [F#]"
  - "PrintFormatToString function [F#]"
ms.assetid: 8ddc0cc1-4e80-4371-820d-cdde04ab8145
caps.latest.revision: 25
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ExtraTopLevelOperators.sprintf&lt;&#39;T&gt; Function (F#)
The sprintf function prints to a string using the given format.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.ExtraTopLevelOperators  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
sprintf : StringFormat<'T> -> 'T  
  
// Usage:  
sprintf format  
```  
  
#### Parameters  
 `format`  
 Type: [StringFormat](../vs140/printf.stringformat--t--type-abbreviation--fsharp-.md)`<'T>`  
  
## Return Value  
  
## Remarks  
 This function is named `PrintFormatToString` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code example illustrates the use of `sprintf`.  
  
 [!code[FsCoreLib2#10](../vs140/codesnippet/FSharp/extratopleveloperators.sprintf--t--function--fsharp-_1.fs)]  
  
 **Formatted string with value 109...**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.ExtraTopLevelOperators Module (F#)](../vs140/core.extratopleveloperators-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)