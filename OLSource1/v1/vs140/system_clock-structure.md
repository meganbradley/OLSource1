---
title: "system_clock Structure"
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
  - "chrono/std::chrono::system_clock"
dev_langs: 
  - "C++"
ms.assetid: a97bd46e-267a-4836-9f7d-af1f664e99ae
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# system_clock Structure
Represents a *clock type* that is based on the real-time clock of the system.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 A *clock type* is used to obtain the current time as UTC. The type embodies an instantiation of [duration](../vs140/duration-class.md) and the class template [time_point](../vs140/time_point-class.md), and defines a static member function <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> that returns the time.  
  
 A clock is *monotonic* if the value that is returned by a first call to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is always less than or equal to the value that is returned by a subsequent call to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 A clock is *steady* if it is *monotonic* and if the time between clock ticks is constant.  
  
 In this implementation, a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is synonymous with a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|A synonym for <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|A synonym for the type that is used to represent the tick period in the contained instantiation of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|A synonym for the type that is used to represent the number of clock ticks in the contained instantiation of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|A synonym for <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is a synonym for either the clock type itself or another clock type that is based on the same epoch and has the same nested <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> type.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[system_clock::from_time_t Method](#system_clock__from_time_t_method)|Static. Returns a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> that most closely approximates a specified time.|  
|[system_clock::now Method](#system_clock__now_method)|Static. Returns the current time.|  
|[system_clock::to_time_t Method](#system_clock__to_time_t_method)|Static. Returns a <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object that most closely approximates a specified <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.|  
  
### Public Constants  
  
|Name|Description|  
|----------|-----------------|  
|[system_clock::is_monotonic Constant](#system_clock__is_monotonic_constant)|Specifies whether the clock type is monotonic.|  
|[system_clock::is_steady Constant](#system_clock__is_steady_constant)|Specifies whether the clock type is steady.|  
  
## Requirements  
 **Header:** chrono  
  
 **Namespace:** std::chrono  
  
##  \<a name="system_clock__from_time_t_method">\</a>  system_clock::from_time_t Method  
 Static method that returns a [time_point](../vs140/time_point-class.md) that most closely approximates the time that is represented by <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 A [time_t](../vs140/standard-types.md) object.  
  
##  \<a name="system_clock__is_monotonic_constant">\</a>  system_clock::is_monotonic Constant  
 Static value that specifies whether the clock type is monotonic.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 In this implementation, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> always returns <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
### Remarks  
 A clock is *monotonic* if the value that is returned by a first call to <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is always less than or equal to the value that is returned by a subsequent call to <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
##  \<a name="system_clock__is_steady_constant">\</a>  system_clock::is_steady Constant  
 Static value that specifies whether the clock type is *steady*.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 In this implementation, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> always returns <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
### Remarks  
 A clock is *steady* if it is [monotonic](#system_clock__is_monotonic_constant) and if the time between clock ticks is constant.  
  
##  \<a name="system_clock__now_method">\</a>  system_clock::now Method  
 Static method that returns the current time.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 A [time_point](../vs140/time_point-class.md) object that represents the current time.  
  
##  \<a name="system_clock__to_time_t_method">\</a>  system_clock::to_time_t Method  
 Static method that returns a [time_t](../vs140/standard-types.md) that most closely approximates the time that is represented by <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 A [time_point](../vs140/time_point-class.md) object.  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [\<chrono>](../vs140/-chrono-.md)   
 [steady_clock Class](../vs140/steady_clock-struct.md)