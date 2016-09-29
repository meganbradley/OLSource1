---
title: "hash_multiset::rbegin"
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
  - "std::hash_multiset::rbegin"
  - "hash_multiset.rbegin"
  - "rbegin"
  - "std.hash_multiset.rbegin"
  - "hash_set/stdext::hash_multiset::rbegin"
  - "hash_multiset::rbegin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rbegin method"
ms.assetid: 2050b1ef-96b7-46c9-943a-aff73c3a8d51
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multiset::rbegin
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Returns an iterator addressing the first element in a reversed hash_multiset.  
  
## Syntax  
  
```  
  
      const_reverse_iterator rbegin( ) const;   
reverse_iterator rbegin( );  
```  
  
## Return Value  
 A reverse bidirectional iterator addressing the first element in a reversed hash_multiset or addressing what had been the last element in the unreversed hash_multiset.  
  
## Remarks  
 `rbegin` is used with a reversed hash_multiset just as [begin](../vs140/hash_multiset--begin.md) is used with a hash_multiset.  
  
 If the return value of `rbegin` is assigned to a `const_reverse_iterator`, then the hash_multiset object cannot be modified. If the return value of `rbegin` is assigned to a `reverse_iterator`, then the hash_multiset object can be modified.  
  
 `rbegin` can be used to iterate through a hash_multiset backwards.  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_multiset_rbegin.cpp  
// compile with: /EHsc  
#include <hash_set>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
   hash_multiset <int> hms1;  
   hash_multiset <int>::iterator hms1_Iter;  
   hash_multiset <int>::reverse_iterator hms1_rIter;  
  
   hms1.insert( 10 );  
   hms1.insert( 20 );  
   hms1.insert( 30 );  
  
   hms1_rIter = hms1.rbegin( );  
   cout << "The first element in the reversed hash_multiset is "  
        << *hms1_rIter << "." << endl;  
  
   // begin can be used to start an iteration   
   // throught a hash_multiset in a forward order  
   cout << "The hash_multiset is: ";  
   for ( hms1_Iter = hms1.begin( ) ; hms1_Iter != hms1.end( );  
         hms1_Iter++ )  
      cout << *hms1_Iter << " ";  
   cout << endl;  
  
   // rbegin can be used to start an iteration   
   // throught a hash_multiset in a reverse order  
   cout << "The reversed hash_multiset is: ";  
   for ( hms1_rIter = hms1.rbegin( ) ; hms1_rIter != hms1.rend( );  
         hms1_rIter++ )  
      cout << *hms1_rIter << " ";  
   cout << endl;  
  
   // A hash_multiset element can be erased by dereferencing to its key   
   hms1_rIter = hms1.rbegin( );  
   hms1.erase ( *hms1_rIter );  
  
   hms1_rIter = hms1.rbegin( );  
   cout << "After the erasure, the first element "  
        << "in the reversed hash_multiset is "<< *hms1_rIter << "."  
        << endl;  
}  
```  
  
 **The first element in the reversed hash_multiset is 30.**  
**The hash_multiset is: 10 20 30**   
**The reversed hash_multiset is: 30 20 10**   
**After the erasure, the first element in the reversed hash_multiset is 20.**   
## Requirements  
 **Header:** <hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multiset Class](../vs140/hash_multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)