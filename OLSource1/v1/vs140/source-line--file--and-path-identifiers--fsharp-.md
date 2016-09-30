---
title: "Source Line, File, and Path Identifiers (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "__SOURCE_FILE__ [F#]"
  - "__SOURCE_DIRECTORY__ [F#]"
  - "__LINE__ [F#]"
ms.assetid: b65d1dda-70b3-40aa-8c04-d51a78f05573
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Source Line, File, and Path Identifiers (F#)
The identifiers <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> are built-in values that enable you to access the source line number, directory and file name in your code.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Each of these values has type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 The following table summarizes the source line, file, and path identifiers that are available in F#. These identifiers are not preprocessor macros; they are built-in values that are recognized by the compiler.  
  
|Predefined identifier|Description|  
|---------------------------|-----------------|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Evaluates to the current line number, considering <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> directives.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Evaluates to the current full path of the source directory, considering <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> directives.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Evaluates to the current source file name and its path, considering <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> directives.|  
  
 For more information about the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> directive, see [Preprocessor and Compiler Directives](../vs140/compiler-directives--fsharp-.md).  
  
 The following code example demonstrates the use of these values.  
  
 [!code[FsLangRef2#7401](../vs140/codesnippet/FSharp/source-line--file--and-path-identifiers--fsharp-_1.fs)]  
  
 Output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Preprocessor and Compiler Directives](../vs140/compiler-directives--fsharp-.md)   
 [F# Language Reference](../vs140/fsharp-language-reference.md)