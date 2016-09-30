---
title: "integral_constant Class, bool_constant Class"
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
  - "std.tr1.integral_constant"
  - "integral_constant"
  - "std::tr1::integral_constant"
  - "std.integral_constant"
  - "std::integral_constant"
  - "type_traits/std::integral_constant"
  - "std.bool_constant"
  - "std::bool_constant"
  - "type_traits/std::bool_constant"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "integral_constant class [TR1]"
  - "integral_constant"
  - "bool_constant"
ms.assetid: 11c002c6-4d31-4042-9341-f2543f43e108
caps.latest.revision: 23
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# integral_constant Class, bool_constant Class
Makes an integral constant from a type and value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The type of the constant.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The value of the constant.  
  
## Remarks  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> template class, when specialized with an integral type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and a value <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> of that type, represents an object that holds a constant of that integral type with the specified value. The member named <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is an alias for the generated template specialization type, and the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> member holds the value <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> used to create the specialization.  
  
 The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> template class is an explicit partial specialization of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> that uses <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> as the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> argument.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **integral_constant\<int, 5> == 5**  
**integral_constant\<bool, false> == false**    
## Requirements  
 **Header:** \<type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [\<type_traits>](../vs140/-type_traits-.md)   
 [false_type](../vs140/-type_traits--typedefs.md#false_type_typedef)   
 [true_type](../vs140/-type_traits--typedefs.md#true_type_typedef)