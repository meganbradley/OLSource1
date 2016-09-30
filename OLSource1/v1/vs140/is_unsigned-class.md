---
title: "is_unsigned Class"
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
  - "std::tr1::is_unsigned"
  - "is_unsigned"
  - "std.tr1.is_unsigned"
  - "std.is_unsigned"
  - "std::is_unsigned"
  - "type_traits/std::is_unsigned"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "is_unsigned class [TR1]"
  - "is_unsigned"
ms.assetid: ba5bec3d-796b-4e54-8595-a3941ec6a8dc
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# is_unsigned Class
Tests if type is unsigned integer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The type to query.  
  
## Remarks  
 An instance of the type predicate holds true if the type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is an unsigned integral type or a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> unsigned integral type, otherwise it holds false.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **is_unsigned\<trivial> == false**  
**is_unsigned\<int> == false**  
**is_unsigned\<unsigned int> == true**  
**is_unsigned\<float> == false**    
## Requirements  
 **Header:** \<type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [\<type_traits>](../vs140/-type_traits-.md)   
 [is_signed](../vs140/is_signed-class.md)