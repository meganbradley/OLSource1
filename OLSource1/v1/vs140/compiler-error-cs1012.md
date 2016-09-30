---
title: "Compiler Error CS1012"
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
  - "CS1012"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1012"
ms.assetid: 4acc5fe0-da47-4882-b7d8-557767d7cf03
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1012
Too many characters in character literal  
  
 An attempt was made to initialize a [char](../vs140/char--csharp-reference-.md) constant with more than one character.  
  
 CS1012 can also occur when doing data binding. For example the following line will give an error:  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  
 Try the following line instead:  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 The following sample generates CS1012:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>