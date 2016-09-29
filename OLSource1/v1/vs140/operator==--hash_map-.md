---
title: "operator== (hash_map)"
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
  - "std.=="
  - "std::=="
  - "operator=="
  - "std.operator=="
  - "std::operator=="
  - "hash_map/stdext::operator=="
  - "=="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator==, hash maps"
  - "== operator, with specific standard C++ objects"
  - "operator ==, hash maps"
ms.assetid: 1ea77feb-0dba-4aa3-bd6d-c7244fcec5cb
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator== (hash_map)
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Tests if the hash_map object on the left side of the operator is equal to the hash_map object on the right side.  
  
## Syntax  
  
```  
  
      bool operator==(  
   const hash_map <Key, Type, Traits, Allocator>& _Left,  
   const hash_map <Key, Type, Traits, Allocator>& _Right  
);  
```  
  
#### Parameters  
 `_Left`  
 An object of type `hash_map`.  
  
 `_Right`  
 An object of type `hash_map`.  
  
## Return Value  
 **true** if the hash_map on the left side of the operator is equal to the hash_map on the right side of the operator; otherwise **false**.  
  
## Remarks  
 The comparison between hash_map objects is based on a pairwise comparison of their elements. Two hash_maps are equal if they have the same number of elements and their respective elements have the same values. Otherwise, they are unequal.  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_map_op_eq.cpp  
// compile with: /EHsc  
#include <hash_map>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
   hash_map <int, int> hm1, hm2, hm3;  
   int i;  
   typedef pair <int, int> Int_Pair;  
  
   for ( i = 0 ; i < 3 ; i++ )  
   {  
      hm1.insert ( Int_Pair ( i, i ) );  
      hm2.insert ( Int_Pair ( i, i * i ) );  
      hm3.insert ( Int_Pair ( i, i ) );  
   }  
  
   if ( hm1 == hm2 )  
      cout << "The hash_maps hm1 and hm2 are equal." << endl;  
   else  
      cout << "The hash_maps hm1 and hm2 are not equal." << endl;  
  
   if ( hm1 == hm3 )  
      cout << "The hash_maps hm1 and hm3 are equal." << endl;  
   else  
      cout << "The hash_maps hm1 and hm3 are not equal." << endl;  
}  
```  
  
 **The hash_maps hm1 and hm2 are not equal.**  
**The hash_maps hm1 and hm3 are equal.**   
## Requirements  
 **Header:** <hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)