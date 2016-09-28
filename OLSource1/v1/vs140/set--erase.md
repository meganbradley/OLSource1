---
title: "set::erase"
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
  - "std::set::erase"
  - "set::erase"
  - "erase"
  - "set/std::set::erase"
  - "set.erase"
  - "std.set.erase"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "erase method"
ms.assetid: 959f262f-5829-4e53-a029-eaea8f21021a
caps.latest.revision: 27
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# set::erase
Removes an element or a range of elements in a set from specified positions or removes elements that match a specified key.  
  
## Syntax  
  
```  
iterator erase(  
   const_iterator Where  
);  
iterator erase(  
   const_iterator First,  
   const_iterator Last  
);  
size_type erase(  
   const key_type& Key  
);  
```  
  
#### Parameters  
 `Where`  
 Position of the element to be removed.  
  
 `First`  
 Position of the first element to be removed.  
  
 `Last`  
 Position just beyond the last element to be removed.  
  
 `Key`  
 The key value of the elements to be removed.  
  
## Return Value  
 For the first two member functions, a bidirectional iterator that designates the first element remaining beyond any elements removed, or an element that is the end of the set if no such element exists.  
  
 For the third member function, returns the number of elements that have been removed from the set.  
  
## Remarks  
  
## Example  
  
```cpp  
// set_erase.cpp  
// compile with: /EHsc  
#include <set>  
#include <string>  
#include <iostream>  
#include <iterator> // next() and prev() helper functions  
  
using namespace std;  
  
using myset = set<string>;  
  
void printset(const myset& s) {  
    for (const auto& iter : s) {  
        cout << " [" << iter << "]";  
    }  
    cout << endl << "size() == " << s.size() << endl << endl;  
}  
  
int main()  
{  
    myset s1;  
  
    // Fill in some data to test with, one at a time  
    s1.insert("Bob");  
    s1.insert("Robert");  
    s1.insert("Bert");  
    s1.insert("Rob");  
    s1.insert("Bobby");  
  
    cout << "Starting data of set s1 is:" << endl;  
    printset(s1);  
    // The 1st member function removes an element at a given position  
    s1.erase(next(s1.begin()));  
    cout << "After the 2nd element is deleted, the set s1 is:" << endl;  
    printset(s1);  
  
    // Fill in some data to test with, one at a time, using an intializer list  
    myset s2{ "meow", "hiss", "purr", "growl", "yowl" };  
  
    cout << "Starting data of set s2 is:" << endl;  
    printset(s2);  
    // The 2nd member function removes elements  
    // in the range [First, Last)  
    s2.erase(next(s2.begin()), prev(s2.end()));  
    cout << "After the middle elements are deleted, the set s2 is:" << endl;  
    printset(s2);  
  
    myset s3;  
  
    // Fill in some data to test with, one at a time, using emplace  
    s3.emplace("C");  
    s3.emplace("C#");  
    s3.emplace("D");  
    s3.emplace("D#");  
    s3.emplace("E");  
    s3.emplace("E#");  
    s3.emplace("F");  
    s3.emplace("F#");  
    s3.emplace("G");  
    s3.emplace("G#");  
    s3.emplace("A");  
    s3.emplace("A#");  
    s3.emplace("B");  
  
    cout << "Starting data of set s3 is:" << endl;  
    printset(s3);  
    // The 3rd member function removes elements with a given Key  
    myset::size_type count = s3.erase("E#");  
    // The 3rd member function also returns the number of elements removed  
    cout << "The number of elements removed from s3 is: " << count << "." << endl;  
    cout << "After the element with a key of \"E#\" is deleted, the set s3 is:" << endl;  
    printset(s3);  
}  
  
```  
  
## Output  
  
```  
Starting data of set s1 is:  
 [Bert] [Bob] [Bobby] [Rob] [Robert]  
size() == 5  
  
After the 2nd element is deleted, the set s1 is:  
 [Bert] [Bobby] [Rob] [Robert]  
size() == 4  
  
Starting data of set s2 is:  
 [growl] [hiss] [meow] [purr] [yowl]  
size() == 5  
  
After the middle elements are deleted, the set s2 is:  
 [growl] [yowl]  
size() == 2  
  
Starting data of set s3 is:  
 [A] [A#] [B] [C] [C#] [D] [D#] [E] [E#] [F] [F#] [G] [G#]  
size() == 13  
  
The number of elements removed from s3 is: 1.  
After the element with a key of "E#" is deleted, the set s3 is:  
 [A] [A#] [B] [C] [C#] [D] [D#] [E] [F] [F#] [G] [G#]  
size() == 12  
```  
  
## Requirements  
 **Header:** <set\>  
  
 **Namespace:** std  
  
## See Also  
 [<set\>](../vs140/-set-.md)   
 [set Class](../vs140/set-class.md)   
 [set::clear](../vs140/set--clear.md)   
 [Standard Template Library](../vs140/standard-template-library.md)