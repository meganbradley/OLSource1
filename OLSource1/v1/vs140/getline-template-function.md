---
title: "getline Template Function"
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
  - "GetLine"
  - "getline"
  - "std.getline"
  - "basic_istream.getline"
  - "std::basic_istream::getline"
  - "basic_istream::getline"
  - "istream/std::basic_istream::getline"
  - "string/std::getline"
  - "std::getline"
  - "std.basic_istream.getline"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "getline method"
  - "getline"
  - "getline function"
ms.assetid: d8c3bf01-8c1d-4f40-8cca-1401e165b49e
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# getline Template Function
Extract strings from the input stream line-by-line.  
  
## Syntax  
  
```  
// (1) delimiter as parameter  
template<class CharType, class Traits, class Allocator>  
basic_istream<CharType, Traits>& getline(  
    basic_istream<CharType, Traits>& is,  
    basic_string<CharType, Traits, Allocator>& str, CharType delim);  
  
template<class CharType, class Traits, class Allocator>  
basic_istream<CharType, Traits>& getline(  
    basic_istream<CharType, Traits>&& is,  
    basic_string<CharType, Traits, Allocator>& str, const CharType delim);  
  
// (2) default delimiter used  
template<class CharType, class Traits, class Allocator>  
basic_istream<CharType, Traits>& getline(  
    basic_istream<CharType, Traits>& is,  
    basic_string<CharType, Traits, Allocator>& str);  
  
template<class Allocator, class Traits, class Allocator>  
basic_istream<Allocator, Traits>& getline(  
    basic_istream<Allocator, Traits>&& is,  
    basic_string<Allocator, Traits, Allocator>& str);  
  
```  
  
#### Parameters  
 `is`  
 The input stream from which a string is to be extracted.  
  
 `str`  
 The string into which are read the characters from the input stream.  
  
 `delim`  
 The line delimiter.  
  
## Return Value  
 The input stream `is`.  
  
## Remarks  
 The pair of function signatures marked `(1)` extract characters from `is` until `delim` is found, storing them in `str`.  
  
 The pair of function signatures marked `(2)` use newline as the default line delimiter and behave as **getline**(`is`, `str`, `is`.`widen`('`\n`')).  
  
 The second function of each pair is an analog to the first one to support [rvalue references](../vs140/lvalues-and-rvalues--visual-c---.md).  
  
 Extraction stops when one of the following occurs:  
  
-   At end-of-file, in which case the internal state flag of `is` is set to `ios_base::eofbit`.  
  
-   After the function extracts an element that compares equal to **delim**, in which case the element is neither put back nor appended to the controlled sequence.  
  
-   After the function extracts `str.`[max_size](../vs140/basic_string--max_size.md) elements, in which case the internal state flag of `is` is set to `ios_base::failbit`.  
  
-   Some other error other than those previously listed, in which case the internal state flag of `is` is set to `ios_base::badbit`  
  
 For information about internal state flags, see [ios_base::iostate](../vs140/ios_base--iostate.md).  
  
 If the function extracts no elements, the internal state flag of `is` is set to `ios_base::failbit`. In any case, `getline` returns `is`.  
  
 If an exception is thrown, `is` and `str` are left in a valid state.  
  
## Example  
 The following code demonstrates `getline()` in two modes: first with the default delimiter (newline) and second with a whitespace as delimiter. The end-of-file character (CTRL-Z on the keyboard) is used to control termination of the while loops. This sets the internal state flag of `cin` to `eofbit`, which must be cleared with [basic_ios::clear()](../vs140/basic_ios--clear.md) before the second while loop will work properly.  
  
```cpp  
// compile with: /EHsc /W4  
#include <string>  
#include <iostream>  
#include <vector>  
  
using namespace std;  
  
int main()  
{  
    string str;  
    vector<string> v1;  
    cout << "Enter a sentence, press ENTER between sentences. (Ctrl-Z to stop): " << endl;  
    // Loop until end-of-file (Ctrl-Z) is input, store each sentence in a vector.  
    // Default delimiter is the newline character.  
    while (getline(cin, str)) {  
        v1.push_back(str);  
    }  
  
    cout << "The following input was stored with newline delimiter:" << endl;  
    for (const auto& p : v1) {  
        cout << p << endl;  
    }  
  
    cin.clear();  
  
    vector<string> v2;  
    // Now try it with a whitespace delimiter  
    while (getline(cin, str, ' ')) {  
        v2.push_back(str);  
    }  
  
    cout << "The following input was stored with whitespace as delimiter:" << endl;  
    for (const auto& p : v2) {  
        cout << p << endl;  
    }  
}  
  
```  
  
## Output  
 **Enter a sentence, press ENTER between sentences. (Ctrl-Z to stop):This is test one.New line.^ZThe following input was stored with newline delimiter:This is test one.New line.This is test two.New line.^ZThe following input was stored with whitespace as delimiter:Thisistesttwo.Newline.**   
## Requirements  
 **Header:** <string\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)   
 [<string\>](../vs140/-string-.md)