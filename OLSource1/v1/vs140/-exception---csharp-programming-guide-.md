---
title: "&lt;exception&gt; (C# Programming Guide)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "exception"
  - "<exception>"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "<exception> C# XML tag"
  - "exception C# XML tag"
ms.assetid: dd73aac5-3c74-4fcf-9498-f11bff3a2f3c
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;exception&gt; (C# Programming Guide)
## Syntax  
  
```  
<exception cref="member">description</exception>  
```  
  
#### Parameters  
 cref = " `member`"  
 A reference to an exception that is available from the current compilation environment. The compiler checks that the given exception exists and translates `member` to the canonical element name in the output XML. `member` must appear within double quotation marks (" ").  
  
 For more information on how to create a cref reference to a generic type, see [<see\> (C# Programmer's Reference)](../vs140/-see---csharp-programming-guide-.md).  
  
 `description`  
 A description of the exception.  
  
## Remarks  
 The <exception\> tag lets you specify which exceptions can be thrown. This tag can be applied to definitions for methods, properties, events, and indexers.  
  
 Compile with [/doc](../vs140/-doc--csharp-compiler-options-.md) to process documentation comments to a file.  
  
 For more information about exception handling, see [Exceptions and Exception Handling (C# Programming Guide)](../vs140/exceptions-and-exception-handling--csharp-programming-guide-.md).  
  
## Example  
 [!code[csProgGuideDocComments#4](../vs140/codesnippet/CSharp/-exception---csharp-programming-guide-_1.cs)]  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Recommended Tags for Documentation Comments](../vs140/recommended-tags-for-documentation-comments--csharp-programming-guide-.md)