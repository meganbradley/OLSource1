---
title: "Compiler Error CS0542"
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
  - "CS0542"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0542"
ms.assetid: 68a89948-8b56-4cd5-95e2-0df7fcad50ac
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0542
'user-defined type' : member names cannot be the same as their enclosing type  
  
 The members of a class or struct cannot have the same name as the class or struct, unless the member is a constructor.  
  
 The following sample generates CS0542:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This error might be caused if you inadvertently put a return type on a constructor, which in effect makes it into an ordinary method. The following example generates CS0542 because <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is a method, not a constructor, because it has a return type:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 If your class is named 'Item' and has an indexer declared as <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, you may get this error. A default indexer is given the name 'Item' in the emitted code, creating the conflict.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>