---
title: "hash_multimap::upper_bound"
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
  - "std::hash_multimap::upper_bound"
  - "hash_multimap.upper_bound"
  - "upper_bound"
  - "hash_multimap::upper_bound"
  - "hash_map/stdext::hash_multimap::upper_bound"
  - "std.hash_multimap.upper_bound"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "upper_bound method"
ms.assetid: 74264355-306f-470a-bb65-7c674ad89aec
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multimap::upper_bound
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Returns an iterator to the first element in a hash_multimap with a key that is greater than a specified key.  
  
## Syntax  
  
```  
  
      iterator upper_bound(  
   const Key& _Key  
);  
const_iterator upper_bound(  
   const Key& _Key  
) const;  
```  
  
#### Parameters  
 `_Key`  
 The argument key to be compared with the sort key of an element from the hash_multimap being searched.  
  
## Return Value  
 An [iterator](../vs140/hash_multimap--iterator.md) or [const_iterator](../vs140/hash_multimap--const_iterator.md) that addresses the location of an element in a hash_multimap with a key that is greater than the argument key, or that addresses the location succeeding the last element in the hash_multimap if no match is found for the key.  
  
 If the return value of `upper_bound` is assigned to a `const_iterator`, the hash_multimap object cannot be modified. If the return value of `upper_bound` is assigned to a **iterator**, the hash_multimap object can be modified.  
  
## Remarks  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_multimap_upper_bound.cpp  
// compile with: /EHsc  
#include <hash_map>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
   hash_multimap <int, int> hm1;  
   hash_multimap <int, int> :: const_iterator hm1_AcIter, hm1_RcIter;  
   typedef pair <int, int> Int_Pair;  
  
   hm1.insert ( Int_Pair ( 1, 10 ) );  
   hm1.insert ( Int_Pair ( 2, 20 ) );  
   hm1.insert ( Int_Pair ( 3, 30 ) );  
   hm1.insert ( Int_Pair ( 3, 40 ) );  
  
   hm1_RcIter = hm1.upper_bound( 1 );  
   cout << "The 1st element of hash_multimap hm1 with "  
        << "a key greater than 1 is: "  
        << hm1_RcIter -> second << "." << endl;  
  
   hm1_RcIter = hm1.upper_bound( 2 );  
   cout << "The first element of hash_multimap hm1\n with a key "  
        << " greater than 2 is: "  
        << hm1_RcIter -> second << "." << endl;  
  
   // If no match is found for the key, end( ) is returned  
   hm1_RcIter = hm1.lower_bound( 4 );  
  
   if ( hm1_RcIter == hm1.end( ) )  
      cout << "The hash_multimap hm1 doesn't have an element "  
           << "with a key of 4." << endl;  
   else  
      cout << "The element of hash_multimap hm1 with a key of 4 is: "  
           << hm1_RcIter -> second << "." << endl;  
  
   // The element at a specific location in the hash_multimap can be  
   // found using a dereferenced iterator addressing the location  
   hm1_AcIter = hm1.begin( );  
   hm1_RcIter = hm1.upper_bound( hm1_AcIter -> first );  
   cout << "The first element of hm1 with a key greater than"  
        << endl << " that of the initial element of hm1 is: "  
        << hm1_RcIter -> second << "." << endl;  
}  
```  
  
 **The 1st element of hash_multimap hm1 with a key greater than 1 is: 20.**  
**The first element of hash_multimap hm1**  
 **with a key  greater than 2 is: 30.**  
**The hash_multimap hm1 doesn't have an element with a key of 4.**  
**The first element of hm1 with a key greater than**  
 **that of the initial element of hm1 is: 20.**   
## Requirements  
 **Header:** <hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multimap Class](../vs140/hash_multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)