---
title: "minmax_element"
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
  - "std.minmax_element"
  - "std::minmax_element"
  - "minmax_element"
  - "algorithm/std::minmax_element"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "minmax_element"
  - "minmax_element function"
ms.assetid: a86609c2-5f54-4746-b3fb-601038062b09
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# minmax_element
Performs the work performed by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> in one call.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A forward iterator that indicates the beginning of a range.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A forward iterator that indicates the end of a range.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 An optional test used to order elements.  
  
## Return Value  
 Returns  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> [min_element](../vs140/min_element.md)(<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>), [max_element](../vs140/max_element.md)(<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>)).  
  
## Remarks  
 The first template function returns  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 The second template function behaves the same, except that it replaces <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
 If the sequence is non-empty, the function performs at most <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> comparisons.  
  
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