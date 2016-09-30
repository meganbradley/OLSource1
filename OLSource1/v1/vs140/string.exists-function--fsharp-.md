---
title: "String.exists Function (F#)"
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
  - "String.exists"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.StringModule.Exists"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "exists function [F#]"
  - "String.exists function [F#]"
ms.assetid: 2a9952a0-7071-4d8f-b32b-90736d5aa781
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# String.exists Function (F#)
Tests if any character of the string satisfies the given predicate.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.String  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: [char](../vs140/core.char-type-abbreviation--fsharp-.md) <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> [bool](../vs140/core.bool-type-abbreviation--fsharp-.md)  
  
 The function to test each character of the string.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Type: [string](../vs140/core.string-type-abbreviation--fsharp-.md)  
  
 The input string.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|\<xref:System.ArgumentNullException*>|Thrown when the input string is null.|  
  
## Return Value  
 Returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if any character returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> for the predicate and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> otherwise.  
  
## Remarks  
 This function is named <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code shows how to use <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 [!code[FsStrings#3](../vs140/codesnippet/FSharp/string.exists-function--fsharp-_1.fs)]  
  
 **Output**  
  
 **The string "Hello World!" contains uppercase characters.**  
**The string "no" does not contain uppercase characters.**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.String Module (F#)](../vs140/core.string-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)