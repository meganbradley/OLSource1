---
title: "hash_multiset::lower_bound"
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
  - "std::hash_multiset::lower_bound"
  - "hash_set/stdext::hash_multiset::lower_bound"
  - "lower_bound"
  - "std.hash_multiset.lower_bound"
  - "hash_multiset.lower_bound"
  - "hash_multiset::lower_bound"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "lower_bound function"
ms.assetid: 2b80e1be-03b4-4088-aa41-ae7f9d268448
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multiset::lower_bound
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Returns an iterator to the first element in a hash_multiset with a key that is equal to or greater than a specified key.  
  
## Syntax  
  
```  
  
      const_iterator lower_bound(  
   const Key& _Key  
) const;  
iterator lower_bound(  
   const Key& _Key  
);  
```  
  
#### Parameters  
 `_Key`  
 The argument key to be compared with the sort key of an element from the hash_multiset being searched.  
  
## Return Value  
 An [iterator](../vs140/hash_multiset--iterator.md) or [const_iterator](../vs140/hash_multiset--const_iterator.md) that addresses the location of the first element in a hash_multiset with a key that is equal to or greater than the argument key, or that addresses the location succeeding the last element in the hash_multiset if no match is found for the key.  
  
## Remarks  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_multiset_lower_bound.cpp  
// compile with: /EHsc  
#include <hash_set>  
#include <iostream>  
  
int main() {  
   using namespace std;  
   using namespace stdext;  
   hash_multiset <int> hms1;  
   hash_multiset <int> :: const_iterator hms1_AcIter, hms1_RcIter;  
  
   hms1.insert( 10 );  
   hms1.insert( 20 );  
   hms1.insert( 30 );  
  
   hms1_RcIter = hms1.lower_bound( 20 );  
   cout << "The element of hash_multiset hms1 with a key of 20 is: "  
        << *hms1_RcIter << "." << endl;  
  
   hms1_RcIter = hms1.lower_bound( 40 );  
  
   // If no match is found for the key, end( ) is returned  
   if ( hms1_RcIter == hms1.end( ) )  
      cout << "The hash_multiset hms1 doesn't have an element "  
           << "with a key of 40." << endl;  
   else  
      cout << "The element of hash_multiset hms1 with a key of 40 is: "  
           << *hms1_RcIter << "." << endl;  
  
   // An element at a specific location in the hash_multiset can be found   
   // by using a dereferenced iterator that addresses the location  
   hms1_AcIter = hms1.end( );  
   hms1_AcIter--;  
   hms1_RcIter = hms1.lower_bound( *hms1_AcIter );  
   cout << "The element of hms1 with a key matching "  
        << "that of the last element is: "  
        << *hms1_RcIter << "." << endl;  
}  
```  
  
## Output  
  
```  
The element of hash_multiset hms1 with a key of 20 is: 20.  
The hash_multiset hms1 doesn't have an element with a key of 40.  
The element of hms1 with a key matching that of the last element is: 30.  
```  
  
## Requirements  
 **Header:** <hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multiset Class](../vs140/hash_multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)