---
title: "is_integral Class"
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
  - "std::tr1::is_integral"
  - "std.tr1.is_integral"
  - "is_integral"
  - "std.is_integral"
  - "std::is_integral"
  - "type_traits/std::is_integral"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "is_integral class [TR1]"
  - "is_integral"
ms.assetid: fe9279d0-4495-4e88-bf23-153cc6602397
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# is_integral Class
Tests if type is integral.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The type to query.  
  
## Remarks  
 An instance of the type predicate holds true if the type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is one of the integral types, or a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> form of one of the integral types, otherwise it holds false.  
  
 An integral type is one of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. In addition, with compilers that provide them, an integral type can be one of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **is_integral\<trivial> == false**  
**is_integral\<int> == true**  
**is_integral\<float> == false**    
## Requirements  
 **Header:** \<type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [\<type_traits>](../vs140/-type_traits-.md)   
 [is_enum](../vs140/is_enum-class.md)   
 [is_floating_point](../vs140/is_floating_point-class.md)