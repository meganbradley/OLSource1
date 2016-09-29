---
title: "hash_set::erase"
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
  - "std.hash_set.erase"
  - "erase"
  - "hash_set::erase"
  - "std::hash_set::erase"
  - "hash_set.erase"
  - "hash_set/stdext::hash_set::erase"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "erase method"
ms.assetid: a576f2fe-a8cc-4cf3-9121-b212523bca90
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_set::erase
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_set Class](../vs140/unordered_set-class.md).  
  
 Removes an element or a range of elements in a hash_set from specified positions or removes elements that match a specified key.  
  
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
 Position of the element to be removed from the hash_set.  
  
 `_First`  
 Position of the first element removed from the hash_set.  
  
 `_Last`  
 Position just beyond the last element removed from the hash_set.  
  
 `_Key`  
 The key of the elements to be removed from the hash_set.  
  
## Return Value  
 For the first two member functions, a bidirectional iterator that designates the first element remaining beyond any elements removed, or a pointer to the end of the hash_set if no such element exists. For the third member function, the number of elements that have been removed from the hash_set.  
  
## Remarks  
 The member functions never throw an exception.  
  
 In Visual C++ .NET 2003, members of the [<hash_map>](../vs140/-hash_map-.md) and [<hash_set>](../vs140/-hash_set-.md) header files are no longer in the std namespace, but rather have been moved into the stdext namespace. See [The stdext Namespace](../vs140/stdext-namespace.md) for more information.  
  
## Example  
 The following example demonstrates the use of the hash_set::erase member function.  
  
```  
// hash_set_erase.cpp  
// compile with: /EHsc  
#include <hash_set>  
#include <iostream>  
  
int main()  
{  
    using namespace std;  
    using namespace stdext;  
    hash_set<int> hs1, hs2, hs3;  
    hash_set<int>::iterator pIter, Iter1, Iter2;  
    int i;  
    hash_set<int>::size_type n;  
  
    for (i = 1; i < 5; i++)  
    {  
        hs1.insert (i);  
        hs2.insert (i * i);  
        hs3.insert (i - 1);  
    }  
  
    // The 1st member function removes an element at a given position  
    Iter1 = ++hs1.begin();  
    hs1.erase(Iter1);  
  
    cout << "After the 2nd element is deleted, the hash_set hs1 is:";  
    for (pIter = hs1.begin(); pIter != hs1.end(); pIter++)  
        cout << " " << *pIter;  
    cout << "." << endl;  
  
    // The 2nd member function removes elements  
    // in the range [_First, _Last)  
    Iter1 = ++hs2.begin();  
    Iter2 = --hs2.end();  
    hs2.erase(Iter1, Iter2);  
  
    cout << "After the middle two elements are deleted, "  
         << "the hash_set hs2 is:";  
    for (pIter = hs2.begin(); pIter != hs2.end(); pIter++)  
        cout << " " << *pIter;  
    cout << "." << endl;  
  
    // The 3rd member function removes elements with a given _Key  
    n = hs3.erase(2);  
  
    cout << "After the element with a key of 2 is deleted, "  
         << "the hash_set hs3 is:";  
    for (pIter = hs3.begin(); pIter != hs3.end(); pIter++)  
        cout << " " << *pIter;  
    cout << "." << endl;  
  
    // The 3rd member function returns the number of elements removed  
    cout << "The number of elements removed from hs3 is: "  
         << n << "." << endl;  
  
    // The dereferenced iterator can also be used to specify a key  
    Iter1 = ++hs3.begin();  
    hs3.erase(Iter1);  
  
    cout << "After another element (unique for hash_set) with a key "  
         << endl;  
    cout  << "equal to that of the 2nd element is deleted, "  
          << "the hash_set hs3 is:";  
    for (pIter = hs3.begin(); pIter != hs3.end(); pIter++)  
        cout << " " << *pIter;  
    cout << "." << endl;  
}  
```  
  
 **After the 2nd element is deleted, the hash_set hs1 is: 1 3 4.**  
**After the middle two elements are deleted, the hash_set hs2 is: 16 4.**  
**After the element with a key of 2 is deleted, the hash_set hs3 is: 0 1 3.**  
**The number of elements removed from hs3 is: 1.**  
**After another element (unique for hash_set) with a key**   
**equal to that of the 2nd element is deleted, the hash_set hs3 is: 0 3.**   
## Requirements  
 **Header:** <hash_set>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_set Class](../vs140/hash_set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)