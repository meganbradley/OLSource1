---
title: "Compiler Error C2939"
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
  - "C2939"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2939"
ms.assetid: 455b050b-f2dc-4b5b-bd6a-e1f81d3d1644
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2939
'class' : type-class-id redefined as a local data variable  
  
 You cannot use a generic or template class as a local data variable.  
  
 This error can be caused if braces are improperly matched.  
  
 The following sample generates C2939:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 C2939 can also occur when using generics:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>