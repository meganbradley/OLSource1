---
title: "hash_map::upper_bound"
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
  - "hash_map::upper_bound"
  - "std::hash_map::upper_bound"
  - "hash_map.upper_bound"
  - "upper_bound"
  - "std.hash_map.upper_bound"
  - "hash_map/stdext::hash_map::upper_bound"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "upper_bound method"
ms.assetid: d5bd4ddc-2b54-48ed-ba98-bd213fee6d56
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_map::upper_bound
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Returns an iterator to the first element in a hash_map that with a key having a value that is greater than that of a specified key.  
  
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
 The argument key value to be compared with the sort key value of an element from the hash_map being searched.  
  
## Return Value  
 An [iterator](../vs140/hash_map--iterator.md) or [const_iterator](../vs140/hash_map--const_iterator.md) that addresses the location of an element in a hash_map that with a key that is greater than the argument key, or that addresses the location succeeding the last element in the hash_map if no match is found for the key.  
  
 If the return value is assigned to a `const_iterator`, the hash_map object cannot be modified. If the return value is assigned to an **iterator**, the hash_map object can be modified.  
  
## Remarks  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_map_upper_bound.cpp  
// compile with: /EHsc  
#include <hash_map>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
   hash_map <int, int> hm1;  
   hash_map <int, int> :: const_iterator hm1_AcIter, hm1_RcIter;  
   typedef pair <int, int> Int_Pair;  
  
   hm1.insert ( Int_Pair ( 1, 10 ) );  
   hm1.insert ( Int_Pair ( 2, 20 ) );  
   hm1.insert ( Int_Pair ( 3, 30 ) );  
  
   hm1_RcIter = hm1.upper_bound( 2 );  
   cout << "The first element of hash_map hm1 with a key "  
        << "greater than 2 is: "  
        << hm1_RcIter -> second << "." << endl;  
  
   // If no match is found for the key, end is returned  
   hm1_RcIter = hm1. upper_bound ( 4 );  
  
   if ( hm1_RcIter == hm1.end( ) )  
      cout << "The hash_map hm1 doesn't have an element "  
           << "with a key greater than 4." << endl;  
   else  
      cout << "The element of hash_map hm1 with a key > 4 is: "  
           << hm1_RcIter -> second << "." << endl;  
  
   // The element at a specific location in the hash_map can be found   
   // using a dereferenced iterator addressing the location  
   hm1_AcIter = hm1.begin( );  
   hm1_RcIter = hm1. upper_bound ( hm1_AcIter -> first );  
   cout << "The 1st element of hm1 with a key greater than "  
        << "that\n of the initial element of hm1 is: "  
        << hm1_RcIter -> second << "." << endl;  
}  
```  
  
 **The first element of hash_map hm1 with a key greater than 2 is: 30.**  
**The hash_map hm1 doesn't have an element with a key greater than 4.**  
**The 1st element of hm1 with a key greater than that**  
 **of the initial element of hm1 is: 20.**   
## Requirements  
 **Header:** <hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_map Class](../vs140/hash_map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)