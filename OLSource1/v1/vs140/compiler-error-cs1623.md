---
title: "Compiler Error CS1623"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CS1623"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1623"
ms.assetid: e52bc2d6-5116-40a2-90bc-23a3fa2c73e7
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1623
Iterators cannot have ref or out parameters  
  
 This error occurs if an iterator method takes a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter. To avoid this error, remove the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> keyword from the method signature.  
  
## Example  
 The following sample generates CS1623:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>