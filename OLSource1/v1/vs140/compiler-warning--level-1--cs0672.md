---
title: "Compiler Warning (level 1) CS0672"
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
  - "CS0672"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0672"
ms.assetid: 140a8708-97d0-444b-980b-62e74328cafb
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) CS0672
Member 'member1' overrides obsolete member 'member2. Add the Obsolete attribute to 'member1'  
  
 The compiler found an <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to a method marked as <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. However, the overriding method was not itself marked as obsolete. The overriding method will still generate [CS0612](../vs140/compiler-warning--level-1--cs0612.md), if called.  
  
 Review your method declarations and explicitly indicate whether a method (and all of its overrides) should be marked <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 The following sample generates CS0672:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>