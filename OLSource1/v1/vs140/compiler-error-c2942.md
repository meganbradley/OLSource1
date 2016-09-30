---
title: "Compiler Error C2942"
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
  - "C2942"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2942"
ms.assetid: 13abf744-8fa1-450d-886d-e5717c04956e
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2942
'class' : type-class-id redefined as a formal argument of a function  
  
 You cannot use a generic or template class as a formal argument. You cannot pass an argument directly to the constructor of a generic or template class.  
  
 The following sample generates C2942:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 C2942 can also occur when using generics:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>