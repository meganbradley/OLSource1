---
title: "hash_multiset::size"
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
  - "hash_multiset::size"
  - "hash_multiset.size"
  - "size"
  - "std::hash_multiset::size"
  - "std.hash_multiset.size"
  - "hash_set/stdext::hash_multiset::size"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "size method"
ms.assetid: 7e5e83d7-6467-40f1-83ca-634a4ea7864b
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multiset::size
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Returns the number of elements in the hash_multiset.  
  
## Syntax  
  
```  
  
size_type size( ) const;  
  
```  
  
## Return Value  
 The current length of the hash_multiset.  
  
## Remarks  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_multiset_size.cpp  
// compile with: /EHsc  
#include <hash_set>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
   hash_multiset <int> hms1;  
   hash_multiset <int> :: size_type i;  
  
   hms1.insert( 1 );  
   i = hms1.size( );  
   cout << "The hash_multiset length is " << i << "." << endl;  
  
   hms1.insert( 2 );  
   i = hms1.size( );  
   cout << "The hash_multiset length is now " << i << "." << endl;  
}  
```  
  
 **The hash_multiset length is 1.**  
**The hash_multiset length is now 2.**   
## Requirements  
 **Header:** <hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multiset Class](../vs140/hash_multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)