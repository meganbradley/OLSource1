---
title: "hash_multiset::clear"
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
  - "hash_multiset::clear"
  - "hash_set/stdext::hash_multiset::clear"
  - "std.hash_multiset.clear"
  - "std::hash_multiset::clear"
  - "hash_multiset.clear"
  - "Clear"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "clear method"
ms.assetid: 02f39282-c048-4db5-a1de-d88f90034d0a
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multiset::clear
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Erases all the elements of a hash_multiset.  
  
## Syntax  
  
```  
  
void clear( );  
  
```  
  
## Remarks  
 In Visual C++ .NET 2003, members of the [\<hash_map>](../vs140/-hash_map-.md) and [\<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_multiset_clear.cpp  
// compile with: /EHsc  
#include <hash_set>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
   hash_multiset <int> hms1;  
  
   hms1.insert( 1 );  
   hms1.insert( 2 );  
  
   cout << "The size of the hash_multiset is initially " << hms1.size( )  
        << "." << endl;  
  
   hms1.clear( );  
   cout << "The size of the hash_multiset after clearing is "   
        << hms1.size( ) << "." << endl;  
}  
```  
  
 **The size of the hash_multiset is initially 2.**  
**The size of the hash_multiset after clearing is 0.**   
## Requirements  
 **Header:** \<hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multiset Class](../vs140/hash_multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)