---
title: "hash_set::insert"
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
  - "Insert"
  - "std::hash_set::insert"
  - "std.hash_set.insert"
  - "hash_set::insert"
  - "hash_set/stdext::hash_set::insert"
  - "hash_set.insert"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "insert method"
ms.assetid: 80dcbb50-31c6-4f23-8b45-b195318f1f15
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_set::insert
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Inserts an element or a range of elements into a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The value of an element to be inserted into the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> unless the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> already contains that element or, more generally, an element whose key is equivalently ordered.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|The place to start searching for the correct point of insertion. (Insertion can occur in amortized constant time, instead of logarithmic time, if the insertion point immediately follows <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.)|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|The position of the first element to be copied from a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|The position just beyond the last element to be copied from a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|The initializer_list from which to copy the elements.|  
  
## Return Value  
 The first <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> member function returns a pair whose <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> component returns <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> if an insertion was make and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> if the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> already contained an element whose key had an equivalent value in the ordering, and whose iterator component returns the address where a new element was inserted or where the element was already located.  
  
 To access the iterator component of a pair <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> returned by this member function, use <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and to dereference it, use <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. To access the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> component of a pair <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> returned by this member function, use <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, and to dereference it, use <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
 The second <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> member function returns an iterator that points to the position where the new element was inserted into the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
## Remarks  
 The third member function inserts the elements in an initializer_list.  
  
 The third member function inserts the sequence of element values into a <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> corresponding to each element addressed by an iterator of in the range [<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>) of a specified <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_set Class](../vs140/hash_set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)