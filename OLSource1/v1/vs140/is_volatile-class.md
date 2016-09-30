---
title: "is_volatile Class"
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
  - "std::tr1::is_volatile"
  - "std.tr1.is_volatile"
  - "is_volatile"
  - "std.is_volatile"
  - "std::is_volatile"
  - "type_traits/std::is_volatile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "is_volatile class [TR1]"
  - "is_volatile"
ms.assetid: 54922e8a-db4e-4cae-8931-b3352f0b8d3b
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# is_volatile Class
Tests if type is volatile.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The type to query.  
  
## Remarks  
 An instance of the type predicate holds true if <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **is_volatile\<trivial> == false**  
**is_volatile\<volatile trivial> == true**  
**is_volatile\<int> == false**  
**is_volatile\<volatile int> == true**    
## Requirements  
 **Header:** \<type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [\<type_traits>](../vs140/-type_traits-.md)   
 [is_const](../vs140/is_const-class.md)