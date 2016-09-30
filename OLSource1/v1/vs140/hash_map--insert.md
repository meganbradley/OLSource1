---
title: "hash_map::insert"
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
  - "hash_map::insert"
  - "hash_map.insert"
  - "Insert"
  - "hash_map/stdext::hash_map::insert"
  - "std.hash_map.insert"
  - "std::hash_map::insert"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "insert method"
ms.assetid: e74c8b76-c3e9-4769-a173-cf96167ea005
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_map::insert
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Inserts an element or a range of elements into a hash_map.  
  
## Syntax  
  
```  
pair <iterator, bool> insert(  
    const value_type& _Val  
);  
iterator insert(  
    const_iterator _Where,  
    const value_type& _Val  
);  
template<class InputIterator>  
    void insert(  
        InputIterator _First,  
        InputIterator _Last  
);  
template<class ValTy>  
    pair <iterator, bool> insert(  
        ValTy&& _Val  
);  
template<class ValTy>  
    iterator insert(  
        const_iterator _Where,  
        ValTy&& _Val  
);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`_Val`|The value of an element to be inserted into the hash_map unless the hash_map already contains that element (or, more generally, an element whose key is equivalently ordered).|  
|`_Where`|A hint regarding the place to start searching for the correct point of insertion.|  
|`_First`|The position of the first element to be copied from a hash_map.|  
|`_Last`|The position just beyond the last element to be copied from a hash_map.|  
  
## Return Value  
 The first **insert** member function returns a pair whose bool component returns true if an insertion was made and false if the hash_map already contained an element whose key had an equivalent value in the ordering, and whose iterator component returns the address where a new element was inserted or where the element was already located.  
  
 To access the iterator component of a pair `pr` returned by this member function, use `pr`.**first**, and to dereference it, use \*(`pr`.**first**). To access the `bool` component of a pair `pr` returned by this member function, use `pr`.**second**, and to dereference it, use \*(`pr`.**second**).  
  
 The second **insert** member function, the hint version, returns an iterator that points to the position where the new element was inserted into the hash_map.  
  
 The last two **insert** member functions behave the same as the first two, except that they move construct the inserted value.  
  
## Remarks  
 The [value_type](../vs140/map--value_type.md) of an element is a pair, so that the value of an element will be an ordered pair with the first component equal to the key value and the second component equal to the data value of the element.  
  
 Insertion can occur in amortized constant time for the hint version of insert, instead of logarithmic time, if the insertion point immediately follows `_Where`.  
  
 The third member function inserts the sequence of element values into a hash_map corresponding to each element addressed by an iterator of in the range *[First, Last)* of a specified set.  
  
## Example  
  
```  
// hash_map_insert.cpp  
// compile with: /EHsc  
#include<hash_map>  
#include<iostream>  
#include <string>  
  
int main()  
{  
    using namespace std;  
    using namespace stdext;  
    hash_map<int, int>::iterator hm1_pIter, hm2_pIter;  
  
    hash_map<int, int> hm1, hm2;  
    typedef pair<int, int> Int_Pair;  
  
    hm1.insert(Int_Pair(1, 10));  
    hm1.insert(Int_Pair(2, 20));  
    hm1.insert(Int_Pair(3, 30));  
    hm1.insert(Int_Pair(4, 40));  
  
    cout<< "The original elements (Key => Value) of hm1 are:";  
    for (hm1_pIter = hm1.begin(); hm1_pIter != hm1.end(); hm1_pIter++)  
        cout << endl << " " << hm1_pIter -> first << " => "  
             << hm1_pIter->second;  
    cout << endl;  
  
    pair< hash_map<int,int>::iterator, bool > pr;  
    pr = hm1.insert(Int_Pair(1, 10));  
  
    if (pr.second == true)  
    {  
        cout<< "The element 10 was inserted in hm1 successfully."  
            << endl;  
    }  
    else  
    {  
        cout<< "The element 10 already exists in hm1\n with a key value of"  
            << "((pr.first) -> first)= "<<(pr.first)-> first  
            << "."<< endl;  
    }  
  
    // The hint version of insert  
    hm1.insert(--hm1.end(), Int_Pair(5, 50));  
  
    cout<< "After the insertions, the elements of hm1 are:";  
    for (hm1_pIter = hm1.begin(); hm1_pIter != hm1.end(); hm1_pIter++)  
        cout << endl << " " << hm1_pIter -> first << " => "  
             << hm1_pIter->second;  
    cout << endl;  
  
    hm2.insert(Int_Pair(10, 100));  
  
    // The templatized version inserting a range  
    hm2.insert( ++hm1.begin(), --hm1.end() );  
  
    cout<< "After the insertions, the elements of hm2 are:";  
    for (hm2_pIter = hm2.begin(); hm2_pIter != hm2.end(); hm2_pIter++)  
        cout << endl << " " << hm2_pIter -> first << " => "  
             << hm2_pIter->second;  
    cout << endl;  
  
    // The templatized versions move constructing elements  
    hash_map<int, string> hm3, hm4;  
    pair<int, string> is1(1, "a"), is2(2, "b");  
  
    hm3.insert(move(is1));  
    cout << "After the move insertion, hm3 contains:" << endl  
      << " " << hm3.begin()->first  
      << " => " << hm3.begin()->second  
      << endl;  
  
    hm4.insert(hm4.begin(), move(is2));  
    cout << "After the move insertion, hm4 contains:" << endl  
      << " " << hm4.begin()->first  
      << " => " << hm4.begin()->second  
      << endl;  
}  
```  
  
 **The original elements (Key => Value) of hm1 are:**  
 **1 => 10**  
 **2 => 20**  
 **3 => 30**  
 **4 => 40**  
**The element 10 already exists in hm1**  
 **with a key value of((pr.first) -> first)= 1.**  
**After the insertions, the elements of hm1 are:**  
 **1 => 10**  
 **2 => 20**  
 **3 => 30**  
 **4 => 40**  
 **5 => 50**  
**After the insertions, the elements of hm2 are:**  
 **2 => 20**  
 **10 => 100**  
 **3 => 30**  
 **4 => 40**  
**After the move insertion, hm3 contains:**  
 **1 => a**  
**After the move insertion, hm4 contains:**  
 **2 => b**   
## Requirements  
 **Header:** \<hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_map Class](../vs140/hash_map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)