---
title: "set::swap"
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
  - "set.swap"
  - "set::swap"
  - "std::set::swap"
  - "std.set.swap"
  - "set/std::set::swap"
  - "swap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "swap method"
ms.assetid: 22351c85-4b21-43ce-baab-ee5e14b56483
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# set::swap
Exchanges the elements of two sets.  
  
## Syntax  
  
```  
void swap(  
   set<Key, Traits, Allocator>& _Right  
);  
```  
  
#### Parameters  
 `_Right`  
 The argument set providing the elements to be swapped with the target set.  
  
## Remarks  
 The member function invalidates no references, pointers, or iterators that designate elements in the two sets whose elements are being exchanged.  
  
## Example  
  
```  
// set_swap.cpp  
// compile with: /EHsc  
#include <set>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   set <int> s1, s2, s3;  
   set <int>::iterator s1_Iter;  
  
   s1.insert( 10 );  
   s1.insert( 20 );  
   s1.insert( 30 );  
   s2.insert( 100 );  
   s2.insert( 200 );  
   s3.insert( 300 );  
  
   cout << "The original set s1 is:";  
   for ( s1_Iter = s1.begin( ); s1_Iter != s1.end( ); s1_Iter++ )  
      cout << " " << *s1_Iter;  
   cout   << "." << endl;  
  
   // This is the member function version of swap  
   s1.swap( s2 );  
  
   cout << "After swapping with s2, list s1 is:";  
   for ( s1_Iter = s1.begin( ); s1_Iter != s1.end( ); s1_Iter++ )  
      cout << " " << *s1_Iter;  
   cout  << "." << endl;  
  
   // This is the specialized template version of swap  
   swap( s1, s3 );  
  
   cout << "After swapping with s3, list s1 is:";  
   for ( s1_Iter = s1.begin( ); s1_Iter != s1.end( ); s1_Iter++ )  
      cout << " " << *s1_Iter;  
   cout   << "." << endl;  
}  
```  
  
 **The original set s1 is: 10 20 30.**  
**After swapping with s2, list s1 is: 100 200.**  
**After swapping with s3, list s1 is: 300.**   
## Requirements  
 **Header:** <set\>  
  
 **Namespace:** std  
  
## See Also  
 [set Class](../vs140/set-class.md)   
 [set::swap, set::begin, and set::end](../vs140/set--swap--set--begin--and-set--end.md)   
 [Standard Template Library](../vs140/standard-template-library.md)