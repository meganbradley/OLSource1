---
title: "Compiler Error C2561"
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
  - "C2561"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2561"
ms.assetid: 0abe955b-53a6-4a3c-8362-b1a8eb40e8d1
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2561
'identifier' : function must return a value  
  
 The function was declared as returning a value, but the function definition does not contain a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> statement.  
  
 This error can be caused by an incorrect function prototype:  
  
1.  If the function does not return a value, declare the function with return type [void](../vs140/void--c---.md).  
  
2.  Check that all possible branches of the function return a value of the type declared in the prototype.  
  
3.  C++ functions containing inline assembly routines that store the return value in the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> register may need a return statement. Copy the value in <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to a temporary variable and return that variable from the function.  
  
 The following sample generates C2561:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>