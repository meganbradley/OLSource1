---
title: "Compiler Warning (level 1) C4661"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: error-reference
f1_keywords: 
  - C4661
dev_langs: 
  - C++
helpviewer_keywords: 
  - C4661
ms.assetid: 603bb8b7-356d-4eef-924b-64d769bac5bd
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Warning (level 1) C4661
'identifier' : no suitable definition provided for explicit template instantiation request  
  
 A member of the template class is not defined.  
  
## Example  
  
```  
// C4661.cpp  
// compile with: /W1 /LD  
template<class T> class MyClass {  
public:  
   void i();   // declaration but not definition  
};  
template MyClass< int >;  // C4661  
```