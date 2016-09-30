---
title: "&lt;chrono&gt; functions"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: d6800e15-77a1-4df3-900e-d8b2fee190c7
caps.latest.revision: 13
---
# &lt;chrono&gt; functions
||||  
|-|-|-|  
|[chrono literals](#chrono_literals)|[duration_cast Function](#duration_cast_function)|[time_point_cast Function](#time_point_cast_function)|  
  
##  \<a name="chrono_literals">\</a>  chrono literals  
 (C++14) The \<chrono> header defines 12 [user-defined literals](../vs140/user-defined-literals---c---.md) to facilitate using literals that represent hours, minutes, seconds, milliseconds, microseconds, and nanoseconds. Each user-defined literal has an integral and a floating-point overload. The literals are defined in the literals::chrono_literals inline namespace which is brought into scope automatically when std::chrono is in scope.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
  
### Example  
  The following examples sow how to use the chrono literals.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
##  \<a name="duration_cast_function">\</a>  duration_cast Function  
 Casts a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object to a specified type.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object of type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> that represents the time interval <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, which is truncated if it has to fit into the target type.  
  
### Remarks  
 If <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is an instantiation of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, this function does not participate in overload resolution.  
  
##  \<a name="time_point_cast_function">\</a>  time_point_cast Function  
 Casts a [time_point](../vs140/time_point-class.md) object to a specified type.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object that has a duration of type <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
### Remarks  
 Unless <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is an instantiation of [duration](../vs140/duration-class.md), this function does not participate in overload resolution.  
  
## See Also  
 [&lt;chrono&gt;](../vs140/-chrono-.md)