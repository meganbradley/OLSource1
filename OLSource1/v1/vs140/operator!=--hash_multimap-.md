---
title: "operator!= (hash_multimap)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - std::!=
  - hash_map/stdext::operator!=
  - !=
  - std::operator!=
  - std.operator!=
  - std.!=
  - operator!=
dev_langs: 
  - C++
helpviewer_keywords: 
  - != operator
  - operator!=
ms.assetid: 7078b470-6e74-40c3-896b-f0b1541b1a6b
caps.latest.revision: 19
translation.priority.ht: 
  - de-de
  - ja-jp
---
# operator!= (hash_multimap)
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multimap Class](../vs140/unordered_multimap-class.md).  
  
 Tests if the hash_multimap object on the left side of the operator is not equal to the hash_multimap object on the right side.  
  
## Syntax  
  
```  
  
      bool operator!=(  
   const hash_multimap <Key, Type, Traits, Allocator>& _Left,  
   const hash_multimap <Key, Type, Traits, Allocator>& _Right  
);  
```  
  
#### Parameters  
 `_Left`  
 An object of type `hash_multimap`.  
  
 `_Right`  
 An object of type `hash_multimap`.  
  
## Return Value  
 **true** if the hash_multimaps are not equal; **false** if hash_multimaps are equal.  
  
## Remarks  
 The comparison between hash_multimap objects is based on a pairwise comparison of their elements. Two hash_multimaps are equal if they have the same number of elements and their respective elements have the same values. Otherwise, they are unequal.  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_multimap_op_ne.cpp  
// compile with: /EHsc  
#include <hash_map>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
   hash_multimap <int, int> hm1, hm2, hm3;  
   int i;  
   typedef pair <int, int> Int_Pair;  
  
   for ( i = 0 ; i < 3 ; i++ )  
   {  
      hm1.insert ( Int_Pair ( i, i ) );  
      hm2.insert ( Int_Pair ( i, i * i ) );  
      hm3.insert ( Int_Pair ( i, i ) );  
   }  
  
   if ( hm1 != hm2 )  
      cout << "The hash_multimaps hm1 and hm2 are not equal." << endl;  
   else  
      cout << "The hash_multimaps hm1 and hm2 are equal." << endl;  
  
   if ( hm1 != hm3 )  
      cout << "The hash_multimaps hm1 and hm3 are not equal." << endl;  
   else  
      cout << "The hash_multimaps hm1 and hm3 are equal." << endl;  
}  
```  
  
 **The hash_multimaps hm1 and hm2 are not equal.**  
**The hash_multimaps hm1 and hm3 are equal.**   
## Requirements  
 **Header:** <hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)