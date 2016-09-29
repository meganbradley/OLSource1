---
title: "hash_multiset::value_comp"
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
  - "value_comp"
  - "hash_multiset.value_comp"
  - "std::hash_multiset::value_comp"
  - "hash_multiset::value_comp"
  - "hash_set/stdext::hash_multiset::value_comp"
  - "std.hash_multiset.value_comp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "value_comp method"
ms.assetid: 7c1c7506-1b74-434d-88ab-d6af859510a0
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multiset::value_comp
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_multiset Class](../vs140/unordered_multiset-class.md).  
  
 Retrieves a copy of the comparison object used to order element values in a hash_multiset.  
  
## Syntax  
  
```  
  
value_compare value_comp( ) const;  
  
```  
  
## Return Value  
 Returns the hash_multiset template parameter `Traits`, which contains function objects that are used to hash and to order elements of the container.  
  
 For more information on `Traits` see the [hash_multiset Class](../vs140/hash_multiset-class.md) topic.  
  
## Remarks  
 The stored object defines a member function:  
  
 **bool operator**(**const Key&** `_xVal`, **const Key&** *_yVal*);  
  
 which returns **true** if `_xVal` precedes and is not equal to `_yVal` in the sort order.  
  
 Note that both [key_compare](../vs140/hash_multiset--key_compare.md) and [value_compare](../vs140/hash_multiset--value_compare.md) are synonyms for the template parameter **Traits**. Both types are provided for the hash_multiset and hash_multiset classes, where they are identical, for compatibility with the hash_map and hash_multimap classes, where they are distinct.  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_multiset_value_comp.cpp  
// compile with: /EHsc  
#include <hash_set>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
  
   hash_multiset <int, hash_compare < int, less<int> > > hms1;  
   hash_multiset <int, hash_compare < int, less<int> > >::value_compare  
      vc1 = hms1.value_comp( );  
   bool result1 = vc1( 2, 3 );  
   if( result1 == true )  
   {  
      cout << "vc1( 2,3 ) returns value of true, "  
           << "where vc1 is the function object of hms1."  
           << endl;  
   }  
   else  
   {  
      cout << "vc1( 2,3 ) returns value of false, "  
           << "where vc1 is the function object of hms1."  
           << endl;  
   }  
  
   hash_multiset <int, hash_compare < int, greater<int> > > hms2;  
   hash_multiset<int, hash_compare < int, greater<int> > >::  
           value_compare vc2 = hms2.value_comp( );  
   bool result2 = vc2( 2, 3 );  
   if( result2 == true )  
   {  
      cout << "vc2( 2,3 ) returns value of true, "  
           << "where vc2 is the function object of hms2."  
           << endl;  
   }  
   else  
   {  
      cout << "vc2( 2,3 ) returns value of false, "  
           << "where vc2 is the function object of hms2."  
           << endl;  
   }  
}  
```  
  
 **vc1( 2,3 ) returns value of true, where vc1 is the function object of hms1.**  
**vc2( 2,3 ) returns value of false, where vc2 is the function object of hms2.**   
## Requirements  
 **Header:** <hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_multiset Class](../vs140/hash_multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)