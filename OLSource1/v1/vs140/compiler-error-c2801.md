---
title: "Compiler Error C2801"
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
  - "C2801"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2801"
ms.assetid: 35dfc7ea-9e37-4e30-baa1-944dc61302f5
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2801
'operator operator' must be a non-static member  
  
 The following operators can be overloaded only as nonstatic members:  
  
-   Assignment `=`  
  
-   Class member access `->`  
  
-   Subscripting `[]`  
  
-   Function call `()`  
  
 Possible C2801 causes:  
  
-   Overloaded operator is not a class, structure, or union member.  
  
-   Overloaded operator is declared `static`.  
  
-   The following sample generates C2801:  
  
```  
// C2801.cpp  
// compile with: /c  
operator[]();   // C2801 not a member  
class A {  
   static operator->();   // C2801 static  
   operator()();   // OK  
};  
```