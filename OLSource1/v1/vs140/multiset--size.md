---
title: "multiset::size"
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
  - "multiset.size"
  - "size"
  - "set/std::multiset::size"
  - "std::multiset::size"
  - "std.multiset.size"
  - "multiset::size"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "size method"
ms.assetid: 78101bd6-a91a-47f9-9b7b-728da2fc56e3
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multiset::size
Returns the number of elements in the multiset.  
  
## Syntax  
  
```  
  
size_type size( ) const;  
  
```  
  
## Return Value  
 The current length of the multiset.  
  
## Example  
  
```  
// multiset_size.cpp  
// compile with: /EHsc  
#include <set>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;     
   multiset <int> ms1;  
   multiset <int> :: size_type i;  
  
   ms1.insert( 1 );  
   i = ms1.size( );  
   cout << "The multiset length is " << i << "." << endl;  
  
   ms1.insert( 2 );  
   i = ms1.size( );  
   cout << "The multiset length is now " << i << "." << endl;  
}  
```  
  
 **The multiset length is 1.**  
**The multiset length is now 2.**   
## Requirements  
 **Header:** \<set>  
  
 **Namespace:** std  
  
## See Also  
 [multiset Class](../vs140/multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)