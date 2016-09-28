---
title: "basic_string::basic_string"
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
  - "std.basic_string.basic_string"
  - "basic_string.basic_string"
  - "std::basic_string::basic_string"
  - "basic_string::basic_string"
  - "basic_string"
  - "xstring/std::basic_string::basic_string"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "basic_string method"
  - "basic_string class, constructor"
ms.assetid: efd3bec9-e7a5-4527-9ba6-7d5054bdb9f1
caps.latest.revision: 27
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::basic_string
Constructs a string that is empty, initialized by specific characters, or is a copy of all or part of another string object or C style (null-terminated) string.  
  
## Syntax  
  
```  
basic_string();  
explicit basic_string(  
    const allocator_type& _Al  
);  
basic_string(  
    const basic_string& _Right  
);  
basic_string(  
    basic_string&& _Right  
);  
basic_string(  
    const basic_string& _Right,   
    size_type _Roff,  
    size_type _Count = npos  
);  
basic_string(  
    const basic_string& _Right,   
    size_type _Roff,  
    size_type _Count,   
    const allocator_type& _Al  
);  
basic_string(  
    const value_type *_Ptr,   
    size_type _Count  
);  
basic_string(  
    const value_type *_Ptr,   
    size_type _Count,  
    const allocator_type& _Al  
);  
basic_string(  
    const value_type *_Ptr  
);  
basic_string(  
    const value_type *_Ptr,  
    const allocator_type& _Al  
);  
basic_string(  
    size_type _Count,   
    value_type _Ch  
);  
basic_string(  
    size_type _Count,   
    value_type _Ch,  
    const allocator_type& _Al  
);  
template <class InputIterator>  
    basic_string(  
        InputIterator _First,   
        InputIterator _Last  
    );  
template <class InputIterator>  
    basic_string(  
        InputIterator _First,   
        InputIterator _Last,   
        const allocator_type& _Al  
    );  
basic_string(  
   const_pointer _First,  
   const_pointer _Last  
);  
basic_string(  
   const_iterator _First,  
   const_iterator _Last  
);  
  
```  
  
#### Parameters  
 `_Ptr`  
 The C-string whose characters are to be used to initialize the `string` being constructed. This value cannot be a null pointer.  
  
 `_Al`  
 The storage allocator class for the string object being constructed.  
  
 `_Count`  
 The number of characters to be initialized.  
  
 `_Right`  
 The string to initialize the string being constructed.  
  
 `_Roff`  
 The index of a character in a string that is the first to be used to initialize character values for the string being constructed.  
  
 `_Ch`  
 The character value to be copied into the string being constructed.  
  
 `_First`  
 An input iterator, const_pointer, or const_iterator addressing the first element in the source range to be inserted.  
  
 `_Last`  
 An input iterator, const_pointer, or const_iterator addressing the position of the one beyond the last element in the source range to be inserted.  
  
## Return Value  
 A reference to the string object that is being constructed by the constructors.  
  
## Remarks  
 All constructors store an [basic_string::allocator_type](../vs140/basic_string--allocator_type.md) and initialize the controlled sequence. The allocator object is the argument `al`, if present. For the copy constructor, it is `right.`[get_allocator](../vs140/basic_string--get_allocator.md)`()`. Otherwise, it is `Alloc()`.  
  
 The controlled sequence is initialized to a copy of the operand sequence specified by the remaining operands. A constructor without an operand sequence specifies an empty initial controlled sequence. If `InputIterator` is an integer type in a template constructor, the operand sequence _F`irst, _Last` behaves the same as `(size_type)_First, (value_type)_Last`.  
  
## Example  
  
```  
// basic_string_ctor.cpp  
// compile with: /EHsc  
#include <string>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
  
   // The first member function initializing with a C-string  
   const char *cstr1a = "Hello Out There.";  
   basic_string <char> str1a ( cstr1a , 5);  
   cout << "The string initialized by C-string cstr1a is: "  
        << str1a << "." << endl;  
  
   // The second member function initializing with a string  
   string  str2a ( "How Do You Do?" );  
   basic_string <char> str2b ( str2a , 7 , 7 );  
   cout << "The string initialized by part of the string cstr2a is: "  
        << str2b << "." << endl;  
  
   // The third member function initializing a string  
   // with a number of characters of a specific value  
   basic_string <char> str3a ( 5, '9' );  
   cout << "The string initialized by five number 9s is: "  
        << str3a << endl;  
  
   // The fourth member function creates an empty string  
   // and string with a specified allocator  
   basic_string <char> str4a;  
   string str4b;  
   basic_string <char> str4c ( str4b.get_allocator( ) );  
   if (str4c.empty ( ) )  
      cout << "The string str4c is empty." << endl;  
   else  
      cout << "The string str4c is not empty." << endl;  
  
   // The fifth member function initializes a string from  
   // another range of characters  
   string str5a ( "Hello World" );  
   basic_string <char> str5b ( str5a.begin ( ) + 5 , str5a.end ( ) );  
   cout << "The string initialized by another range is: "  
        << str5b << "." << endl;  
}  
```  
  
## Output  
  
```  
The string initialized by C-string cstr1a is: Hello.  
The string initialized by part of the string cstr2a is: You Do?.  
The string initialized by five number 9s is: 99999  
The string str4c is empty.  
The string initialized by another range is:  World.  
```  
  
## Requirements  
 **Header:** <string\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)   
 [<string\>](../vs140/-string-.md)   
 [Lvalues and Rvalues](../vs140/lvalues-and-rvalues--visual-c---.md)