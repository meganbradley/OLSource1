---
title: "hash_map::erase"
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
  - "hash_map/stdext::hash_map::erase"
  - "erase"
  - "hash_map.erase"
  - "std::hash_map::erase"
  - "hash_map::erase"
  - "std.hash_map.erase"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "erase method"
ms.assetid: abc7fbde-7769-48ff-8b89-7ed4dbc0a44d
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_map::erase
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Removes an element or a range of elements in a hash_map from specified positions or removes elements that match a specified key.  
  
## Syntax  
  
```  
  
      iterator erase(  
   iterator _Where  
);  
iterator erase(  
   iterator _First,  
   iterator _Last  
);  
size_type erase(  
   const key_type& _Key  
);  
```  
  
#### Parameters  
 `_Where`  
 Position of the element to be removed from the hash_map.  
  
 `_First`  
 Position of the first element removed from the hash_map.  
  
 `_Last`  
 Position just beyond the last element removed from the hash_map.  
  
 `_Key`  
 The key value of the elements to be removed from the hash_map.  
  
## Return Value  
 For the first two member functions, a bidirectional iterator that designates the first element remaining beyond any elements removed, or a pointer to the end of the hash_map if no such element exists.  
  
 For the third member function, returns the number of elements that have been removed from the hash_map.  
  
## Remarks  
 The member functions never throw an exception.  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
 The following example demonstrates the use of the hash_map::erase member function.  
  
```  
// hash_map_erase.cpp  
// compile with: /EHsc  
#include <hash_map>  
#include <iostream>  
  
int main()  
{  
    using namespace std;  
    using namespace stdext;  
    hash_map<int, int> hm1, hm2, hm3;  
    hash_map<int, int> :: iterator pIter, Iter1, Iter2;  
    int i;  
    hash_map<int, int>::size_type n;  
    typedef pair<int, int> Int_Pair;  
  
    for (i = 1; i < 5; i++)  
    {  
        hm1.insert(Int_Pair (i, i));  
        hm2.insert(Int_Pair (i, i*i));  
        hm3.insert(Int_Pair (i, i-1));  
    }  
  
    // The 1st member function removes an element at a given position  
    Iter1 = ++hm1.begin();  
    hm1.erase(Iter1);  
  
    cout << "After the 2nd element is deleted, the hash_map hm1 is:";  
    for (pIter = hm1.begin(); pIter != hm1.end(); pIter++)  
        cout << " " << pIter -> second;  
    cout << "." << endl;  
  
    // The 2nd member function removes elements  
    // in the range [_First, _Last)  
    Iter1 = ++hm2.begin();  
    Iter2 = --hm2.end();  
    hm2.erase(Iter1, Iter2);  
  
    cout << "After the middle two elements are deleted, "  
         << "the hash_map hm2 is:";  
    for (pIter = hm2.begin(); pIter != hm2.end(); pIter++)  
        cout << " " << pIter -> second;  
    cout << "." << endl;  
  
    // The 3rd member function removes elements with a given _Key  
    n = hm3.erase(2);  
  
    cout << "After the element with a key of 2 is deleted,\n"  
         << "the hash_map hm3 is:";  
    for (pIter = hm3.begin(); pIter != hm3.end(); pIter++)  
        cout << " " << pIter -> second;  
    cout << "." << endl;  
  
    // The 3rd member function returns the number of elements removed  
    cout << "The number of elements removed from hm3 is: "  
         << n << "." << endl;  
  
    // The dereferenced iterator can also be used to specify a key  
    Iter1 = ++hm3.begin();  
    hm3.erase(Iter1);  
  
    cout << "After another element with a key equal to that"  
         << endl;  
    cout  << "of the 2nd element is deleted, "  
          << "the hash_map hm3 is:";  
    for (pIter = hm3.begin(); pIter != hm3.end(); pIter++)  
        cout << " " << pIter -> second;  
    cout << "." << endl;  
}  
```  
  
 **After the 2nd element is deleted, the hash_map hm1 is: 1 3 4.**  
**After the middle two elements are deleted, the hash_map hm2 is: 1 16.**  
**After the element with a key of 2 is deleted,**  
**the hash_map hm3 is: 0 2 3.**  
**The number of elements removed from hm3 is: 1.**  
**After another element with a key equal to that**  
**of the 2nd element is deleted, the hash_map hm3 is: 0 3.**   
## Requirements  
 **Header:** <hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_map Class](../vs140/hash_map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)