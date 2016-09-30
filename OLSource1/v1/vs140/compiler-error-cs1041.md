---
title: "Compiler Error CS1041"
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
  - "CS1041"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1041"
ms.assetid: 9f62c058-cd28-4cb5-835c-d0f25f4fd08e
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1041
Identifier expected, 'keyword' is a keyword  
  
 A reserved word for the C# language was found where an identifier was expected. Replace the [keyword](../vs140/csharp-keywords.md) with a user-specified identifier.  
  
## Example  
 The following sample generates CS1041:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 When you are importing from another programming language that does not have the same set of reserved words, you can modify the reserved identifier with the @ prefix, as demonstrated in the following sample.  
  
 An identifier with an <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> prefix is called a verbatim identifier.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>