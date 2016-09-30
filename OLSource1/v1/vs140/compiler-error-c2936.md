---
title: "Compiler Error C2936"
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
  - "C2936"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2936"
ms.assetid: 5d1ba0fc-0c78-4a37-a83b-1ef8527763be
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2936
'class' : type-class-id redefined as a global data variable  
  
 You cannot use a generic or template class as a global data variable.  
  
 This error can be caused if braces are improperly matched.  
  
 The following sample generates C2936:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 C2936 can also occur when using generics:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>