---
title: "is_pointer Class"
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
  - "std.tr1.is_pointer"
  - "is_pointer"
  - "std::tr1::is_pointer"
  - "std.is_pointer"
  - "std::is_pointer"
  - "type_traits/std::is_pointer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "is_pointer class [TR1]"
  - "is_pointer"
ms.assetid: 44e0a403-7241-4e0a-8922-32877bcb9a4c
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# is_pointer Class
Tests if type is a pointer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The type to query.  
  
## Remarks  
 An instance of the type predicate holds true if the type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is a pointer to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, a pointer to an object, or a pointer to a function, or a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> form of one of them, otherwise it holds false. Note that <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> holds false if <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is a pointer to member or a pointer to member function.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **is_pointer\<trivial> == false**  
**is_pointer\<int trivial::\*> == false**  
**is_pointer\<trivial \*> == true**  
**is_pointer\<int> == false**  
**is_pointer\<int \*> == true**    
## Requirements  
 **Header:** \<type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [\<type_traits>](../vs140/-type_traits-.md)   
 [is_member_pointer](../vs140/is_member_pointer-class.md)   
 [is_reference](../vs140/is_reference-class.md)