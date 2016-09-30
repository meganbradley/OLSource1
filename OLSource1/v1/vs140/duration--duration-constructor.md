---
title: "duration::duration Constructor"
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
  - "chrono/std::chrono::duration::duration"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "chrono::duration constructor"
ms.assetid: 74edebcd-dd48-4b32-ba43-0fd0d08f40c5
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# duration::duration Constructor
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An arithmetic type to represent the number of ticks.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> template specialization to represent the tick period in units of seconds.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The number of ticks of default period.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The number of ticks of period specified by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Remarks  
 The default constructor constructs an object that is uninitialized. Value initialization by using empty braces initializes an object that represents a time interval of zero clock ticks.  
  
 The second, one template argument constructor constructs an object that represents a time interval of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> clock ticks using a default period of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. To avoid round-off of tick counts, it is an error to construct a duration object from a representation type <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> that can be treated as a floating-point type when <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> cannot be treated as a floating-point type.  
  
 The third, two template argument constructor constructs an object that represents a time interval whose length is the time interval that is specified by <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. To avoid truncation of tick counts, it is an error to construct a duration object from another duration object whose type is *incommensurable* with the target type.  
  
 A duration type <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is *incommensurable* with another duration type <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> cannot be treated as a floating-point type and [ratio_divide\<D1::period, D2::period>::type::den](../vs140/-ratio-.md) is not 1.  
  
 Unless <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is implicitly convertible to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and either <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>*holds true* or <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>*holds false*, the second constructor does not participate in overload resolution. For more information, see [\<type_traits>](../vs140/-type_traits-.md).  
  
 Unless no overflow is induced in the conversion and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>*holds true*,  or both <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> equals 1 and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>*holds false*, the third constructor does not participate in overload resolution. For more information, see [\<type_traits>](../vs140/-type_traits-.md).  
  
## Requirements  
 **Header:** chrono  
  
 **Namespace:** std::chrono  
  
## See Also  
 [duration Class](../vs140/duration-class.md)   
 [\<chrono>](../vs140/-chrono-.md)   
 [treat_as_floating_point Structure](../vs140/treat_as_floating_point-structure.md)