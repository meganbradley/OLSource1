---
title: "is_convertible Class"
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
  - "is_convertible"
  - "std.tr1.is_convertible"
  - "std::tr1::is_convertible"
  - "std.is_convertible"
  - "std::is_convertible"
  - "type_traits/std::is_convertible"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "is_convertible class [TR1]"
  - "is_convertible"
ms.assetid: 75614008-1894-42ea-bd57-974399628536
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# is_convertible Class
Tests if one type is convertible to another.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The type to convert from.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The type to convert to.  
  
## Remarks  
 An instance of the type predicate holds true if the expression <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is an object of type <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, is well-formed.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **is_convertible\<trivial, int> == false**  
**is_convertible\<trivial, trivial> == true**  
**is_convertible\<char, int> == true**    
## Requirements  
 **Header:** \<type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [\<type_traits>](../vs140/-type_traits-.md)   
 [is_base_of](../vs140/is_base_of-class.md)