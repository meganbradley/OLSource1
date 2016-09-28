---
title: "map::erase"
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
  - "map.erase"
  - "erase"
  - "map::erase"
  - "map/std::map::erase"
  - "std.map.erase"
  - "std::map::erase"
  - "Erase"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "erase method"
ms.assetid: 72200c98-38a6-404a-95cf-eaab164014e7
caps.latest.revision: 31
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# map::erase
Removes an element or a range of elements in a map from specified positions or removes elements that match a specified key.  
  
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
 For the first two member functions, a bidirectional iterator that designates the first element remaining beyond any elements removed, or an element that is the end of the map if no such element exists.  
  
 For the third member function, returns the number of elements that have been removed from the map.  
  
## Example  
  
```cpp  
// map_erase.cpp  
// compile with: /EHsc  
#include <map>  
#include <string>  
#include <iostream>  
#include <iterator> // next() and prev() helper functions  
#include <utility>  // make_pair()  
  
using namespace std;  
  
using mymap = map<int, string>;  
  
void printmap(const mymap& m) {  
    for (const auto& elem : m) {  
        cout << " [" << elem.first << ", " << elem.second << "]";  
    }  
    cout << endl << "size() == " << m.size() << endl << endl;  
}  
  
int main()  
{  
    mymap m1;  
  
    // Fill in some data to test with, one at a time  
    m1.insert(make_pair(1, "A"));  
    m1.insert(make_pair(2, "B"));  
    m1.insert(make_pair(3, "C"));  
    m1.insert(make_pair(4, "D"));  
    m1.insert(make_pair(5, "E"));  
  
    cout << "Starting data of map m1 is:" << endl;  
    printmap(m1);  
    // The 1st member function removes an element at a given position  
    m1.erase(next(m1.begin()));  
    cout << "After the 2nd element is deleted, the map m1 is:" << endl;  
    printmap(m1);  
  
    // Fill in some data to test with, one at a time, using an intializer list  
    mymap m2  
    {  
        { 10, "Bob" },  
        { 11, "Rob" },  
        { 12, "Robert" },  
        { 13, "Bert" },  
        { 14, "Bobby" }  
    };  
  
    cout << "Starting data of map m2 is:" << endl;  
    printmap(m2);  
    // The 2nd member function removes elements  
    // in the range [First, Last)  
    m2.erase(next(m2.begin()), prev(m2.end()));  
    cout << "After the middle elements are deleted, the map m2 is:" << endl;  
    printmap(m2);  
  
    mymap m3;  
  
    // Fill in some data to test with, one at a time, using emplace  
    m3.emplace(1, "red");  
    m3.emplace(2, "yellow");  
    m3.emplace(3, "blue");  
    m3.emplace(4, "green");  
    m3.emplace(5, "orange");  
    m3.emplace(6, "purple");  
    m3.emplace(7, "pink");  
  
    cout << "Starting data of map m3 is:" << endl;  
    printmap(m3);  
    // The 3rd member function removes elements with a given Key  
    mymap::size_type count = m3.erase(2);  
    // The 3rd member function also returns the number of elements removed  
    cout << "The number of elements removed from m3 is: " << count << "." << endl;  
    cout << "After the element with a key of 2 is deleted, the map m3 is:" << endl;  
    printmap(m3);  
}  
  
```  
  
## Output  
  
```  
Starting data of map m1 is:  
 [1, A] [2, B] [3, C] [4, D] [5, E]  
size() == 5  
  
After the 2nd element is deleted, the map m1 is:  
 [1, A] [3, C] [4, D] [5, E]  
size() == 4  
  
Starting data of map m2 is:  
 [10, Bob] [11, Rob] [12, Robert] [13, Bert] [14, Bobby]  
size() == 5  
  
After the middle elements are deleted, the map m2 is:  
 [10, Bob] [14, Bobby]  
size() == 2  
  
Starting data of map m3 is:  
 [1, red] [2, yellow] [3, blue] [4, green] [5, orange] [6, purple] [7, pink]  
size() == 7  
  
The number of elements removed from m3 is: 1.  
After the element with a key of 2 is deleted, the map m3 is:  
 [1, red] [3, blue] [4, green] [5, orange] [6, purple] [7, pink]  
size() == 6  
```  
  
## Requirements  
 **Header:** <map\>  
  
 **Namespace:** std  
  
## See Also  
 [<map\>](../vs140/-map-.md)   
 [map Class](../vs140/map-class.md)   
 [map::clear](../vs140/map--clear.md)   
 [map::max_size, map::clear, map::erase, and map::size](../vs140/map--max_size--map--clear--map--erase--and-map--size.md)   
 [Standard Template Library](../vs140/standard-template-library.md)