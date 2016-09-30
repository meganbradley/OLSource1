---
title: "Compiler Error C3354"
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
  - "C3354"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3354"
ms.assetid: 185de401-231e-4999-a149-172ee4c69d84
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3354
'function' : the function used to create a delegate cannot have return type 'type'  
  
 The following types are invalid as return types for a [delegate](../vs140/__delegate.md):  
  
-   Pointer to function  
  
-   Pointer to member  
  
-   Pointer to member function  
  
-   Reference to function  
  
-   Reference to member function  
  
 The following sample generates C3354:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The following sample generates C3354:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>