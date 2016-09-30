---
title: "is_arithmetic Class"
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
  - "is_arithmetic"
  - "std.tr1.is_arithmetic"
  - "std::tr1::is_arithmetic"
  - "std.is_arithmetic"
  - "std::is_arithmetic"
  - "type_traits/std::is_arithmetic"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "is_arithmetic class [TR1]"
  - "is_arithmetic"
ms.assetid: ea427b7e-0141-4a04-848f-561054c53001
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# is_arithmetic Class
Tests if type is arithmetic.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The type to query.  
  
## Remarks  
 An instance of the type predicate holds true if the type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is an arithmetic type, that is, an integral type or a floating point type, or a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> form of one of them, otherwise it holds false.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **is_arithmetic\<trivial> == false**  
**is_arithmetic\<int> == true**  
**is_arithmetic\<float> == true**    
## Requirements  
 **Header:** \<type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [\<type_traits>](../vs140/-type_traits-.md)   
 [is_floating_point](../vs140/is_floating_point-class.md)   
 [is_integral](../vs140/is_integral-class.md)