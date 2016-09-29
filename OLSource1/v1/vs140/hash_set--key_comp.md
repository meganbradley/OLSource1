---
title: "hash_set::key_comp"
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
  - "key_comp"
  - "hash_set.key_comp"
  - "hash_set::key_comp"
  - "hash_set/stdext::hash_set::key_comp"
  - "std.hash_set.key_comp"
  - "std::hash_set::key_comp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "key_comp method"
ms.assetid: 97340183-3b7d-47a6-8058-d8ed354b7fb7
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_set::key_comp
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Retrieves a copy of the hash traits object used to hash and order element key values in a hash_set.  
  
## Syntax  
  
```  
  
key_compare key_comp( ) const;  
  
```  
  
## Return Value  
 Returns the function object that a hash_set uses to order its elements, which is the template parameter `Traits`.  
  
 For more information on `Traits` see the [hash_set Class](../vs140/hash_set-class.md) topic.  
  
## Remarks  
 The stored object defines the member function:  
  
 **bool operator**(**const Key&** _*xVal*, **const Key&** \_`yVal`);  
  
 which returns **true** if `_xVal` precedes and is not equal to `_yVal` in the sort order.  
  
 Note that both [key_compare](../vs140/hash_set--key_compare.md) and [value_compare](../vs140/hash_set--value_compare.md) are synonyms for the template parameter **Traits**. Both types are provided for the hash_set and hash_multiset classes, where they are identical, for compatibility with the hash_map and hash_multimap classes, where they are distinct.  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
  
```  
// hash_set_key_comp.cpp  
// compile with: /EHsc  
#include <hash_set>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   using namespace stdext;  
  
   hash_set <int, hash_compare < int, less<int> > >hs1;  
   hash_set<int, hash_compare < int, less<int> > >::key_compare kc1  
          = hs1.key_comp( ) ;  
   bool result1 = kc1( 2, 3 ) ;  
   if( result1 == true )  
   {  
      cout << "kc1( 2,3 ) returns value of true, "  
           << "where kc1 is the function object of hs1."  
           << endl;  
   }  
   else  
   {  
      cout << "kc1( 2,3 ) returns value of false "  
           << "where kc1 is the function object of hs1."  
        << endl;  
   }  
  
   hash_set <int, hash_compare < int, greater<int> > > hs2;  
   hash_set<int, hash_compare < int, greater<int> > >::key_compare  
         kc2 = hs2.key_comp( ) ;  
   bool result2 = kc2( 2, 3 ) ;  
   if(result2 == true)  
   {  
      cout << "kc2( 2,3 ) returns value of true, "  
           << "where kc2 is the function object of hs2."  
           << endl;  
   }  
   else  
   {  
      cout << "kc2( 2,3 ) returns value of false, "  
           << "where kc2 is the function object of hs2."  
           << endl;  
   }  
}  
```  
  
## Output  
  
```  
kc1( 2,3 ) returns value of true, where kc1 is the function object of hs1.  
kc2( 2,3 ) returns value of false, where kc2 is the function object of hs2.  
```  
  
## Requirements  
 **Header:** <hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_set Class](../vs140/hash_set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)