---
title: "Compiler Error C2355"
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
  - "C2355"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2355"
ms.assetid: 0a947881-d61f-4f98-8409-32140f39500b
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2355
'this' : can only be referenced inside non-static member functions or non-static data member initializers  
  
 The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> pointer is valid only within non-static member functions or in non-static data member initializers. This error can result when the class scope of a member function definition outside of the class declaration is not properly qualified. The error can also occur when the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> pointer is used in a function that is not declared in the class.  
  
 To fix this issue, make sure the member function definition matches a member function declaration in the class, and that it is not declared static. For data member initializers, make sure the data member is not declared static.  
  
 The following sample generates C2355 and shows how to fix it:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>