---
title: "hash_multimap::swap"
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
  - "hash_map/stdext::hash_multimap::swap"
  - "stdext.hash_multimap.swap"
  - "hash_multimap::swap"
  - "std.hash_multimap.swap"
  - "hash_multimap.swap"
  - "swap"
  - "std::hash_multimap::swap"
  - "stdext::hash_multimap::swap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "swap method"
ms.assetid: 22b18178-49a7-4fb5-8f2a-220b21eafe32
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multimap::swap
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Exchanges the elements of two hash_multimaps.  
  
## Syntax  
  
```  
  
      void swap(  
   hash_multimap& _Right  
);  
```  
  
#### Parameters  
 `_Right`  
 The hash_multimap providing the elements to be swapped or the hash_multimap whose elements are to be exchanged with those of the hash_multimap.  
  
## Remarks  
 The member function invalidates no references, pointers, or iterators that designate elements in the two hash_multimaps whose elements are being exchanged.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_multimap_swap.cpp  
// compile with: /EHsc  
#include <hash_map>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
   hash_multimap <int, int> hm1, hm2, hm3;  
   hash_multimap <int, int>::iterator hm1_Iter;  
   typedef pair <int, int> Int_Pair;  
  
   hm1.insert ( Int_Pair ( 1, 10 ) );  
   hm1.insert ( Int_Pair ( 2, 20 ) );  
   hm1.insert ( Int_Pair ( 3, 30 ) );  
   hm2.insert ( Int_Pair ( 10, 100 ) );  
   hm2.insert ( Int_Pair ( 20, 200 ) );  
   hm3.insert ( Int_Pair ( 30, 300 ) );  
  
   cout << "The original hash_multimap hm1 is:";  
   for ( hm1_Iter = hm1.begin( ); hm1_Iter != hm1.end( ); hm1_Iter++ )  
      cout << " " << hm1_Iter -> second;  
   cout   << "." << endl;  
  
   // This is the member function version of swap  
   hm1.swap( hm2 );  
  
   cout << "After swapping with hm2, hash_multimap hm1 is:";  
   for ( hm1_Iter = hm1.begin( ); hm1_Iter != hm1.end( ); hm1_Iter++ )  
      cout << " " << hm1_Iter -> second;  
   cout  << "." << endl;  
  
   // This is the specialized template version of swap  
   swap( hm1, hm3 );  
  
   cout << "After swapping with hm3, hash_multimap hm1 is:";  
   for ( hm1_Iter = hm1.begin( ); hm1_Iter != hm1.end( ); hm1_Iter++ )  
      cout << " " << hm1_Iter -> second;  
   cout   << "." << endl;  
}  
```  
  
 **The original hash_multimap hm1 is: 10 20 30.**  
**After swapping with hm2, hash_multimap hm1 is: 100 200.**  
**After swapping with hm3, hash_multimap hm1 is: 300.**   
## Requirements  
 **Header:** \<hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multimap Class](../vs140/hash_multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)