---
title: "Compiler Warning (level 4) C4815"
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
  - "C4815"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4815"
ms.assetid: 99081928-d7d5-4dce-b4af-7c6a151bfac0
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 4) C4815
'var' : zero-sized array in stack object will have no elements (unless the object is an aggregate that has been aggregate initialized)  
  
 An array with an undefined number of elements (zero-sized array) is the last member of a type and an object of the type was created on the stack. No memory will be allocated for the array. If you need a useful constructor, you can allocate memory for the struct on the heap.  
  
 The following sample generates C4815:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>