---
title: "Compiler Warning (level 1) CS1570"
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
  - "CS1570"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1570"
ms.assetid: a121d5c4-8b90-4cda-af5b-6ba8f23b2b1e
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) CS1570
XML comment on 'construct' has badly formed XML — 'reason'  
  
 When using [/doc](../vs140/-doc--csharp-compiler-options-.md), any comments in the source code must be in XML. Any error with your XML markup will generate CS1570. For example:  
  
-   If you are passing a string to a **cref**, such as in an [\<exception>](../vs140/-exception---csharp-programming-guide-.md) tag, the string must be enclosed in double quotation marks.  
  
-   If you are using a tag, such as [\<seealso>](../vs140/-seealso---csharp-programming-guide-.md), which does not have a closing tag, you must specify a forward slash before the closing angle bracket.  
  
-   If you need to use a greater-than or less-than symbol in the text of description, you need to represent them with **&gt;** or **&lt;**.  
  
-   The file or path attribute on an [\<include>](../vs140/-include---csharp-programming-guide-.md) tag was missing or improperly formed.  
  
 The following sample generates CS1570:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>