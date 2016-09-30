---
title: "operator&gt; (multimap)"
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
  - "map/std::operator>"
  - "std::operator>"
  - "std.>"
  - "std.operator>"
  - "operator>"
  - "std::>"
  - ">"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "> operator"
  - "operator>"
ms.assetid: 37e57010-cdac-4163-8a41-8f369b91ac5a
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator&gt; (multimap)
Tests if the multimap object on the left side of the operator is greater than the multimap object on the right side.  
  
## Syntax  
  
```  
  
      bool operator>(  
   const multimap <Key, Type, Traits, Allocator>& _Left,  
   const multimap <Key, Type, Traits, Allocator>& _Right  
);  
```  
  
#### Parameters  
 `_Left`  
 An object of type `multimap`.  
  
 `_Right`  
 An object of type `multimap`.  
  
## Return Value  
 **true** if the multimap on the left side of the operator is greater than the multimap on the right side of the operator; otherwise **false**.  
  
## Remarks  
 The comparison between multimap objects is based on a pairwise comparison of their elements. The greater-than relationship between two objects is based on a comparison of the first pair of unequal elements.  
  
## Example  
  
```  
// multimap_op_gt.cpp  
// compile with: /EHsc  
#include <map>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   multimap < int, int > m1, m2, m3;  
   int i;  
   typedef pair < int, int > Int_Pair;  
  
   for ( i = 0 ; i < 3 ; i++ )  
   {  
      m1.insert ( Int_Pair ( i, i ) );  
      m2.insert ( Int_Pair ( i, i * i ) );  
      m3.insert ( Int_Pair ( i, i - 1 ) );  
   }  
  
   if ( m1 > m2 )  
      cout << "The multimap m1 is greater than the multimap m2." << endl;  
   else  
      cout << "Multimap m1 is not greater than multimap m2." << endl;  
  
   if ( m1 > m3 )  
      cout << "The multimap m1 is greater than the multimap m3." << endl;  
   else  
      cout << "The multimap m1 is not greater than the multimap m3." << endl;  
}  
```  
  
 **Multimap m1 is not greater than multimap m2.**  
**The multimap m1 is greater than the multimap m3.**   
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)