---
title: "Compiler Error C2078"
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
  - "C2078"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2078"
ms.assetid: 9bead850-4123-46cf-a634-5c77ba974b2b
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2078
too many initializers  
  
 The number of initializers exceeds the number of objects to be initialized.  
  
 The compiler can deduce the correct assignment of initializers to objects and inner objects when inner braces are elided from the initializer list. Complete bracing also eliminates ambiguity and results in correct assignment. Partial bracing can cause C2078 because of ambiguity in the assignment of initializers to objects.  
  
 The following sample generates C2078 and shows how to fix it:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>