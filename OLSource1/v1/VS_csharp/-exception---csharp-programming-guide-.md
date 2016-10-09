---
title: "&lt;exception&gt; (C# Programming Guide)"
ms.custom: na
ms.date: "10/03/2016"
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
caps.latest.revision: 16
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# &lt;exception&gt; (C# Programming Guide)
## Syntax  
  
```  
<exception cref="member">description</exception>  
```  
  
#### Parameters  
 cref = " `member`"  
 A reference to an exception that is available from the current compilation environment. The compiler checks that the given exception exists and translates `member` to the canonical element name in the output XML. `member` must appear within double quotation marks (" ").  
  
 For more information on how to create a cref reference to a generic type, see [\<see>](../VS_csharp/-see---csharp-programming-guide-.md).  
  
 `description`  
 A description of the exception.  
  
## Remarks  
 The \<exception> tag lets you specify which exceptions can be thrown. This tag can be applied to definitions for methods, properties, events, and indexers.  
  
 Compile with [/doc](../VS_csharp/-doc--csharp-compiler-options-.md) to process documentation comments to a file.  
  
 For more information about exception handling, see [Exceptions and Exception Handling](../VS_csharp/exceptions-and-exception-handling--csharp-programming-guide-.md).  
  
## Example  
 [!code[csProgGuideDocComments#4](../VS_csharp/codesnippet/CSharp/-exception---csharp-programming-guide-_1.cs)]  
  
## See Also  
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [Recommended Tags for Documentation Comments](../VS_csharp/recommended-tags-for-documentation-comments--csharp-programming-guide-.md)