---
title: "multiset::clear"
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
  - "std::multiset::clear"
  - "clear"
  - "multiset.clear"
  - "multiset::clear"
  - "std.multiset.clear"
  - "set/std::multiset::clear"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "clear method"
ms.assetid: 64406f59-1f9d-432c-99cc-c20e8faaefe1
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multiset::clear
Erases all the elements of a multiset.  
  
## Syntax  
  
```  
  
void clear( );  
  
```  
  
## Example  
  
```  
// multiset_clear.cpp  
// compile with: /EHsc  
#include <set>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;     
   multiset <int> ms1;  
  
   ms1.insert( 1 );  
   ms1.insert( 2 );  
  
   cout << "The size of the multiset is initially "  
        << ms1.size( ) << "." << endl;  
  
   ms1.clear( );  
   cout << "The size of the multiset after clearing is "   
        << ms1.size( ) << "." << endl;  
}  
```  
  
 **The size of the multiset is initially 2.**  
**The size of the multiset after clearing is 0.**   
## Requirements  
 **Header:** \<set>  
  
 **Namespace:** std  
  
## See Also  
 [multiset Class](../vs140/multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)