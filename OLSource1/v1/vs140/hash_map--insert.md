---
title: "hash_map::insert"
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
  - "hash_map::insert"
  - "hash_map.insert"
  - "Insert"
  - "hash_map/stdext::hash_map::insert"
  - "std.hash_map.insert"
  - "std::hash_map::insert"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "insert method"
ms.assetid: e74c8b76-c3e9-4769-a173-cf96167ea005
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_map::insert
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Inserts an element or a range of elements into a hash_map.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The value of an element to be inserted into the hash_map unless the hash_map already contains that element (or, more generally, an element whose key is equivalently ordered).|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|A hint regarding the place to start searching for the correct point of insertion.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|The position of the first element to be copied from a hash_map.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|The position just beyond the last element to be copied from a hash_map.|  
  
## Return Value  
 The first **insert** member function returns a pair whose bool component returns true if an insertion was made and false if the hash_map already contained an element whose key had an equivalent value in the ordering, and whose iterator component returns the address where a new element was inserted or where the element was already located.  
  
 To access the iterator component of a pair <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> returned by this member function, use <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.**first**, and to dereference it, use \*(<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.**first**). To access the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> component of a pair <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> returned by this member function, use <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.**second**, and to dereference it, use \*(<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.**second**).  
  
 The second **insert** member function, the hint version, returns an iterator that points to the position where the new element was inserted into the hash_map.  
  
 The last two **insert** member functions behave the same as the first two, except that they move construct the inserted value.  
  
## Remarks  
 The [value_type](../vs140/map--value_type.md) of an element is a pair, so that the value of an element will be an ordered pair with the first component equal to the key value and the second component equal to the data value of the element.  
  
 Insertion can occur in amortized constant time for the hint version of insert, instead of logarithmic time, if the insertion point immediately follows <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 The third member function inserts the sequence of element values into a hash_map corresponding to each element addressed by an iterator of in the range *[First, Last)* of a specified set.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The original elements (Key => Value) of hm1 are:**  
 **1 => 10**  
 **2 => 20**  
 **3 => 30**  
 **4 => 40**  
**The element 10 already exists in hm1**  
 **with a key value of((pr.first) -> first)= 1.**  
**After the insertions, the elements of hm1 are:**  
 **1 => 10**  
 **2 => 20**  
 **3 => 30**  
 **4 => 40**  
 **5 => 50**  
**After the insertions, the elements of hm2 are:**  
 **2 => 20**  
 **10 => 100**  
 **3 => 30**  
 **4 => 40**  
**After the move insertion, hm3 contains:**  
 **1 => a**  
**After the move insertion, hm4 contains:**  
 **2 => b**   
## Requirements  
 **Header:** \<hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_map Class](../vs140/hash_map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)