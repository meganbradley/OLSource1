---
title: "partition_copy"
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
  - "std::partition_copy"
  - "std.partition_copy"
  - "algorithm/std::partition_copy"
  - "partition_copy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "partition_copy function"
  - "partition_copy"
ms.assetid: 7e34c266-ca8f-4d97-af04-fb4e651110e2
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# partition_copy
Copies elements for which a condition is <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to one destination, and for which the condition is <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to another. The elements must come from a specified range.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An input iterator that indicates the beginning of a range to check for a condition.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 An input iterator that indicates the end of a range.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 An output iterator used to copy elements that return true for a condition tested by using <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 An output iterator used to copy elements that return false for a condition tested by using <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The condition to test for. This is provided by a user-defined predicate function object that defines the condition to be tested. A predicate takes a single argument and returns <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
## Property Value/Return Value  
 Returns a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> that contains two <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> objects, one that contains elements that exhibit the condition, the other contains elements that do not.  
  
## Remarks  
 The template function copies each element <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is true, or to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. It returns <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [\<algorithm>](../vs140/-algorithm-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)