---
title: "String.concat Function (F#)"
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
  - "String.concat"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.StringModule.Concat"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "concat function [F#]"
  - "String.concat function [F#]"
ms.assetid: a66f19e5-2002-4960-8ce8-eae1be77bc5f
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# String.concat Function (F#)
Returns a new string made by concatenating the given strings with a separator.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.String  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: [string](../vs140/core.string-type-abbreviation--fsharp-.md)  
  
 The separator string to be inserted between the strings of the input sequence.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Type: [seq](../vs140/collections.seq--t--type-abbreviation--fsharp-.md)<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>[string](../vs140/core.string-type-abbreviation--fsharp-.md)<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 The sequence of strings to be concatenated.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|\<xref:System.ArgumentNullException*>|Thrown when strings is null.|  
  
## Return Value  
 A new string consisting of the concatenated strings separated by the separation string.  
  
## Remarks  
 This function is named <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code shows how to use <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 [!code[FsStrings#2](../vs140/codesnippet/FSharp/string.concat-function--fsharp-_1.fs)]  
  
 **Output**  
  
 **tomatoes, bananas, apples**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.String Module (F#)](../vs140/core.string-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)