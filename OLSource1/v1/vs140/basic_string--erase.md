---
title: "basic_string::erase"
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
  - "std.basic_string.erase"
  - "erase"
  - "xstring/std::basic_string::erase"
  - "basic_string::erase"
  - "std::basic_string::erase"
  - "Erase"
  - "basic_string.erase"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "erase method"
ms.assetid: f5dda847-81b9-4c21-b68a-c97ab5ba46ad
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::erase
Removes an element or a range of elements in a string from a specified position.  
  
## Syntax  
  
```  
iterator erase(  
    iterator _First,   
    iterator _Last  
);  
iterator erase(  
    iterator _It  
);  
basic_string<CharType, Traits, Allocator>& erase(  
    size_type _Pos = 0,  
    size_type _Count = npos  
);  
```  
  
#### Parameters  
 `_First`  
 An iterator addressing the position of the first element in the range to be erased.  
  
 `_Last`  
 An iterator addressing the position one past the last element in the range to be erased.  
  
 `_It`  
 An iterator addressing the position of the element in the string to be erased.  
  
 `_Pos`  
 The index of the first character in the string to be removed.  
  
 `_Count`  
 The number of elements that will be removed if there are as many in the range of the string beginning with *_Pos*.  
  
## Return Value  
 For the first two member functions, an iterator addressing the first character after the last character removed by the member function. For the third member function, a reference to the string object from which the elements have been erased.  
  
## Remarks  
 The third member function returns **\*this**.  
  
## Example  
  
```  
// basic_string_erase.cpp  
// compile with: /EHsc  
#include <string>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
  
   // The 1st member function using a range demarcated  
   // by iterators  
   string str1 ( "Hello world" );  
   basic_string <char>::iterator str1_Iter;  
   cout << "The original string object str1 is: "   
        << str1 << "." << endl;  
   str1_Iter = str1.erase ( str1.begin ( ) + 3 , str1.end ( ) - 1 );  
   cout << "The first element after those removed is: "  
        << *str1_Iter << "." << endl;  
   cout << "The modified string object str1 is: " << str1   
           << "." << endl << endl;  
  
   // The 2nd member function erasing a char pointed to   
   // by an iterator  
   string str2 ( "Hello World" );  
   basic_string <char>::iterator str2_Iter;  
   cout << "The original string object str2 is: " << str2  
        << "." << endl;  
   str2_Iter = str2.erase ( str2.begin ( ) + 5 );  
   cout << "The first element after those removed is: "  
        << *str2_Iter << "." << endl;  
   cout << "The modified string object str2 is: " << str2   
        << "." << endl << endl;  
  
   // The 3rd member function erasing a number of chars   
   // after a char  
   string str3 ( "Hello computer" ), str3m;  
   basic_string <char>::iterator str3_Iter;  
   cout << "The original string object str3 is: "   
        << str3 << "." << endl;  
   str3m = str3.erase ( 6 , 8 );  
   cout << "The modified string object str3m is: "   
        << str3m << "." << endl;  
}  
```  
  
 **The original string object str1 is: Hello world.**  
**The first element after those removed is: d.**  
**The modified string object str1 is: Held.**  
**The original string object str2 is: Hello World.**  
**The first element after those removed is: W.**  
**The modified string object str2 is: HelloWorld.**  
**The original string object str3 is: Hello computer.**  
**The modified string object str3m is: Hello .**   
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)