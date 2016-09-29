---
title: "operator&lt; (multiset)"
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
  - "std::operator<"
  - "operator<"
  - "std.<"
  - "<"
  - "set/std::operator<"
  - "std.operator<"
  - "std::<"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator>"
  - "< operator"
ms.assetid: 8fa621bc-107d-458c-ba71-acd007f095a2
caps.latest.revision: 16
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# operator&lt; (multiset)
Tests if the multiset object on the left side of the operator is less than the multiset object on the right side.  
  
## Syntax  
  
```  
  
      bool operator<(  
   const multiset <Key, Traits, Allocator>& _Left,  
   const multiset <Key, Traits, Allocator>& _Right  
);  
```  
  
#### Parameters  
 `_Left`  
 An object of type `multiset`.  
  
 `_Right`  
 An object of type `multiset`.  
  
## Return Value  
 **true** if the multiset on the left side of the operator is strictly less than the multiset on the right side of the operator; otherwise **false**.  
  
## Remarks  
 The comparison between multiset objects is based on a pairwise comparison of their elements. The less-than relationship between two objects is based on a comparison of the first pair of unequal elements.  
  
## Example  
  
```  
// multiset_op_lt.cpp  
// compile with: /EHsc  
#include <set>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   multiset <int> s1, s2, s3;  
   int i;  
  
   for ( i = 0 ; i < 3 ; i++ )  
   {  
      s1.insert ( i );  
      s2.insert ( i * i );  
      s3.insert ( i - 1 );  
   }  
  
   if ( s1 < s2 )  
      cout << "The multiset s1 is less than "  
           << "the multiset s2." << endl;  
   else  
      cout << "The multiset s1 is not less than "  
           << "the multiset s2." << endl;  
  
   if ( s1 < s3 )  
      cout << "The multiset s1 is less than "  
           << "the multiset s3." << endl;  
   else  
      cout << "The multiset s1 is not less than "  
           << "the multiset s3." << endl;  
}  
```  
  
 **The multiset s1 is less than the multiset s2.**  
**The multiset s1 is not less than the multiset s3.**   
## Requirements  
 **Header:** <set\>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)