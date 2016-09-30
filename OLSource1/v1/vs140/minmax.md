---
title: "minmax"
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
  - "std::minmax"
  - "std.minmax"
  - "minmax"
  - "xutility/std::minmax"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "minmax"
  - "minmax function"
ms.assetid: 83ba8b0d-6fec-4aa8-8e41-ec2eed73e7a2
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# minmax
Compares two input parameters and returns them as a pair, in order of lesser to greater.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The first of the two objects being compared.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The second of the two objects being compared.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A binary predicate used to compare the two objects.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The initializer_list that contains the members to be compared.  
  
## Return Value  
 Returns a pair of objects where the first is the lesser and the second is the greater. In the case of an initializer_list, the pair is the least object and the greatest object in the list.  
  
## Remarks  
 The first template function returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is less than <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. Otherwise, it returns <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 The second member function returns a pair where the first element is the lesser and the second is the greater when compared by the predicate <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 The remaining template functions behave the same, except that they replace the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> parameters with <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
 The function performs exactly one comparison.  
  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [minmax_element](../vs140/minmax_element.md)   
 [min](../vs140/min.md)   
 [min_element](../vs140/min_element.md)   
 [max](../vs140/max.md)   
 [max_element](../vs140/max_element.md)   
 [\<algorithm>](../vs140/-algorithm-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)