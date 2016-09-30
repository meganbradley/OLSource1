---
title: "hash_set::rend"
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
  - "std.hash_set.rend"
  - "rend"
  - "hash_set::rend"
  - "std::hash_set::rend"
  - "hash_set/stdext::hash_set::rend"
  - "hash_set.rend"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rend method"
ms.assetid: 41c4bb2c-0401-4c33-a06d-d7025e748a52
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_set::rend
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Returns an iterator that addresses the location succeeding the last element in a reversed hash_set.  
  
## Syntax  
  
```  
  
      const_reverse_iterator rend( ) const;   
reverse_iterator rend( );  
```  
  
## Return Value  
 A reverse bidirectional iterator that addresses the location succeeding the last element in a reversed hash_set (the location that had preceded the first element in the unreversed hash_set).  
  
## Remarks  
 `rend` is used with a reversed hash_set just as [end](../vs140/hash_set--end.md) is used with a hash_set.  
  
 If the return value of `rend` is assigned to a `const_reverse_iterator`, then the hash_set object cannot be modified. If the return value of `rend` is assigned to a `reverse_iterator`, then the hash_set object can be modified. The value returned by `rend` should not be dereferenced.  
  
 `rend` can be used to test to whether a reverse iterator has reached the end of its hash_set.  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_set_rend.cpp  
// compile with: /EHsc  
#include <hash_set>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
   hash_set <int> hs1;  
   hash_set <int>::iterator hs1_Iter;  
   hash_set <int>::reverse_iterator hs1_rIter;  
   hash_set <int>::const_reverse_iterator hs1_crIter;  
  
   hs1.insert( 10 );  
   hs1.insert( 20 );  
   hs1.insert( 30 );  
  
   hs1_rIter = hs1.rend( );  
   hs1_rIter--;  
   cout << "The last element in the reversed hash_set is "  
        << *hs1_rIter << "." << endl;  
  
   // end can be used to terminate an iteration   
   // throught a hash_set in a forward order  
   cout << "The hash_set is: ";  
   for ( hs1_Iter = hs1.begin( ) ; hs1_Iter != hs1.end( );  
         hs1_Iter++ )  
      cout << *hs1_Iter << " ";  
   cout << "." << endl;  
  
   // rend can be used to terminate an iteration   
   // through a hash_set in a reverse order  
   cout << "The reversed hash_set is: ";  
   for ( hs1_rIter = hs1.rbegin( ) ; hs1_rIter != hs1.rend( );  
         hs1_rIter++ )  
      cout << *hs1_rIter << " ";  
   cout << "." << endl;  
  
   hs1_rIter = hs1.rend( );  
   hs1_rIter--;  
   hs1.erase ( *hs1_rIter );  
  
   hs1_rIter = hs1.rend( );  
   hs1_rIter--;  
   cout << "After the erasure, the last element in the "  
        << "reversed hash_set is " << *hs1_rIter << "."  
        << endl;  
}  
```  
  
 **The last element in the reversed hash_set is 10.**  
**The hash_set is: 10 20 30 .**  
**The reversed hash_set is: 30 20 10 .**  
**After the erasure, the last element in the reversed hash_set is 20.**   
## Requirements  
 **Header:** <hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_set Class](../vs140/hash_set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)