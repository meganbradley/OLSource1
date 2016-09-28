---
title: "hash_multiset::swap"
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
  - "stdext.hash_multiset.swap"
  - "std.hash_multiset.swap"
  - "hash_multiset.swap"
  - "hash_set/stdext::hash_multiset::swap"
  - "hash_multiset::swap"
  - "swap"
  - "std::hash_multiset::swap"
  - "stdext::hash_multiset::swap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "swap method"
ms.assetid: 28f3c5f0-7260-4383-a032-3c8e8a22944d
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multiset::swap
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Exchanges the elements of two hash_multisets.  
  
## Syntax  
  
```  
  
      void swap(  
   hash_multiset& _Right  
);  
```  
  
#### Parameters  
 `_Right`  
 The argument hash_multiset providing the elements to be swapped with the target hash_multiset.  
  
## Remarks  
 The member function invalidates no references, pointers, or iterators that designate elements in the two hash_multisets whose elements are being exchanged.  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_multiset_swap.cpp  
// compile with: /EHsc  
#include <hash_set>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
   hash_multiset <int> hms1, hms2, hms3;  
   hash_multiset <int>::iterator hms1_Iter;  
  
   hms1.insert( 10 );  
   hms1.insert( 20 );  
   hms1.insert( 30 );  
   hms2.insert( 100 );  
   hms2.insert( 200 );  
   hms3.insert( 300 );  
  
   cout << "The original hash_multiset hms1 is:";  
   for ( hms1_Iter = hms1.begin( ); hms1_Iter != hms1.end( );  
         hms1_Iter++ )  
         cout << " " << *hms1_Iter;  
   cout   << "." << endl;  
  
   // This is the member function version of swap  
   hms1.swap( hms2 );  
  
   cout << "After swapping with hms2, list hms1 is:";  
   for ( hms1_Iter = hms1.begin( ); hms1_Iter != hms1.end( );  
         hms1_Iter++ )  
         cout << " " << *hms1_Iter;  
   cout  << "." << endl;  
  
   // This is the specialized template version of swap  
   swap( hms1, hms3 );  
  
   cout << "After swapping with hms3, list hms1 is:";  
   for ( hms1_Iter = hms1.begin( ); hms1_Iter != hms1.end( );  
         hms1_Iter++ )  
         cout << " " << *hms1_Iter;  
   cout   << "." << endl;  
}  
```  
  
 **The original hash_multiset hms1 is: 10 20 30.**  
**After swapping with hms2, list hms1 is: 200 100.**  
**After swapping with hms3, list hms1 is: 300.**   
## Requirements  
 **Header:** <hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multiset Class](../vs140/hash_multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)