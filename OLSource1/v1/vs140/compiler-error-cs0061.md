---
title: "Compiler Error CS0061"
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
  - "CS0061"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0061"
ms.assetid: 8dfc57a9-653d-4902-a88c-92032ba64024
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0061
Inconsistent accessibility: base interface 'interface 1' is less accessible than interface 'interface 2'  
  
 A [public](../vs140/public--csharp-reference-.md) construct must return a publicly accessible object.  
  
 Interface accessibility cannot be narrowed in a derived interface. For more information, see [Interfaces (C# Programmer's Reference)](../vs140/interfaces--csharp-programming-guide-.md) and [Access Modifiers (C# Programmer's Reference)](../vs140/access-modifiers--csharp-programming-guide-.md).  
  
 The following sample generates CS0061.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>