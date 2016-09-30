---
title: "Compiler Error C2931"
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
  - "C2931"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2931"
ms.assetid: 33430407-b149-4ba3-baf8-b0dae1ea3a5d
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2931
'class' : type-class-id redefined as a member function of 'identifier'  
  
 You cannot use a generic or template class as a member function of another class.  
  
 This error can be caused if braces are improperly matched.  
  
 The following sample generates C2931:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 C2931 can also occur when using generics:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>