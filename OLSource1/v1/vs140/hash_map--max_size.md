---
title: "hash_map::max_size"
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
  - "hash_map::max_size"
  - "hash_map/stdext::hash_map::max_size"
  - "std.hash_map.max_size"
  - "std::hash_map::max_size"
  - "max_size"
  - "hash_map.max_size"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "max_size method"
ms.assetid: 04f4d975-a3fb-4568-b326-51348233fdba
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_map::max_size
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Returns the maximum length of the hash_map.  
  
## Syntax  
  
```  
  
size_type max_size( ) const;  
  
```  
  
## Return Value  
 The maximum possible length of the hash_map.  
  
## Remarks  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_map_max_size.cpp  
// compile with: /EHsc  
#include <hash_map>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
   hash_map <int, int> hm1;  
   hash_map <int, int> :: size_type i;  
  
   i = hm1.max_size( );     
   cout << "The maximum possible length "  
        << "of the hash_map is " << i << "."  
        << endl << "(Magnitude is machine specific.)";  
}  
```  
  
## Sample Output  
 The following output is for x86.  
  
```  
The maximum possible length of the hash_map is 536870911.  
(Magnitude is machine specific.)  
```  
  
## Requirements  
 **Header:** <hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_map Class](../vs140/hash_map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)