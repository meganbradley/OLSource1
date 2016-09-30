---
title: "Printf.ksprintf&lt;&#39;Result,&#39;T&gt; Function (F#)"
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
  - "Printf.ksprintf<'Result,'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.PrintfModule.PrintFormatToStringThen``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Printf.PrintFormatToStringThen function [F#]"
  - "Printf.ksprintf function [F#]"
  - "ksprintf function [F#]"
  - "PrintFormatToStringThen function [F#]"
ms.assetid: 03e98a01-11af-4f2c-902f-451cfca943e5
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Printf.ksprintf&lt;&#39;Result,&#39;T&gt; Function (F#)
Like [sprintf](../vs140/printf.sprintf--t--function--fsharp-.md), but calls the specified function to generate the result. See [kprintf](../vs140/printf.kprintf--result--t--function--fsharp-.md).  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Printf  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: [string](../vs140/core.string-type-abbreviation--fsharp-.md) <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 The function called to generate a result from the formatted string.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Type: [StringFormat](../vs140/printf.stringformat--t--result--type-abbreviation--fsharp-.md)<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 The input formatter.  
  
## Return Value  
 The arguments of the formatter.  
  
## Remarks  
 This function is named <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the member from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.Printf Module (F#)](../vs140/core.printf-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)