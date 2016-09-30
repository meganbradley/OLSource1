---
title: "is_same Class"
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
  - "std::tr1::is_same"
  - "std.tr1.is_same"
  - "is_same"
  - "std.is_same"
  - "std::is_same"
  - "type_traits/std::is_same"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "is_same class [TR1]"
  - "is_same"
ms.assetid: d9df6c1d-c270-4ec2-802a-af275648dd1d
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# is_same Class
Tests if two types are the same.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The first type to query.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The second type to query.  
  
## Remarks  
 An instance of the type predicate holds true if the types <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> are the same type, otherwise it holds false.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **is_same\<base, base> == true**  
**is_same\<base, derived> == false**  
**is_same\<derived, base> == false**  
**is_same\<int, int> == true**  
**is_same\<int, const int> == false**    
## Requirements  
 **Header:** \<type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [\<type_traits>](../vs140/-type_traits-.md)   
 [is_convertible](../vs140/is_convertible-class.md)   
 [is_base_of](../vs140/is_base_of-class.md)