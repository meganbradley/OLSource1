---
title: "Compiler Error CS0191"
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
  - "CS0191"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0191"
ms.assetid: 512479e4-656e-4dcb-8d71-801541d72dcd
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0191
Property or indexer 'name' cannot be assigned to -- it is read only  
  
 A [readonly](../vs140/readonly--csharp-reference-.md) field can only take an assignment in a constructor or at declaration. For more information, see [Constructors (C# Programmer's Reference)](../vs140/constructors--csharp-programming-guide-.md).  
  
 CS0191 also results if the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> field is [static](../vs140/static--csharp-reference-.md) and the constructor is not marked <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Example  
 The following sample generates CS0191.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>