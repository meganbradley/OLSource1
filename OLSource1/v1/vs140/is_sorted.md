---
title: "is_sorted"
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
  - "std::is_sorted"
  - "std.is_sorted"
  - "is_sorted"
  - "algorithm/std::is_sorted"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "is_sorted"
  - "is_sorted function"
ms.assetid: 18be444b-8943-4d55-8d82-a9f6d3e96aef
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# is_sorted
Returns <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if the elements in the specified range are in sorted order.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A forward iterator that indicates where the range to check begins.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A forward iterator that indicates the end of a range.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The condition to test to determine an order between two elements. A predicate takes a single argument and returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. This performs the same task as <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Property Value/Return Value  
 Returns <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> if the elements within the specified range are in sorted order, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> if they're not.  
  
## Remarks  
 The first template function returns [is_sorted_until](assetId:///bbad99d0-deaa-4fe6-ae58-eb5b3e4dded0)<CodeContentPlaceHolder>10\</CodeContentPlaceHolder> <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. The operator< function performs the order comparison.  
  
 The second template function returns <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> predicate function performs the order comparison.  
  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [is_sorted_until](../vs140/is_sorted_until.md)   
 [\<algorithm>](../vs140/-algorithm-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)