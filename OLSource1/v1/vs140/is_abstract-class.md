---
title: "is_abstract Class"
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
  - "std.tr1.is_abstract"
  - "std::tr1::is_abstract"
  - "is_abstract"
  - "std.is_abstract"
  - "std::is_abstract"
  - "type_traits/std::is_abstract"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "is_abstract class [TR1]"
  - "is_abstract"
ms.assetid: 8867f660-3434-404c-ba90-c26607a5e0d2
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# is_abstract Class
Tests if type is abstract class.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The type to query.  
  
## Remarks  
 An instance of the type predicate holds true if the type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is a class that has at least one pure virtual function, otherwise it holds false.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **is_abstract\<trivial> == false**  
**is_abstract\<abstract> == true**    
## Requirements  
 **Header:** \<type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [\<type_traits>](../vs140/-type_traits-.md)   
 [is_polymorphic](../vs140/is_polymorphic-class.md)