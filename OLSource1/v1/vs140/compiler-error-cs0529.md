---
title: "Compiler Error CS0529"
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
  - "CS0529"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0529"
ms.assetid: 61de8086-f991-455c-b009-bb8cd05f34bd
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0529
Inherited interface 'interface1' causes a cycle in the interface hierarchy of 'interface2'  
  
 The inheritance list for an [interface](../vs140/interface--csharp-reference-.md) includes a direct or indirect reference to itself. An interface cannot inherit from itself.  
  
 The following sample generates CS0529:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>