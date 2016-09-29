---
title: "hash_map::clear"
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
  - "hash_map::clear"
  - "std::hash_map::clear"
  - "std.hash_map.clear"
  - "hash_map.clear"
  - "hash_map/stdext::hash_map::clear"
  - "Clear"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "clear method"
ms.assetid: a86ef9fc-a206-4027-9c76-8122c40a3b80
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_map::clear
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Erases all the elements of a hash_map.  
  
## Syntax  
  
```  
  
void clear( );  
  
```  
  
## Remarks  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
 The following example demonstrates the use of the hash_map::clear member function.  
  
```  
// hash_map_clear.cpp  
// compile with: /EHsc  
#include <hash_map>  
#include <iostream>  
  
int main( )  
{  
    using namespace std;  
    using namespace stdext;  
    hash_map<int, int> hm1;  
    hash_map<int, int>::size_type i;  
    typedef pair<int, int> Int_Pair;  
  
    hm1.insert(Int_Pair(1, 1));  
    hm1.insert(Int_Pair(2, 4));  
  
    i = hm1.size();  
    cout << "The size of the hash_map is initially "  
         << i << "." << endl;  
  
    hm1.clear();  
    i = hm1.size();  
    cout << "The size of the hash_map after clearing is "  
         << i << "." << endl;  
}  
```  
  
 **The size of the hash_map is initially 2.**  
**The size of the hash_map after clearing is 0.**   
## Requirements  
 **Header:** <hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_map Class](../vs140/hash_map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)