---
title: "Printf.TextWriterFormat&lt;&#39;T,&#39;Result&gt; Type Abbreviation (F#)"
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
  - "Printf.TextWriterFormat<'T,'Result>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.Printf.TextWriterFormat`2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "TextWriterFormat type abbreviation [F#]"
ms.assetid: 869f361a-8789-4c2d-acfc-38adec848c68
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Printf.TextWriterFormat&lt;&#39;T,&#39;Result&gt; Type Abbreviation (F#)
Represents a statically-analyzed format associated with writing to a <xref:System.IO.TextWriter*>. The first type parameter indicates the arguments of the format operation and the last the overall return type. This type is a type abbreviation for [Format<'Printer,TextWriter,unit,'Result>](../vs140/core.format--printer--state--residue--result--type-abbreviation--fsharp-.md).  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Printf  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
type TextWriterFormat<'T,'Result> = Format<'Printer,'State,'Residue,'Result>  
```  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core.PrintfModule Namespace (F#)](../vs140/core.printf-module--fsharp-.md)   
 [Format<'Printer,'State,'Residue,'Result>](../vs140/core.format--printer--state--residue--result--type-abbreviation--fsharp-.md)