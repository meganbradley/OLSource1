---
title: "Compiler Error C2989"
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
  - "C2989"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2989"
ms.assetid: 936303d8-eb3b-4746-82ec-2f18020a6f64
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2989
'class' : class type has already been declared as a non-class type  
  
 The class generic or template redefines a non-template or non-generic class. Check header files for conflicts.  
  
 If you are using class template partial specializations, see Knowledge Base article Q240866.  
  
 The following sample generates C2989:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 C2989 can also occur when using generics:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>