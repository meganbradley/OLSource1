---
title: "Compiler Error C3482"
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
  - "C3482"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3482"
ms.assetid: bf99558e-bef4-421c-bb16-dcd9c54c1011
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3482
'this' can only be used as a lambda capture within a non-static member function  
  
 You cannot pass `this` to the capture list of a lambda expression that is declared in a static method or a global function.  
  
### To correct this error  
  
-   Convert the enclosing function to a non-static method, or  
  
-   Remove the `this` pointer from the capture list of the lambda expression.  
  
## Example  
 The following example generates C3482:  
  
```  
// C3482.cpp  
// compile with: /c  
  
class C  
{  
public:  
   static void staticMethod()  
   {  
      [this] {}(); // C3482  
   }  
};  
```  
  
## See Also  
 [Lambda Expressions in C++](../vs140/lambda-expressions-in-c--.md)