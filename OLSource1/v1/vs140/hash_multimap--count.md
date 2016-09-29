---
title: "hash_multimap::count"
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
  - "hash_multimap.count"
  - "std::hash_multimap::count"
  - "hash_multimap::count"
  - "hash_map/stdext::hash_multimap::count"
  - "Count"
  - "std.hash_multimap.count"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "count method"
ms.assetid: 80f06d15-31ce-4eae-b5b3-6c53170b9d95
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multimap::count
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Returns the number of elements in a hash_multimap whose key matches a parameter-specified key.  
  
## Syntax  
  
```  
  
      size_type count(  
   const Key& _Key  
) const;  
```  
  
#### Parameters  
 `_Key`  
 The key of the elements to be matched from the hash_multimap.  
  
## Return Value  
 1 if the hash_multimap contains an element whose sort key matches the parameter key; 0 if the hash_multimap doesn't contain an element with a matching key.  
  
## Remarks  
 The member function returns the number of elements in the range  
  
 **[lower_bound (** `_Key`  **), upper_bound (** `_Key`  **) )**  
  
 which have a key value `_Key`.  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
 The following example demonstrates the use of the hash_multimap::count member function.  
  
```  
// hash_multimap_count.cpp  
// compile with: /EHsc  
#include <hash_map>  
#include <iostream>  
  
int main( )  
{  
    using namespace std;  
    using namespace stdext;  
    hash_multimap<int, int> hm1;  
    hash_multimap<int, int>::size_type i;  
    typedef pair<int, int> Int_Pair;  
  
    hm1.insert(Int_Pair(1, 1));  
    hm1.insert(Int_Pair(2, 1));  
    hm1.insert(Int_Pair(1, 4));  
    hm1.insert(Int_Pair(2, 1));  
  
    // Elements do not need to have unique keys in hash_multimap,  
    // so duplicates are allowed and counted  
    i = hm1.count(1);  
    cout << "The number of elements in hm1 with a sort key of 1 is: "  
         << i << "." << endl;  
  
    i = hm1.count(2);  
    cout << "The number of elements in hm1 with a sort key of 2 is: "  
         << i << "." << endl;  
  
    i = hm1.count(3);  
    cout << "The number of elements in hm1 with a sort key of 3 is: "  
         << i << "." << endl;  
}  
```  
  
 **The number of elements in hm1 with a sort key of 1 is: 2.**  
**The number of elements in hm1 with a sort key of 2 is: 2.**  
**The number of elements in hm1 with a sort key of 3 is: 0.**   
## Requirements  
 **Header:** <hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multimap Class](../vs140/hash_multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)