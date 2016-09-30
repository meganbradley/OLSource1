---
title: "Compiler Error C2930"
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
  - "C2930"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2930"
ms.assetid: f07eecd1-e5d1-4518-bd89-b1fd2a003a17
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2930
'class' : type-class-id redefined as an enumerator of 'enum identifier'  
  
 You cannot use a generic or template class as a member of an enumeration.  
  
 This error can be caused if braces are improperly matched.  
  
 The following sample generates C2930:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 C2930 can also occur when using generics:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>