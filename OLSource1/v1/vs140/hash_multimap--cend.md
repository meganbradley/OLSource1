---
title: "hash_multimap::cend"
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
  - "hash_map/stdext::hash_multimap::cend"
  - "std::hash_multimap::cend"
  - "hash_multimap::cend"
  - "sed.hash_multimap.cend"
  - "hash_multimap.cend"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "cend method"
  - "cend method, hash_multimap class"
ms.assetid: efa38270-532f-4651-a493-c920b036758a
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multimap::cend
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Returns a const iterator that addresses the location succeeding the last element in a hash_multimap.  
  
## Syntax  
  
```  
  
const_iterator cend( ) const;  
  
```  
  
## Return Value  
 A const bidirectional iterator that addresses the location succeeding the last element in a [hash_multimap](../vs140/hash_multimap-class.md). If the `hash_multimap` is empty, then `hash_multimap::cend == hash_multimap::begin`.  
  
## Remarks  
 `cend` is used to test whether an iterator has reached the end of its hash_multimap.  
  
 The value returned by `cend` should not be dereferenced.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_multimap_cend.cpp  
// compile with: /EHsc  
#include <hash_multimap>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
   using namespace stdext;  
   hash_multimap <int, int> hm1;  
  
   hash_multimap <int, int> :: const_iterator hm1_cIter;  
   typedef pair <int, int> Int_Pair;  
  
   hm1.insert ( Int_Pair ( 3, 30 ) );  
  
   hm1_cIter = hm1.cend( );  
   hm1_cIter--;  
   cout << "The value of last element of hm1 is "   
        << hm1_cIter -> second << "." << endl;  
   }  
```  
  
 **The value of last element of hm1 is 30.**   
## Requirements  
 **Header:** \<hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multimap Class](../vs140/hash_multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)