---
title: "is_fundamental Class"
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
  - "is_fundamental"
  - "std.tr1.is_fundamental"
  - "std::tr1::is_fundamental"
  - "std.is_fundamental"
  - "std::is_fundamental"
  - "type_traits/std::is_fundamental"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "is_fundamental class [TR1]"
  - "is_fundamental"
ms.assetid: b84eee84-2fb2-4611-beaf-b384074d8b6a
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# is_fundamental Class
Tests if type is void or arithmetic.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The type to query.  
  
## Remarks  
 An instance of the type predicate holds true if the type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is a fundamental type, that is, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, an integral type, an floating point type, or a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> form of one of them, otherwise it holds false.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **is_fundamental\<trivial> == false**  
**is_fundamental\<int> == true**  
**is_fundamental\<const float> == true**  
**is_fundamental\<void> == true**    
## Requirements  
 **Header:** \<type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [\<type_traits>](../vs140/-type_traits-.md)   
 [is_compound](../vs140/is_compound-class.md)