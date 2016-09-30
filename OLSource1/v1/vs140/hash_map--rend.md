---
title: "hash_map::rend"
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
  - "hash_map/stdext::hash_map::rend"
  - "hash_map::rend"
  - "hash_map.rend"
  - "std::hash_map::rend"
  - "std.hash_map.rend"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rend method"
ms.assetid: 08c371bc-a9a0-4447-8454-b26bddaca071
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_map::rend
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Returns an iterator that addresses the location succeeding the last element in a reversed hash_map.  
  
## Syntax  
  
```  
  
      const_reverse_iterator rend( ) const;   
reverse_iterator rend( );  
```  
  
## Return Value  
 A reverse bidirectional iterator that addresses the location succeeding the last element in a reversed hash_map (the location that had preceded the first element in the unreversed hash_map).  
  
## Remarks  
 `rend` is used with a reversed hash_map just as [end](../vs140/hash_map--end.md) is used with a hash_map.  
  
 If the return value of `rend` is assigned to a [const_reverse_iterator](../vs140/hash_map--const_reverse_iterator.md), then the hash_map object cannot be modified. If the return value of `rend` is assigned to a [reverse_iterator](../vs140/hash_map--reverse_iterator.md), then the hash_map object can be modified.  
  
 `rend` can be used to test to whether a reverse iterator has reached the end of its hash_map.  
  
 The value returned by `rend` should not be dereferenced.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_map_rend.cpp  
// compile with: /EHsc  
#include <hash_map>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
   hash_map <int, int> hm1;  
  
   hash_map <int, int> :: iterator hm1_Iter;  
   hash_map <int, int> :: reverse_iterator hm1_rIter;  
   hash_map <int, int> :: const_reverse_iterator hm1_crIter;  
   typedef pair <int, int> Int_Pair;  
  
   hm1.insert ( Int_Pair ( 1, 10 ) );  
   hm1.insert ( Int_Pair ( 2, 20 ) );  
   hm1.insert ( Int_Pair ( 3, 30 ) );  
  
   hm1_rIter = hm1.rend( );  
   hm1_rIter--;  
   cout << "The last element of the reversed hash_map hm1 is "  
        << hm1_rIter -> first << "." << endl;  
  
   // begin can be used to start an iteration   
   // through a hash_map in a forward order  
   cout << "The hash_map is: ";  
   for ( hm1_Iter = hm1.begin( ) ; hm1_Iter != hm1.end( );  
   hm1_Iter++)  
      cout << hm1_Iter -> first << " ";  
      cout << "." << endl;  
  
   // rbegin can be used to start an iteration   
   // through a hash_map in a reverse order  
   cout << "The reversed hash_map is: ";  
   for ( hm1_rIter = hm1.rbegin( ) ; hm1_rIter != hm1.rend( );  
      hm1_rIter++)  
      cout << hm1_rIter -> first << " ";  
      cout << "." << endl;  
  
   // A hash_map element can be erased by dereferencing to its key   
   hm1_rIter = --hm1.rend( );  
   hm1.erase ( hm1_rIter -> first );  
  
   hm1_rIter = hm1.rend( );  
   hm1_rIter--;  
   cout << "After the erasure, the last element "  
        << "in the reversed hash_map is "  
        << hm1_rIter -> first << "." << endl;  
}  
```  
  
 **The last element of the reversed hash_map hm1 is 1.**  
**The hash_map is: 1 2 3 .**  
**The reversed hash_map is: 3 2 1 .**  
**After the erasure, the last element in the reversed hash_map is 2.**   
## Requirements  
 **Header:** \<hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_map Class](../vs140/hash_map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)