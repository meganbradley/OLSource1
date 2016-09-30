---
title: "unordered_set::unordered_set"
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
  - "tr1.unordered_set.unordered_set"
  - "unordered_set.unordered_set"
  - "unordered_set::unordered_set"
  - "std.tr1.unordered_set.unordered_set"
  - "unordered_set"
  - "unordered_set/std::tr1::unordered_set::unordered_set"
  - "tr1::unordered_set::unordered_set"
  - "std::tr1::unordered_set::unordered_set"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "unordered_set constructor [TR1]"
  - "unordered_set method"
ms.assetid: 16bb6e69-a010-44b0-b43b-07508775785e
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unordered_set::unordered_set
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
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|The initializer_list containing the elements to copy.|  
  
## Remarks  
 The first constructor specifies a copy of the sequence controlled by <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. The second constructor specifies an empty controlled sequence. The third constructor specifies a copy of the sequence by moving <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> The fourth through eighth constructors use an initializer_list to specify the elements to copy. The ninth constructor inserts the sequence of element values <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
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
 [unordered_set](../vs140/unordered_set-class.md)