---
title: "is_trivially_copy_assignable Class"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "is_trivially_copy_assignable"
  - "std.is_trivially_copy_assignable"
  - "std::is_trivially_copy_assignable"
  - "type_traits/std::is_trivially_copy_assignable"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "is_trivially_copy_assignable"
ms.assetid: 7410133e-f367-493f-92a7-e34e3ec5e879
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# is_trivially_copy_assignable Class
Tests whether the type has a trivial copy assignment operator.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The type to query.  
  
## Remarks  
 An instance of the type predicate holds true if the type <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is a class that has a trivial copy assignment operator, otherwise it holds false.  
  
 An assignment constructor for a class <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is trivial if it is implicitly provided, the class <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> has no virtual functions, the class <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> has no virtual bases, the classes of all the non-static data members of class type have trivial assignment operators, and the classes of all the non-static data members of type array of class have trivial assignment operators.  
  
## Requirements  
 **Header:** \<type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [\<type_traits>](../vs140/-type_traits-.md)