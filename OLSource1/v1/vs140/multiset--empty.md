---
title: "multiset::empty"
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
  - "multiset.empty"
  - "std::multiset::empty"
  - "multiset::empty"
  - "std.multiset.empty"
  - "set/std::multiset::empty"
  - "empty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "empty method"
ms.assetid: 8ad6f043-23e6-49cb-bada-081bb6c2324c
caps.latest.revision: 17
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# multiset::empty
Tests if a multiset is empty.  
  
## Syntax  
  
```  
  
bool empty( ) const;  
  
```  
  
## Return Value  
 **true** if the multiset is empty; **false** if the multiset is nonempty.  
  
## Example  
  
```  
// multiset_empty.cpp  
// compile with: /EHsc  
#include <set>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   multiset <int> ms1, ms2;  
   ms1.insert ( 1 );  
  
   if ( ms1.empty( ) )  
      cout << "The multiset ms1 is empty." << endl;  
   else  
      cout << "The multiset ms1 is not empty." << endl;  
  
   if ( ms2.empty( ) )  
      cout << "The multiset ms2 is empty." << endl;  
   else  
      cout << "The multiset ms2 is not empty." << endl;  
}  
```  
  
 **The multiset ms1 is not empty.**  
**The multiset ms2 is empty.**   
## Requirements  
 **Header:** <set\>  
  
 **Namespace:** std  
  
## See Also  
 [multiset Class](../vs140/multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)