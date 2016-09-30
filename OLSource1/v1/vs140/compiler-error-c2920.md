---
title: "Compiler Error C2920"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "C2920"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2920"
ms.assetid: 0a4cb2de-00a0-4209-8160-c7ce6ed7d9ab
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2920
redefinition : 'class' : class template or generic has already been declared as 'type'  
  
 A generic or template class has multiple declarations, which are not equivalent. To fix this error, use different names for different types, or remove the redefinition of the type name.  
  
 The following sample generates C2920 and shows how to fix it:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 C2920 can also occur when using generics:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>