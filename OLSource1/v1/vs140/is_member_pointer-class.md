---
title: "is_member_pointer Class"
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
  - "std::tr1::is_member_pointer"
  - "is_member_pointer"
  - "std.tr1.is_member_pointer"
  - "std.is_member_pointer"
  - "std::is_member_pointer"
  - "type_traits/std::is_member_pointer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "is_member_pointer class [TR1]"
  - "is_member_pointer"
ms.assetid: da07ff4e-9ee0-4baa-ad93-1741f10913d1
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# is_member_pointer Class
Tests if type is a pointer to member.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The type to query.  
  
## Remarks  
 An instance of the type predicate holds true if the type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is a pointer to member function or a pointer to member object, or a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> form of one of them, otherwise it holds false.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **is_member_pointer\<trivial \*> == false**  
**is_member_pointer\<int trivial::\*> == true**  
**is_member_pointer\<int (functional::\*)()> == true**    
## Requirements  
 **Header:** \<type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [\<type_traits>](../vs140/-type_traits-.md)   
 [is_member_function_pointer](../vs140/is_member_function_pointer-class.md)   
 [is_member_object_pointer](../vs140/is_member_object_pointer-class.md)   
 [is_pointer](../vs140/is_pointer-class.md)