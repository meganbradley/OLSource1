---
title: "Compiler Error CS0710"
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
  - "CS0710"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0710"
ms.assetid: 753a1a87-f5e5-4758-a960-515069a6c7b0
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0710
Static classes cannot have instance constructors  
  
 A static class cannot be instantiated, hence it has no need for constructors. To avoid this error, remove any constructors from static classes, or if you really want to construct instances, make the class non-static.  
  
 The following sample generates CS0710:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>