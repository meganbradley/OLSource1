---
title: "is_default_constructible Class"
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
  - "is_default_constructible"
  - "std.is_default_constructible"
  - "std::is_default_constructible"
  - "type_traits/std::is_default_constructible"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "is_default_constructible"
ms.assetid: dd8f1c44-dae5-4258-891f-c5e048d94092
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# is_default_constructible Class
Tests if a type has a default constructor.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The type to query.  
  
## Remarks  
 An instance of the type predicate holds true if the type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is a class type that has a default constructor, otherwise it holds false. This is equivalent to the predicate <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. Type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> must be a complete type, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, or an array of unknown bound.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **is_default_constructible\<Simple> == true**  
**is_default_constructible\<Simple2> == false**   
## Requirements  
 **Header:** \<type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [\<type_traits>](../vs140/-type_traits-.md)