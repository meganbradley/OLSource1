---
title: "hash_multiset::empty"
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
  - "std::hash_multiset::empty"
  - "std.hash_multiset.empty"
  - "empty"
  - "hash_multiset::empty"
  - "hash_multiset.empty"
  - "hash_set/stdext::hash_multiset::empty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "empty method"
ms.assetid: d94e6b94-1edc-4008-bb85-94ca67edf603
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multiset::empty
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Tests if a hash_multiset is empty.  
  
## Syntax  
  
```  
  
bool empty( ) const;  
  
```  
  
## Return Value  
 **true** if the hash_multiset is empty; **false** if the hash_multiset is nonempty.  
  
## Remarks  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_multiset_empty.cpp  
// compile with: /EHsc  
#include <hash_set>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
   hash_multiset <int> hms1, hms2;  
   hms1.insert ( 1 );  
  
   if ( hms1.empty( ) )  
      cout << "The hash_multiset hms1 is empty." << endl;  
   else  
      cout << "The hash_multiset hms1 is not empty." << endl;  
  
   if ( hms2.empty( ) )  
      cout << "The hash_multiset hms2 is empty." << endl;  
   else  
      cout << "The hash_multiset hms2 is not empty." << endl;  
}  
```  
  
 **The hash_multiset hms1 is not empty.**  
**The hash_multiset hms2 is empty.**   
## Requirements  
 **Header:** <hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multiset Class](../vs140/hash_multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)