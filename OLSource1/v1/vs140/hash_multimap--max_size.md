---
title: "hash_multimap::max_size"
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
  - "hash_map/stdext::hash_multimap::max_size"
  - "max_size"
  - "std.hash_multimap.max_size"
  - "std::hash_multimap::max_size"
  - "hash_multimap.max_size"
  - "hash_multimap::max_size"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "max_size method"
ms.assetid: 5bd5713a-79f2-42f8-9fd4-8174f47e28c3
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multimap::max_size
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Returns the maximum length of the hash_multimap.  
  
## Syntax  
  
```  
  
size_type max_size( ) const;  
  
```  
  
## Return Value  
 The maximum possible length of the hash_multimap.  
  
## Remarks  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_multimap_max_size.cpp  
// compile with: /EHsc  
#include <hash_map>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
   hash_multimap <int, int> hm1;  
   hash_multimap <int, int> :: size_type i;  
  
   i = hm1.max_size( );  
   cout << "The maximum possible length "  
        << "of the hash_multimap is " << i << "." << endl;  
}  
```  
  
## Sample Output  
 The following output is for x86.  
  
```  
The maximum possible length of the hash_multimap is 536870911.  
```  
  
## Requirements  
 **Header:** <hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multimap Class](../vs140/hash_multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)