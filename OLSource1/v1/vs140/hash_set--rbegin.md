---
title: "hash_set::rbegin"
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
  - "hash_set/stdext::hash_set::rbegin"
  - "std::hash_set::rbegin"
  - "hash_set::rbegin"
  - "rbegin"
  - "hash_set.rbegin"
  - "std.hash_set.rbegin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rbegin method"
ms.assetid: 30b3dcc1-15b6-4788-ae8a-6c7ff16fdb00
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_set::rbegin
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Returns an iterator addressing the first element in a reversed hash_set.  
  
## Syntax  
  
```  
  
      const_reverse_iterator rbegin( ) const;   
reverse_iterator rbegin( );  
```  
  
## Return Value  
 A reverse bidirectional iterator addressing the first element in a reversed hash_set or addressing what had been the last element in the unreversed hash_set.  
  
## Remarks  
 `rbegin` is used with a reversed hash_set just as [begin](../vs140/hash_set--begin.md) is used with a hash_set.  
  
 If the return value of `rbegin` is assigned to a `const_reverse_iterator`, then the hash_set object cannot be modified. If the return value of `rbegin` is assigned to a `reverse_iterator`, then the hash_set object can be modified.  
  
 `rbegin` can be used to iterate through a hash_set backwards.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_set_rbegin.cpp  
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
  
   hs1.insert( 10 );  
   hs1.insert( 20 );  
   hs1.insert( 30 );  
  
   hs1_rIter = hs1.rbegin( );  
   cout << "The first element in the reversed hash_set is "  
        << *hs1_rIter << "." << endl;  
  
   // begin can be used to start an iteration   
   // throught a hash_set in a forward order  
   cout << "The hash_set is: ";  
   for ( hs1_Iter = hs1.begin( ) ; hs1_Iter != hs1.end( );  
         hs1_Iter++ )  
      cout << *hs1_Iter << " ";  
   cout << endl;  
  
   // rbegin can be used to start an iteration   
   // throught a hash_set in a reverse order  
   cout << "The reversed hash_set is: ";  
   for ( hs1_rIter = hs1.rbegin( ) ; hs1_rIter != hs1.rend( );  
         hs1_rIter++ )  
      cout << *hs1_rIter << " ";  
   cout << endl;  
  
   // A hash_set element can be erased by dereferencing to its key   
   hs1_rIter = hs1.rbegin( );  
   hs1.erase ( *hs1_rIter );  
  
   hs1_rIter = hs1.rbegin( );  
   cout << "After the erasure, the first element "  
        << "in the reversed hash_set is "<< *hs1_rIter << "."  
        << endl;  
}  
```  
  
 **The first element in the reversed hash_set is 30.**  
**The hash_set is: 10 20 30**   
**The reversed hash_set is: 30 20 10**   
**After the erasure, the first element in the reversed hash_set is 20.**   
## Requirements  
 **Header:** \<hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_set Class](../vs140/hash_set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)