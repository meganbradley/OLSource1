---
title: "hash_multiset::insert"
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
  - "stdext::hash_multiset::insert"
  - "Insert"
  - "insert"
  - "hash_multiset::insert"
  - "std::hash_multiset::insert"
  - "stdext.hash_multiset.insert"
  - "hash_multiset.insert"
  - "std.hash_multiset.insert"
  - "hash_set/stdext::hash_multiset::insert"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "insert method"
ms.assetid: 44cea9f3-8077-4fb2-9956-f3e732fc02ad
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multiset::insert
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Inserts an element or a range of elements into a hash_multiset.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|The value of an element to be inserted into the hash_multiset unless the hash_multiset already contains that element or, more generally, an element whose key is equivalently ordered.|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The place to start searching for the correct point of insertion. (Insertion can occur in amortized constant time, instead of logarithmic time, if the insertion point immediately follows <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.)|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|The position of the first element to be copied from a hash_multiset.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|The position just beyond the last element to be copied from a hash_multiset.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|The initializer_list that contains the elements to copy.|  
  
## Return Value  
 The first two insert member functions return an iterator that points to the position where the new element was inserted.  
  
 The next three member functions use an initializer_list.  
  
 The third member function inserts the sequence of element values into a hash_multiset corresponding to each element addressed by an iterator of in the range [<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>) of a specified hash_multiset.  
  
## Remarks  
 Insertion can occur in amortized constant time for the hint version of insert, instead of logarithmic time, if the insertion point immediately follows <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multiset Class](../vs140/hash_multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)