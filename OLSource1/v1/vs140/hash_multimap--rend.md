---
title: "hash_multimap::rend"
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
  - "rend"
  - "hash_map/stdext::hash_multimap::rend"
  - "hash_multimap.rend"
  - "hash_multimap::rend"
  - "std.hash_multimap.rend"
  - "std::hash_multimap::rend"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rend method"
ms.assetid: 57fae7e3-4d0b-4d2e-9043-fb36680576c7
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multimap::rend
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Returns an iterator that addresses the location succeeding the last element in a reversed hash_multimap.  
  
## Syntax  
  
```  
  
      const_reverse_iterator rend( ) const;   
reverse_iterator rend( );  
```  
  
## Return Value  
 A reverse bidirectional iterator that addresses the location succeeding the last element in a reversed hash_multimap (the location that had preceded the first element in the unreversed hash_multimap).  
  
## Remarks  
 `rend` is used with a reversed hash_multimap just as [end](../vs140/hash_multimap--end.md) is used with a hash_multimap.  
  
 If the return value of `rend` is assigned to a [const_reverse_iterator](../vs140/hash_multimap--const_reverse_iterator.md), then the hash_multimap object cannot be modified. If the return value of `rend` is assigned to a [reverse_iterator](../vs140/hash_multimap--reverse_iterator.md), then the hash_multimap object can be modified.  
  
 `rend` can be used to test to whether a reverse iterator has reached the end of its hash_multimap.  
  
 The value returned by `rend` should not be dereferenced.  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_multimap_rend.cpp  
// compile with: /EHsc  
#include <hash_map>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
   hash_multimap <int, int> hm1;  
  
   hash_multimap <int, int> :: iterator hm1_Iter;  
   hash_multimap <int, int> :: reverse_iterator hm1_rIter;  
   hash_multimap <int, int> :: const_reverse_iterator hm1_crIter;  
   typedef pair <int, int> Int_Pair;  
  
   hm1.insert ( Int_Pair ( 1, 10 ) );  
   hm1.insert ( Int_Pair ( 2, 20 ) );  
   hm1.insert ( Int_Pair ( 3, 30 ) );  
  
   hm1_rIter = hm1.rend( );  
   hm1_rIter--;  
   cout << "The last element of the reversed hash_multimap hm1 is "  
        << hm1_rIter -> first << "." << endl;  
  
   // begin can be used to start an iteration   
   // through a hash_multimap in a forward order  
   cout << "The hash_multimap is: ";  
   for ( hm1_Iter = hm1.begin( ) ; hm1_Iter != hm1.end( ); hm1_Iter++)  
      cout << hm1_Iter -> first << " ";  
      cout << "." << endl;  
  
   // rbegin can be used to start an iteration   
   // through a hash_multimap in a reverse order  
   cout << "The reversed hash_multimap is: ";  
   for ( hm1_rIter = hm1.rbegin( ) ; hm1_rIter != hm1.rend( ); hm1_rIter++)  
      cout << hm1_rIter -> first << " ";  
      cout << "." << endl;  
  
   // A hash_multimap element can be erased by dereferencing its key   
   hm1_rIter = --hm1.rend( );  
   hm1.erase ( hm1_rIter -> first );  
  
   hm1_rIter = hm1.rend( );  
   hm1_rIter--;  
   cout << "After the erasure, the last element "  
        << "in the reversed hash_multimap is "  
        << hm1_rIter -> first << "." << endl;  
}  
```  
  
 **The last element of the reversed hash_multimap hm1 is 1.**  
**The hash_multimap is: 1 2 3 .**  
**The reversed hash_multimap is: 3 2 1 .**  
**After the erasure, the last element in the reversed hash_multimap is 2.**   
## Requirements  
 **Header:** <hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multimap Class](../vs140/hash_multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)