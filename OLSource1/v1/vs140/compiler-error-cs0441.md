---
title: "Compiler Error CS0441"
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
  - "CS0441"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0441"
ms.assetid: 3f07500a-d479-424c-a0f4-c219be1b5a45
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0441
'class': a class cannot be both static and sealed  
  
 This error occurs when you declare a class that is both static and sealed. Static classes are inherently sealed, so the sealed modifier is not necessary. To resolve, use one modifier only.  
  
 The following example generates CS0441:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>