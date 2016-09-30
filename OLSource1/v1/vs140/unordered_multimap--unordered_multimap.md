---
title: "unordered_multimap::unordered_multimap"
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
  - "std::tr1::unordered_multimap::unordered_multimap"
  - "unordered_map/std::tr1::unordered_multimap::unordered_multimap"
  - "tr1.unordered_multimap.unordered_multimap"
  - "unordered_multimap.unordered_multimap"
  - "unordered_multimap::unordered_multimap"
  - "tr1::unordered_multimap::unordered_multimap"
  - "std.tr1.unordered_multimap.unordered_multimap"
  - "unordered_multimap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "unordered_multimap constructor [TR1]"
  - "unordered_multimap method"
ms.assetid: 7d1bb097-55a1-49fc-b59f-c9eb56f7f673
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unordered_multimap::unordered_multimap
Constructs a container object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The iterator type.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The allocator object to store.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|The comparison function object to store.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|The hash function object to store.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|The minimum number of buckets.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|The container to copy.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|The initializer_list from which to copy the elements.|  
  
## Remarks  
 The first constructor specifies a copy of the sequence controlled by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. The second constructor specifies an empty controlled sequence. The third constructor. specifies a copy of the sequence by moving <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. The fourth, fifth, sixth, seventh, and eighth constructors use an initializer_list for the members. The ninth constructor inserts the sequence of element values <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 All constructors also initialize several stored values. For the copy constructor, the values are obtained from <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. Otherwise:  
  
 The minimum number of buckets is the argument <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, if present; otherwise it is a default value described here as the implementation-defined value <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
 The hash function object is the argument <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, if present; otherwise it is <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
 The comparison function object is the argument <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, if present; otherwise it is <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
 The allocator object is the argument <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, if present; otherwise, it is <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **[a, 1] [b, 2] [c, 3] [d, 4] [e, 5] [f, 6] [a, 1] [b, 2] [c, 3] [a, 1] [b, 2] [c, 3] [5, g] [6, h] [7, i] [8, j] [a, 1] [b, 2] [c, 3] [a, 1] [b, 2] [c, 3] [a, 1] [b, 2] [c, 3] [a, 1] [b, 2] [c, 3] [c, 3] [b, 2] [a, 1]**  
 **[f, 6] [e, 5] [d, 4]**  
 **[c, 3] [b, 2] [a, 1]**  
 **[c, 3] [b, 2] [a, 1]**   
## Requirements  
 **Header:** \<unordered_map>  
  
 **Namespace:** std  
  
## See Also  
 [\<unordered_map>](../vs140/-unordered_map-.md)   
 [unordered_multimap](../vs140/unordered_multimap-class.md)