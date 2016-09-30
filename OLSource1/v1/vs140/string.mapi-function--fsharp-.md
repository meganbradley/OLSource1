---
title: "String.mapi Function (F#)"
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
  - "String.mapi"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.StringModule.MapIndexed"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "MapIndexed function [F#]"
  - "String.MapIndexed function [F#]"
  - "String.mapi function [F#]"
  - "mapi function [F#]"
ms.assetid: 08e0ae3c-dbfa-4bc2-9e02-91c023105f2d
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# String.mapi Function (F#)
Creates a new string whose characters are the results of applying a specified function to each character and index of the input string.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.String  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
String.mapi : (int -> char -> char) -> string -> string  
  
// Usage:  
String.mapi mapping str  
```  
  
#### Parameters  
 `mapping`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md) `->` [char](../vs140/core.char-type-abbreviation--fsharp-.md) `->` [char](../vs140/core.char-type-abbreviation--fsharp-.md)  
  
 The function to apply to each character and index of the string.  
  
 `str`  
 Type: [string](../vs140/core.string-type-abbreviation--fsharp-.md)  
  
 The input string.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|\<xref:System.ArgumentNullException*>|Thrown when the input string is null.|  
  
## Return Value  
 The resulting string.  
  
## Remarks  
 This function is named `MapIndexed` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code shows how to use `String.mapi`.  
  
 [!code[FsStrings#10](../vs140/codesnippet/FSharp/string.mapi-function--fsharp-_1.fs)]  
  
 **Output**  
  
 **MASK**  
**BASK**  
**BASH**  
**BATH**  
**BOTH**  
**MOTH**  
**MATH**  
**MASH**  
**MASK**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library VersionsF# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable2.0, 4.0, Portable  
  
## See Also  
 [Core.String Module (F#)](../vs140/core.string-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)