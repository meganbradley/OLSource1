---
title: "hash_map::crbegin"
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
  - "hash_map::crbegin"
  - "std.hash_map.crbegin"
  - "hash_map/stdext::hash_map::crbegin"
  - "hash_map.crbegin"
  - "std::hash_map::crbegin"
  - "crbegin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "crbegin method, hash_map class"
  - "crbegin method"
ms.assetid: 69ecb96b-8b3c-4360-aaed-da92363f9586
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_map::crbegin
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Returns a const iterator addressing the first element in a reversed hash_map.  
  
## Syntax  
  
```  
  
const_reverse_iterator crbegin( ) const;  
  
```  
  
## Return Value  
 A const reverse bidirectional iterator addressing the first element in a reversed [hash_map](../vs140/hash_map-class.md) or addressing what had been the last element in the unreversed `hash_map`.  
  
## Remarks  
 `crbegin` is used with a reversed hash_map just as [begin](../vs140/hash_map--begin.md) is used with a `hash_map`.  
  
 With the return value of `crbegin`, the `hash_map` object cannot be modified.  
  
 `crbegin` can be used to iterate through a `hash_map` backwards.  
  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_map_crbegin.cpp  
// compile with: /EHsc  
#include <hash_map>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
   hash_map <int, int> hm1;  
  
   hash_map <int, int> :: const_reverse_iterator hm1_crIter;  
   typedef pair <int, int> Int_Pair;  
  
   hm1.insert ( Int_Pair ( 3, 30 ) );  
  
   hm1_crIter = hm1.crbegin( );  
   cout << "The first element of the reversed hash_map hm1 is "  
        << hm1_crIter -> first << "." << endl;  
}  
```  
  
 **The first element of the reversed hash_map hm1 is 3.**   
## Requirements  
 **Header:** \<hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_map Class](../vs140/hash_map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)