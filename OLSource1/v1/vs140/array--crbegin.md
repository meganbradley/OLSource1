---
title: "array::crbegin"
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
  - "array::crbegin"
  - "std.array.crbegin"
  - "std::tr1::array::crbegin"
  - "tr1::array::crbegin"
  - "tr1.array.crbegin"
  - "array/std::tr1::array::crbegin"
  - "std::array::crbegin"
  - "array.crbegin"
  - "std.tr1.array.crbegin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "crbegin method"
ms.assetid: 43c41a85-a13d-40fb-bad0-885f7b18b23d
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# array::crbegin
Returns a const iterator to the first element in a reversed array.  
  
## Syntax  
  
```  
const_reverse_iterator crbegin( ) const;  
```  
  
## Return Value  
 A const reverse random-access iterator addressing the first element in a reversed array or addressing what had been the last element in the unreversed array.  
  
## Remarks  
 With the return value of `crbegin`, the array object cannot be modified.  
  
## Example  
  
```  
// array_crbegin.cpp  
// compile with: /EHsc  
#include <array>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;     
   array<int, 2> v1 = {1, 2};  
   array<int, 2>::iterator v1_Iter;  
   array<int, 2>::const_reverse_iterator v1_rIter;  
  
   v1_Iter = v1.begin( );  
   cout << "The first element of array is "  
        << *v1_Iter << "." << endl;  
  
   v1_rIter = v1.crbegin( );  
   cout << "The first element of the reversed array is "  
        << *v1_rIter << "." << endl;  
}  
```  
  
 **The first element of array is 1.**  
**The first element of the reversed array is 2.**   
## Requirements  
 **Header:** \<array>  
  
 **Namespace:** std  
  
## See Also  
 [\<array>](../vs140/-array-.md)   
 [array Class](../vs140/array-class--stl-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)