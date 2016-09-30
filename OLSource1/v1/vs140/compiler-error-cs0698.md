---
title: "Compiler Error CS0698"
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
  - "CS0698"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0698"
ms.assetid: 68211652-fdfa-4d37-9451-f0b4238f9fe6
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0698
A generic type cannot derive from 'class' because it is an attribute class  
  
 Any class that derives from an attribute class is an attribute. Attributes are not allowed to be generic types.  
  
 The following sample generates CS0698:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>