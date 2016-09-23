---
title: "hash_set::find"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - Find
  - hash_set::find
  - std::hash_set::find
  - hash_set/stdext::hash_set::find
  - std.hash_set.find
  - hash_set.find
dev_langs: 
  - C++
helpviewer_keywords: 
  - find method
ms.assetid: e9bfe931-b4e0-4369-9e7c-56628f92308a
caps.latest.revision: 19
translation.priority.ht: 
  - de-de
  - ja-jp
---
# hash_set::find
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Returns an iterator addressing the location of an element in a hash_set that has a key equivalent to a specified key.  
  
## Syntax  
  
```  
  
      iterator find(  
   const Key& _Key  
);  
const_iterator find(  
   const Key& _Key  
) const;  
```  
  
#### Parameters  
 `_Key`  
 The argument key to be matched by the sort key of an element from the hash_set being searched.  
  
## Return Value  
 An **iterator** or `const_iterator` that addresses the location of an element equivalent to a specified key or that addresses the location succeeding the last element in the hash_set if no match is found for the key.  
  
## Remarks  
 The member function returns an iterator that addresses an element in the hash_set whose sort key is **equivalent** to the argument key under a binary predicate that induces an ordering based on a less-than comparability relation.  
  
 If the return value of **find** is assigned to a `const_iterator`, the hash_set object cannot be modified. If the return value of **find** is assigned to an **iterator**, the hash_set object can be modified.  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_set_find.cpp  
// compile with: /EHsc  
#include <hash_set>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
   hash_set <int> hs1;  
   hash_set <int> :: const_iterator hs1_AcIter, hs1_RcIter;  
  
   hs1.insert( 10 );  
   hs1.insert( 20 );  
   hs1.insert( 30 );  
  
   hs1_RcIter = hs1.find( 20 );  
   cout << "The element of hash_set hs1 with a key of 20 is: "  
        << *hs1_RcIter << "." << endl;  
  
   hs1_RcIter = hs1.find( 40 );  
  
   // If no match is found for the key, end( ) is returned  
   if ( hs1_RcIter == hs1.end( ) )  
      cout << "The hash_set hs1 doesn't have an element "  
           << "with a key of 40." << endl;  
   else  
      cout << "The element of hash_set hs1 with a key of 40 is: "  
           << *hs1_RcIter << "." << endl;  
  
   // The element at a specific location in the hash_set can be found   
   // by using a dereferenced iterator addressing the location  
   hs1_AcIter = hs1.end( );  
   hs1_AcIter--;  
   hs1_RcIter = hs1.find( *hs1_AcIter );  
   cout << "The element of hs1 with a key matching "  
        << "that of the last element is: "  
        << *hs1_RcIter << "." << endl;  
}  
```  
  
 **The element of hash_set hs1 with a key of 20 is: 20.**  
**The hash_set hs1 doesn't have an element with a key of 40.**  
**The element of hs1 with a key matching that of the last element is: 30.**   
## Requirements  
 **Header:** <hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_set Class](../vs140/hash_set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)