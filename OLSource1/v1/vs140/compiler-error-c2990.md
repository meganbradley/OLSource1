---
title: "Compiler Error C2990"
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
  - "C2990"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2990"
ms.assetid: 674e9f6a-6743-4af0-a7ed-cbe11103a2f8
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2990
'class' : non-class type as already been declared as a class type  
  
 The non generic or template class redefines a generic or template class. Check header files for conflicts.  
  
 The following sample generates C2990:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 C2990 can also occur when using generics:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 C2990 can also occur due to a breaking change in the Visual C++ compiler for Visual C++ 2005; the compiler now requires that multiple declarations for the same type be identical with respect to template specification.  
  
 The following sample generates C2990:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>