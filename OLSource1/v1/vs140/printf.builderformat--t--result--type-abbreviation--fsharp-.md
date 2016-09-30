---
title: "Printf.BuilderFormat&lt;&#39;T,&#39;Result&gt; Type Abbreviation (F#)"
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
  - "Printf.BuilderFormat<'T,'Result>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.Printf.BuilderFormat`2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "BuilderFormat type abbreviation [F#]"
ms.assetid: 79f817c8-9d0c-440c-9174-d6ef1eabcaa0
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Printf.BuilderFormat&lt;&#39;T,&#39;Result&gt; Type Abbreviation (F#)
Represents a statically-analyzed format associated with writing to a \<xref:System.Text.StringBuilder*>. The first type parameter indicates the arguments of the format operation and the last the overall return type. This type is a type abbreviation for [Format\<'T,StringBuilder,unit,'Result>](../vs140/core.format--printer--state--residue--result--type-abbreviation--fsharp-.md).  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Printf  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
type BuilderFormat<'T,'Result> = Format<'T,StringBuilder,unit,'Result>  
```  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core.PrintfModule Namespace (F#)](../vs140/core.printf-module--fsharp-.md)   
 [Format\<'Printer,'State,'Residue,'Result>](../vs140/core.format--printer--state--residue--result--type-abbreviation--fsharp-.md)