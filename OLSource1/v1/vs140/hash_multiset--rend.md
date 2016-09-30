---
title: "hash_multiset::rend"
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
  - "std::hash_multiset::rend"
  - "std.hash_multiset.rend"
  - "hash_multiset::rend"
  - "hash_multiset.rend"
  - "hash_set/stdext::hash_multiset::rend"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rend method"
ms.assetid: 7ac686f1-ee67-4889-95c7-32438d8ab37a
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multiset::rend
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Returns an iterator that addresses the location succeeding the last element in a reversed hash_multiset.  
  
## Syntax  
  
```  
  
      const_reverse_iterator rend( ) const;   
reverse_iterator rend( );  
```  
  
## Return Value  
 A reverse bidirectional iterator that addresses the location succeeding the last element in a reversed hash_multiset (the location that had preceded the first element in the unreversed hash_multiset).  
  
## Remarks  
 `rend` is used with a reversed hash_multiset just as [end](../vs140/hash_multiset--end.md) is used with a hash_multiset.  
  
 If the return value of `rend` is assigned to a `const_reverse_iterator`, then the hash_multiset object cannot be modified. If the return value of `rend` is assigned to a `reverse_iterator`, then the hash_multiset object can be modified. The value returned by `rend` should not be dereferenced.  
  
 `rend` can be used to test to whether a reverse iterator has reached the end of its hash_multiset.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_multiset_rend.cpp  
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
   hash_multiset <int>::const_reverse_iterator hms1_crIter;  
  
   hms1.insert( 10 );  
   hms1.insert( 20 );  
   hms1.insert( 30 );  
  
   hms1_rIter = hms1.rend( );  
   hms1_rIter--;  
   cout << "The last element in the reversed hash_multiset is "  
        << *hms1_rIter << "." << endl;  
  
   // end can be used to terminate an iteration   
   // through a hash_multiset in a forward order  
   cout << "The hash_multiset is: ";  
   for ( hms1_Iter = hms1.begin( ) ; hms1_Iter != hms1.end( );  
         hms1_Iter++ )  
      cout << *hms1_Iter << " ";  
   cout << "." << endl;  
  
   // rend can be used to terminate an iteration   
   // throught a hash_multiset in a reverse order  
   cout << "The reversed hash_multiset is: ";  
   for ( hms1_rIter = hms1.rbegin( ) ; hms1_rIter != hms1.rend( );  
         hms1_rIter++ )  
      cout << *hms1_rIter << " ";  
   cout << "." << endl;  
  
   hms1_rIter = hms1.rend( );  
   hms1_rIter--;  
   hms1.erase ( *hms1_rIter );  
  
   hms1_rIter = hms1.rend( );  
   hms1_rIter--;  
   cout << "After the erasure, the last element in the "  
        << "reversed hash_multiset is " << *hms1_rIter << "."  
        << endl;  
}  
```  
  
 **The last element in the reversed hash_multiset is 10.**  
**The hash_multiset is: 10 20 30 .**  
**The reversed hash_multiset is: 30 20 10 .**  
**After the erasure, the last element in the reversed hash_multiset is 20.**   
## Requirements  
 **Header:** \<hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multiset Class](../vs140/hash_multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)