---
title: "Compiler Error C2935"
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
  - "C2935"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2935"
ms.assetid: e11ef90d-0756-4e43-8a09-4974c6aa72a3
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2935
'class' : type-class-id redefined as a global function  
  
 You cannot use a generic or template class as a global function.  
  
 This error can be caused if braces are improperly matched.  
  
 The following sample generates C2935:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 C2935 can also occur when using generics:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>