---
title: "hash_map::end"
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
  - "std.hash_map.end"
  - "std::hash_map::end"
  - "hash_map/stdext::hash_map::end"
  - "hash_map::end"
  - "hash_map.end"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "end method"
ms.assetid: b8cd9a77-9039-43cc-86a9-606078b97d40
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_map::end
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Returns an iterator that addresses the location succeeding the last element in a hash_map.  
  
## Syntax  
  
```  
  
      const_iterator end( ) const;   
iterator end( );  
```  
  
## Return Value  
 A bidirectional iterator that addresses the location succeeding the last element in a hash_map. If the hash_map is empty, then hash_map::end == hash_map::begin.  
  
## Remarks  
 **end** is used to test whether an iterator has reached the end of its hash_map.  
  
 The value returned by **end** should not be dereferenced.  
  
## Example  
  
```  
// hash_map_end.cpp  
// compile with: /EHsc  
#include <hash_map>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
   using namespace stdext;  
   hash_map <int, int> hm1;  
  
   hash_map <int, int> :: iterator hm1_Iter;  
   hash_map <int, int> :: const_iterator hm1_cIter;  
   typedef pair <int, int> Int_Pair;  
  
   hm1.insert ( Int_Pair ( 1, 10 ) );  
   hm1.insert ( Int_Pair ( 2, 20 ) );  
   hm1.insert ( Int_Pair ( 3, 30 ) );  
  
   hm1_cIter = hm1.end( );  
   hm1_cIter--;  
   cout << "The value of last element of hm1 is "   
        << hm1_cIter -> second << "." << endl;  
  
   hm1_Iter = hm1.end( );  
   hm1_Iter--;  
   hm1.erase ( hm1_Iter );  
  
   // The following 2 lines would err because the iterator is const  
   // hm1_cIter = hm1.end ( );  
   // hm1_cIter--;  
   // hm1.erase ( hm1_cIter );  
  
   hm1_cIter = hm1.end( );  
   hm1_cIter--;  
   cout << "The value of last element of hm1 is now "  
        << hm1_cIter -> second << "." << endl;  
}  
```  
  
 **The value of last element of hm1 is 30.**  
**The value of last element of hm1 is now 20.**   
## Requirements  
 **Header:** \<hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_map Class](../vs140/hash_map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)