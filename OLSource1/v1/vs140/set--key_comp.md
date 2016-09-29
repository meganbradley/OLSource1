---
title: "set::key_comp"
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
  - "key_comp"
  - "std.set.key_comp"
  - "set/std::set::key_comp"
  - "std::set::key_comp"
  - "set::key_comp"
  - "set.key_comp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "key_comp method"
ms.assetid: 97bfc953-c4a1-44e2-b1fa-416e0122b649
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# set::key_comp
Retrieves a copy of the comparison object used to order keys in a set.  
  
## Syntax  
  
```  
  
key_compare key_comp( ) const;  
  
```  
  
## Return Value  
 Returns the function object that a set uses to order its elements, which is the template parameter `Traits`.  
  
 For more information on `Traits` see the [set Class](../vs140/set-class.md) topic.  
  
## Remarks  
 The stored object defines the member function:  
  
 **bool operator()**(**const Key&** `_xVal`, **const Key&** `_yVal`);  
  
 which returns **true** if `_xVal` precedes and is not equal to `_yVal` in the sort order.  
  
 Note that both [key_compare](../vs140/set--key_compare.md) and [value_compare](../vs140/set--value_compare.md) are synonyms for the template parameter **Traits**. Both types are provided for the set and multiset classes, where they are identical, for compatibility with the map and multimap classes, where they are distinct.  
  
## Example  
  
```  
// set_key_comp.cpp  
// compile with: /EHsc  
#include <set>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
  
   set <int, less<int> > s1;  
   set<int, less<int> >::key_compare kc1 = s1.key_comp( ) ;  
   bool result1 = kc1( 2, 3 ) ;  
   if( result1 == true )     
   {  
      cout << "kc1( 2,3 ) returns value of true, "  
           << "where kc1 is the function object of s1."  
           << endl;  
   }  
   else     
   {  
      cout << "kc1( 2,3 ) returns value of false "  
           << "where kc1 is the function object of s1."  
           << endl;  
   }  
  
   set <int, greater<int> > s2;  
   set<int, greater<int> >::key_compare kc2 = s2.key_comp( ) ;  
   bool result2 = kc2( 2, 3 ) ;  
   if(result2 == true)     
   {  
      cout << "kc2( 2,3 ) returns value of true, "  
           << "where kc2 is the function object of s2."  
           << endl;  
   }  
   else     
   {  
      cout << "kc2( 2,3 ) returns value of false, "  
           << "where kc2 is the function object of s2."  
           << endl;  
   }  
}  
```  
  
 **kc1( 2,3 ) returns value of true, where kc1 is the function object of s1.**  
**kc2( 2,3 ) returns value of false, where kc2 is the function object of s2.**   
## Requirements  
 **Header:** \<set>  
  
 **Namespace:** std  
  
## See Also  
 [set Class](../vs140/set-class.md)   
 [set::key_comp and set::value_comp](../vs140/set--key_comp-and-set--value_comp.md)   
 [Standard Template Library](../vs140/standard-template-library.md)