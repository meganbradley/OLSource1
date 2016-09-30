---
title: "Compiler Warning (level 4) CS0109"
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
  - "CS0109"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0109"
ms.assetid: 42ac72e5-5081-4e8b-b2cf-5e10c1606676
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 4) CS0109
The member 'member' does not hide an inherited member. The new keyword is not required  
  
 A class declaration included the [new](../vs140/new--csharp-reference-.md) keyword even though the declaration does not override an existing declaration in a base class. You can delete the **new** keyword.  
  
 The following sample generates CS0109:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>