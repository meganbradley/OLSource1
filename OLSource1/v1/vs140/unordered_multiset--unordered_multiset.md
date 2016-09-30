---
title: "unordered_multiset::unordered_multiset"
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
  - "tr1.unordered_multiset.unordered_multiset"
  - "unordered_multiset::unordered_multiset"
  - "unordered_multiset.unordered_multiset"
  - "unordered_set/std::tr1::unordered_multiset::unordered_multiset"
  - "unordered_multiset"
  - "tr1::unordered_multiset::unordered_multiset"
  - "std.tr1.unordered_multiset.unordered_multiset"
  - "std::tr1::unordered_multiset::unordered_multiset"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "unordered_multiset constructor [TR1]"
  - "unordered_multiset method"
ms.assetid: 2f38c584-cbc2-4094-9a11-03a6d8a60584
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unordered_multiset::unordered_multiset
Constructs a container object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The iterator type.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|The allocator object to store.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|The comparison function object to store.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|The hash function object to store.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|The minimum number of buckets.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|The container to copy.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|The initializer_list from which to copy.|  
  
## Remarks  
 The first constructor specifies a copy of the sequence controlled by <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. The second constructor specifies an empty controlled sequence. The third constructor inserts the sequence of element values <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. The fourth constructor specifies a copy of the sequence by moving <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 All constructors also initialize several stored values. For the copy constructor, the values are obtained from <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. Otherwise:  
  
 The minimum number of buckets is the argument <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, if present; otherwise it is a default value described here as the implementation-defined value <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
 The hash function object is the argument <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, if present; otherwise it is <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
 The comparison function object is the argument <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, if present; otherwise it is <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
 The allocator object is the argument <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, if present; otherwise, it is <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
## Example  
  
### Code  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<unordered_set>  
  
 **Namespace:** std  
  
## See Also  
 [\<unordered_set>](../vs140/-unordered_set-.md)   
 [unordered_multiset](../vs140/unordered_multiset-class.md)