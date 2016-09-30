---
title: "duration_values Structure"
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
  - "chrono/std::chrono::duration_values"
dev_langs: 
  - "C++"
ms.assetid: 7f66d2e3-1faf-47c3-b47e-08f2a87f20e8
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# duration_values Structure
Provides specific values for the [duration](../vs140/duration-class.md) template parameter <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[duration_values::max Method](#duration_values__max_method)|Static. Specifies the upper limit for a value of type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.|  
|[duration_values::min Method](#duration_values__min_method)|Static. Specifies the lower limit for a value of type <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.|  
|[duration_values::zero Method](#duration_values__zero_method)|Static. Returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.|  
  
## Requirements  
 **Header:** chrono  
  
 **Namespace:** std::chrono  
  
##  \<a name="duration_values__max_method">\</a>  duration_values::max Method  
 Static method that returns the upper bound for values of type <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Return Value  
 In effect, returns <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
### Remarks  
 When <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is a user-defined type, the return value must be greater than [duration_values::zero](#duration_values__zero_method).  
  
##  \<a name="duration_values__min_method">\</a>  duration_values::min Method  
 Static method that returns the lower bound for values of type <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 In effect, returns <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
### Remarks  
 When <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is a user-defined type, the return value must be less than or equal to [duration_values::zero](#duration_values__zero_method).  
  
##  \<a name="duration_values__zero_method">\</a>  duration_values::zero Method  
 Returns <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 When <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is a user-defined type, the return value must represent the additive infinity.  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [\<chrono>](../vs140/-chrono-.md)