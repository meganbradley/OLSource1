---
title: "steady_clock struct"
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
  - "chrono/std::chrono::steady_clock"
dev_langs: 
  - "C++"
ms.assetid: 970d12ec-fc80-4391-a2f7-b57b2aec668d
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# steady_clock struct
Represents a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> clock.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 On Windows, steady_clock wraps the QueryPerformanceCounter function.  
  
 A clock is *monotonic* if the value that is returned by a first call to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is always less than or equal to the value that is returned by a subsequent call to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 A clock is *steady* if it is *monotonic* and if the time between clock ticks is constant.  
  
 High_resolution_clock is a typdef for steady_clock.  
  
## Public functions  
  
|Function|Description|  
|--------------|-----------------|  
|now|Returns the current time as a time_point value.|  
  
## Public Constants  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Holds <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. A <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is *steady*.|  
  
## Requirements  
 **Header:** chrono  
  
 **Namespace:** std::chrono  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [\<chrono>](../vs140/-chrono-.md)   
 [system_clock Structure](../vs140/system_clock-structure.md)