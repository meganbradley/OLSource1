---
title: "Compiler Warning (level 1) C4930"
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
  - "C4930"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4930"
ms.assetid: 89a206c9-c536-4186-8e81-1cde3e7f4f5b
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4930
'prototype': prototyped function not called (was a variable definition intended?)  
  
 The compiler detected an unused function prototype. If the prototype was intended as a variable declaration, remove the open/close parentheses.  
  
 The following sample generates C4930:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 C4930 can also occur when the compiler cannot distinguish between a function prototype declaration and a function call.  
  
 The following sample generates C4930:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 In the above sample, the result of a method that takes zero arguments is passed as an argument to the constructor of an unnamed local class variable. The call can be disambiguated by either naming the local variable or prefixing the method call with an object instance along with the appropriate pointer-to-member operator.