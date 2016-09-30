---
title: "Compiler Error C2803"
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
  - "C2803"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2803"
ms.assetid: 2cdbe374-8cc4-4c4e-ba15-062a7479e937
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2803
'operator operator' must have at least one formal parameter of class type  
  
 The overloaded operator lacks a parameter of class type.  
  
 You need to pass at least one parameter by reference (not using pointers, but references) or by value to be able to write "a < b" (a and b being of type class A).  
  
 If both parameters are pointers it will be a pure comparison of pointer addresses and will not use the user-defined conversion.  
  
 The following sample generates C2803:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>