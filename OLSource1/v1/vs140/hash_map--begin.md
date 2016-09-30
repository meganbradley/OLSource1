---
title: "hash_map::begin"
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
  - "hash_map::begin"
  - "hash_map.begin"
  - "hash_map/stdext::hash_map::begin"
  - "std::hash_map::begin"
  - "std.hash_map.begin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "begin method, with specific classes"
ms.assetid: fae0f381-a028-46e6-962e-9894b181364b
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_map::begin
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Returns an iterator addressing the first element in the hash_map.  
  
## Syntax  
  
```  
  
      const_iterator begin( ) const;   
iterator begin( );  
```  
  
## Return Value  
 A bidirectional iterator addressing the first element in the hash_map or the location succeeding an empty hash_map.  
  
## Remark  
 If the return value of **begin** is assigned to a `const_iterator`, the elements in the hash_map object cannot be modified. If the return value of **begin** is assigned to an **iterator**, the elements in the hash_map object can be modified.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_map_begin.cpp  
// compile with: /EHsc  
#include <hash_map>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
   hash_map <int, int> hm1;  
  
   hash_map <int, int> :: iterator hm1_Iter;  
   hash_map <int, int> :: const_iterator hm1_cIter;  
   typedef pair <int, int> Int_Pair;  
  
   hm1.insert ( Int_Pair ( 0, 0 ) );  
   hm1.insert ( Int_Pair ( 1, 1 ) );  
   hm1.insert ( Int_Pair ( 2, 4 ) );  
  
   hm1_cIter = hm1.begin ( );  
   cout << "The first element of hm1 is "   
        << hm1_cIter -> first << "." << endl;  
  
   hm1_Iter = hm1.begin ( );  
   hm1.erase ( hm1_Iter );  
  
   // The following 2 lines would err because the iterator is const  
   // hm1_cIter = hm1.begin ( );  
   // hm1.erase ( hm1_cIter );  
  
   hm1_cIter = hm1.begin( );  
   cout << "The first element of hm1 is now "   
        << hm1_cIter -> first << "." << endl;  
}  
```  
  
 **The first element of hm1 is 0.**  
**The first element of hm1 is now 1.**   
## Requirements  
 **Header:** \<hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_map Class](../vs140/hash_map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)