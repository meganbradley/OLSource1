---
title: "hash_map::find"
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
  - "find"
  - "hash_map/stdext::hash_map::find"
  - "std::hash_map::find"
  - "std.hash_map.find"
  - "hash_map.find"
  - "hash_map::find"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "find method"
ms.assetid: 6742a9a1-4b66-4f33-9a96-91822bd0bae7
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_map::find
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Returns an iterator addressing the location of an element in a hash_map that has a key equivalent to a specified key.  
  
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
 The key value to be matched by the sort key of an element from the hash_map being searched.  
  
## Return Value  
 An iterator that addresses the location of an element with a specified key, or the location succeeding the last element in the hash_map if no match is found for the key.  
  
## Remarks  
 **find** returns an iterator that addresses an element in the hash_map whose sort key is equivalent to the argument key under a binary predicate that induces an ordering based on a less than comparability relation.  
  
 If the return value of **find** is assigned to a [const_iterator](../vs140/hash_map--const_iterator.md), the hash_map object cannot be modified. If the return value of **find** is assigned to an [iterator](../vs140/hash_map--iterator.md), the hash_map object can be modified  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_map_find.cpp  
// compile with: /EHsc  
#include <hash_map>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
   hash_map <int, int> hm1;  
   hash_map <int, int> :: const_iterator hm1_AcIter, hm1_RcIter;  
   typedef pair <int, int> Int_Pair;  
  
   hm1.insert ( Int_Pair ( 1, 10 ) );  
   hm1.insert ( Int_Pair ( 2, 20 ) );  
   hm1.insert ( Int_Pair ( 3, 30 ) );  
  
   hm1_RcIter = hm1.find( 2 );  
   cout << "The element of hash_map hm1 with a key of 2 is: "  
        << hm1_RcIter -> second << "." << endl;  
  
   // If no match is found for the key, end( ) is returned  
   hm1_RcIter = hm1.find( 4 );  
  
   if ( hm1_RcIter == hm1.end( ) )  
      cout << "The hash_map hm1 doesn't have an element "  
           << "with a key of 4." << endl;  
   else  
      cout << "The element of hash_map hm1 with a key of 4 is: "  
           << hm1_RcIter -> second << "." << endl;  
  
   // The element at a specific location in the hash_map can be found   
   // using a dereferenced iterator addressing the location  
   hm1_AcIter = hm1.end( );  
   hm1_AcIter--;  
   hm1_RcIter = hm1.find( hm1_AcIter -> first );  
   cout << "The element of hm1 with a key matching "  
        << "that of the last element is: "  
        << hm1_RcIter -> second << "." << endl;  
}  
```  
  
 **The element of hash_map hm1 with a key of 2 is: 20.**  
**The hash_map hm1 doesn't have an element with a key of 4.**  
**The element of hm1 with a key matching that of the last element is: 30.**   
## Requirements  
 **Header:** <hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_map Class](../vs140/hash_map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)