---
title: "hash_map::count"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - hash_map/stdext::hash_map::count
  - hash_map.count
  - hash_map::count
  - count
  - std::hash_map::count
  - std.hash_map.count
dev_langs: 
  - C++
helpviewer_keywords: 
  - count method
ms.assetid: f0c92e07-6cd0-4732-ae17-e273ced33411
caps.latest.revision: 23
translation.priority.ht: 
  - de-de
  - ja-jp
---
# hash_map::count
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Returns the number of elements in a hash_map whose key matches a parameter-specified key.  
  
## Syntax  
  
```  
  
      size_type count(  
   const Key& _Key  
) const;  
```  
  
#### Parameters  
 `_Key`  
 The key value of the elements to be matched from the hash_map.  
  
## Return Value  
 1 if the hash_map contains an element whose sort key matches the parameter key; 0 if the hash_map doesn't contain an element with a matching key.  
  
## Remarks  
 The member function returns the number of elements *x* in the range  
  
 [`lower_bound` (_*Key* ), `upper_bound` (\_*Key* ) )  
  
 which is 0 or 1 in the case of hash_map, which is a unique associative container.  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
 The following example demonstrates the use of the hash_map::count member function.  
  
```  
// hash_map_count.cpp  
// compile with: /EHsc  
#include <hash_map>  
#include <iostream>  
  
int main()  
{  
    using namespace std;  
    using namespace stdext;  
    hash_map<int, int> hm1;  
    hash_map<int, int>::size_type i;  
    typedef pair<int, int> Int_Pair;  
  
    hm1.insert(Int_Pair (1, 1));  
    hm1.insert(Int_Pair (2, 1));  
    hm1.insert(Int_Pair (1, 4));  
    hm1.insert(Int_Pair (2, 1));  
  
    // Keys must be unique in hash_map, so duplicates are ignored  
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
  
 **The number of elements in hm1 with a sort key of 1 is: 1.**  
**The number of elements in hm1 with a sort key of 2 is: 1.**  
**The number of elements in hm1 with a sort key of 3 is: 0.**   
## Requirements  
 **Header:** <hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_map Class](../vs140/hash_map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)