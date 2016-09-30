---
title: "unordered_map::unordered_map"
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
  - "unordered_map/std::tr1::unordered_map::unordered_map"
  - "unordered_map::unordered_map"
  - "std::tr1::unordered_map::unordered_map"
  - "tr1.unordered_map.unordered_map"
  - "unordered_map"
  - "unordered_map.unordered_map"
  - "std.tr1.unordered_map.unordered_map"
  - "tr1::unordered_map::unordered_map"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "unordered_map constructor [TR1]"
  - "unordered_map method"
ms.assetid: 0dbb1be3-8792-42d6-9760-3bcb4b8e0046
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unordered_map::unordered_map
Constructs a container object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The allocator object to store.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The comparison function object to store.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|The hash function object to store.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|The minimum number of buckets.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|The container to copy.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>||  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>||  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|The initializer_list that contains the elements to be copied.|  
  
## Remarks  
 The first constructor specifies a copy of the sequence controlled by <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. The second constructor specifies an empty controlled sequence. The third constructor inserts the sequence of element values <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. The fourth constructor specifies a copy of the sequence by moving <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 All constructors also initialize several stored values. For the copy constructor, the values are obtained from <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. Otherwise:  
  
 the minimum number of buckets is the argument <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, if present; otherwise it is a default value described here as the implementation-defined value <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
 the hash function object is the argument <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, if present; otherwise it is <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
 The comparison function object is the argument <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, if present; otherwise it is <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
 The allocator object is the argument <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, if present; otherwise, it is <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **[a, 1] [b, 2] [c, 3] [d, 4] [e, 5] [f, 6] [a, 1] [b, 2] [c, 3] [a, 1] [b, 2] [c, 3] [5, g] [6, h] [7, i] [8, j] [5, g] [6, h] [7, i] [8, j] [5, g] [6, h] [7, i] [8, j] [5, g] [6, h] [7, i] [8, j] [5, g] [6, h] [7, i] [8, j]**   
## Requirements  
 **Header:** \<unordered_map>  
  
 **Namespace:** std  
  
## See Also  
 [\<unordered_map>](../vs140/-unordered_map-.md)   
 [unordered_map](../vs140/unordered_map-class.md)