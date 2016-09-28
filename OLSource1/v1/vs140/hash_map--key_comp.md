---
title: "hash_map::key_comp"
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
  - "hash_map::key_comp"
  - "std.hash_map.key_comp"
  - "key_comp"
  - "hash_map/stdext::hash_map::key_comp"
  - "std::hash_map::key_comp"
  - "hash_map.key_comp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "key_comp method"
ms.assetid: 28bd00f6-7a9d-4aab-a9c7-ca6e2b512b4c
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_map::key_comp
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Retrieves a copy of the comparison object used to order keys in a hash_map.  
  
## Syntax  
  
```  
  
key_compare key_comp( ) const;  
  
```  
  
## Return Value  
 Returns the function object that a hash_map uses to order its elements.  
  
## Remarks  
 The stored object defines the member function  
  
 **bool operator**(**const Key&** `_Left`**, const Key&** `_Right`);  
  
 that returns **true** if `_Left` precedes and is not equal to `_Right` in the sort order.  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_map_key_comp.cpp  
// compile with: /EHsc  
#include <hash_map>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
  
   hash_map <int, int, hash_compare<int, less<int> > > hm1;  
   hash_map <int, int, hash_compare<int, less<int> > >::key_compare   
      kc1 = hm1.key_comp( ) ;  
  
   // Operator stored in kc1 tests order & returns bool value  
   bool result1 = kc1( 2, 3 ) ;     
   if( result1 == true )     
   {  
      cout << "kc1( 2,3 ) returns value of true,"  
           << "\n where kc1 is the function object of hm1"  
           << " of type key_compare." << endl;  
   }  
   else     
   {  
      cout << "kc1( 2,3 ) returns value of false"  
           << "\n where kc1 is the function object of hm1"  
           << " of type key_compare." << endl;  
   }  
  
   hash_map <int, int, hash_compare<int, greater<int> > > hm2;  
   hash_map <int, int, hash_compare<int, greater<int> > >  
      ::key_compare kc2 = hm2.key_comp( );  
  
   // Operator stored in kc2 tests order & returns bool value  
   bool result2 = kc2( 2, 3 ) ;  
   if( result2 == true )  
   {  
      cout << "kc2( 2,3 ) returns value of true,"  
           << "\n where kc2 is the function object of hm2"  
           << " of type key_compare." << endl;  
   }  
   else     
   {  
      cout << "kc2( 2,3 ) returns value of false,"  
           << "\n where kc2 is the function object of hm2"  
           << " of type key_compare." << endl;  
   }  
}  
```  
  
## Output  
  
```  
kc1( 2,3 ) returns value of true,  
 where kc1 is the function object of hm1 of type key_compare.  
kc2( 2,3 ) returns value of false,  
 where kc2 is the function object of hm2 of type key_compare.  
```  
  
## Requirements  
 **Header:** <hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_map Class](../vs140/hash_map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)