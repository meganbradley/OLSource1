---
title: "Compiler Error CS0531"
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
  - "CS0531"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0531"
ms.assetid: 54c2a98b-84e3-481a-a934-7cd6dffa7677
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0531
'member' : interface members cannot have a definition  
  
 Methods that are declared in an [interface](../vs140/interface--csharp-reference-.md) must be implemented in a class that inherits from it and not in the interface itself.  
  
 The following sample generates CS0531:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>