---
title: "String.map Function (F#)"
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
  - "String.map"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.StringModule.Map"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "map function [F#]"
  - "String.map function [F#]"
ms.assetid: 58fc5f63-f402-4790-baa5-2c8feeb1bcb1
caps.latest.revision: 27
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# String.map Function (F#)
Creates a new string whose characters are the results of applying a specified function to each of the characters of the input string.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.String  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
String.map : (char -> char) -> string -> string  
  
// Usage:  
String.map mapping str  
```  
  
#### Parameters  
 `mapping`  
 Type: [char](../vs140/core.char-type-abbreviation--fsharp-.md) `->` [char](../vs140/core.char-type-abbreviation--fsharp-.md)  
  
 The function to apply to the characters of the string.  
  
 `str`  
 Type: [string](../vs140/core.string-type-abbreviation--fsharp-.md)  
  
 The input string.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|<xref:System.ArgumentNullException*>|Thrown when the input string is null.|  
  
## Return Value  
 The resulting string.  
  
## Remarks  
 This function is named `Map` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code shows how to use `String.map`.  
  
 [!code[FsStrings#7](../vs140/codesnippet/FSharp/string.map-function--fsharp-_1.fs)]  
  
 **Output**  
  
 **The quick sly fox jumped over the lazy brown dog.**  
**Gur dhvpx fyl sbk whzcrq bire gur ynml oebja qbt.**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library VersionsF# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable2.0, 4.0, Portable  
  
## See Also  
 [Core.String Module (F#)](../vs140/core.string-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)