---
title: "Compiler Error CS0176"
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
  - "CS0176"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0176"
ms.assetid: 783c13d8-5ac3-4aeb-bd63-0468cb05550d
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0176
Static member 'member' cannot be accessed with an instance reference; qualify it with a type name instead  
  
 Only a class name can be used to qualify a [static](../vs140/static--csharp-reference-.md) variable; an instance name cannot be a qualifier. For more information, see [Static Classes and Static Class Members (C# Programmer's Reference)](../vs140/static-classes-and-static-class-members--csharp-programming-guide-.md).  
  
 The following sample generates CS0176:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>