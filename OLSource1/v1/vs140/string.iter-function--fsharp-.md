---
title: "String.iter Function (F#)"
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
  - "String.iter"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.StringModule.Iterate"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Iterate function [F#]"
  - "String.iter function [F#]"
  - "iter function [F#]"
  - "String.Iterate function [F#]"
ms.assetid: dad84486-fe93-4475-aea6-8735d463ac4d
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# String.iter Function (F#)
Applies a specified function to each character in a string.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.String  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: [char](../vs140/core.char-type-abbreviation--fsharp-.md) <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> [unit](../vs140/core.unit-type-abbreviation--fsharp-.md)  
  
 The function to be applied to each character of the string.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Type: [string](../vs140/core.string-type-abbreviation--fsharp-.md)  
  
 The input string.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|\<xref:System.ArgumentNullException*>|Thrown when the input string is null.|  
  
## Remarks  
 This function is named <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.String Module (F#)](../vs140/core.string-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)