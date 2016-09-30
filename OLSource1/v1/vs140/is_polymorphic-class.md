---
title: "is_polymorphic Class"
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
  - "std.tr1.is_polymorphic"
  - "is_polymorphic"
  - "std::tr1::is_polymorphic"
  - "std.is_polymorphic"
  - "std::is_polymorphic"
  - "type_traits/std::is_polymorphic"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "is_polymorphic class [TR1]"
  - "is_polymorphic"
ms.assetid: 4e1704db-d6f9-4154-a100-0ba02a373f20
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# is_polymorphic Class
Tests if type has a virtual function.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The type to query.  
  
## Remarks  
 An instance of the type predicate holds true if the type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is a class that declares or inherits a virtual function, otherwise it holds false.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **is_polymorphic\<trivial> == false**  
**is_polymorphic\<throws> == true**    
## Requirements  
 **Header:** \<type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [\<type_traits>](../vs140/-type_traits-.md)   
 [is_abstract](../vs140/is_abstract-class.md)