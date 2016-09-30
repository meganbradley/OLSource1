---
title: "is_base_of Class"
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
  - "std.tr1.is_base_of"
  - "is_base_of"
  - "std::tr1::is_base_of"
  - "std.is_base_of"
  - "std::is_base_of"
  - "type_traits/std::is_base_of"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "is_base_of class [TR1]"
  - "is_base_of"
ms.assetid: 436f6213-1d4c-4ffc-a588-fc7c4887dd86
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# is_base_of Class
Tests whether one type is base of another.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The base class to test for.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The derived type to test for.  
  
## Remarks  
 An instance of the type predicate holds true if the type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is a base class of the type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, otherwise it holds false.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **is_base_of\<base, base> == true**  
**is_base_of\<base, derived> == true**  
**is_base_of\<derived, base> == false**    
## Requirements  
 **Header:** \<type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [\<type_traits>](../vs140/-type_traits-.md)   
 [is_convertible](../vs140/is_convertible-class.md)