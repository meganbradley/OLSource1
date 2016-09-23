---
title: "Compiler Warning (level 1) C4376"
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
  - C4376
dev_langs: 
  - C++
helpviewer_keywords: 
  - C4376
ms.assetid: 5f202c74-9489-48fe-b36f-19cd882b1589
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Warning (level 1) C4376
access specifier 'old_specifier:' is no longer supported: please use 'new_specifier:' instead  
  
 For more information on specifying type and member accessibility in metadata, see [Type Visibility](../vs140/how-to--define-and-consume-classes-and-structs--c---cli-.md#BKMK_Type_visibility) and [Member Visibility](../vs140/how-to--define-and-consume-classes-and-structs--c---cli-.md#BKMK_Member_visibility) in [How to: Define and Consume Classes and Structs](../vs140/how-to--define-and-consume-classes-and-structs--c---cli-.md).  
  
## Example  
 The following sample generates C4376.  
  
```  
// C4376.cpp  
// compile with: /clr /W1 /c  
public ref class G {  
public public:   // C4376  
   void m2();  
};  
  
public ref class H {  
public:   // OK  
   void m2();  
};  
```