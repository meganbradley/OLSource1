---
title: "is_sorted_until"
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
  - "is_sorted_until"
  - "std::is_sorted_until"
  - "std.is_sorted_until"
  - "algorithm/std::is_sorted_until"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "is_sorted_until function"
  - "is_sorted_until"
ms.assetid: 45a79ce4-fbd9-47d1-bcf1-44498ae26de7
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# is_sorted_until
Returns a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> that is set to the last element that is in sorted order from a specified range.  
  
 The second version lets you provide a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> function that returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> when two given elements are in sorted order, and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> otherwise.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A forward iterator that indicates where the range to check starts.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A forward iterator that indicates the end of a range.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The condition to test to determine an order between two elements. A predicate takes a single argument and returns <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Return Value  
 Returns a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> set to the last element in sorted order. The sorted sequence starts from <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
## Remarks  
 The first template function returns the last iterator <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> so that <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is a sorted sequence ordered by <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> the function returns <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
 The second template function behaves the same, except that it replaces <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [is_sorted](../vs140/is_sorted.md)   
 [\<algorithm>](../vs140/-algorithm-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)