---
title: "Compiler Error CS0192"
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
  - "CS0192"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0192"
ms.assetid: d3fb6d18-dbf3-42c3-a280-afe55b97c2d1
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0192
Fields of static readonly field 'name' cannot be passed ref or out (except in a static constructor)  
  
 A field (variable) marked with the [readonly](../vs140/readonly--csharp-reference-.md) keyword cannot be passed either to a [ref](../vs140/ref--csharp-reference-.md) or [out](../vs140/out--csharp-reference-.md) parameter except inside a constructor. For more information, see [Properties and Fields (C# Programmer's Reference)](../vs140/fields--csharp-programming-guide-.md).  
  
 CS0192 also results if the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> field is [static](../vs140/static--csharp-reference-.md) and the constructor is not marked <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Example  
 The following sample generates CS0192.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>