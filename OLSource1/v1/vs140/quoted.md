---
title: "quoted"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - iomanip/std::quoted
dev_langs: 
  - C++
ms.assetid: 4aa0a287-7dcd-4721-bf95-c84ac2249d05
caps.latest.revision: 9
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# quoted
**(New in C++14)** An iostream manipulator that enables convenient round-tripping of strings into and out of streams using the >> and << operators.  
  
## Syntax  
  
```cpp  
quoted(std::string str) // or wstring  
quoted(const char* str) //or wchar_t*  
quoted(std::string str, char delimiter, char escape) // or wide versions  
quoted(const char* str, char delimiter, char escape) // or wide versions  
```  
  
#### Parameters  
 `str`  
 A std::string, char*, string literal or raw string literal, or a wide version of any of these (e.g. std::wstring, wchar_t\*).  
  
 `delimiter`  
 A user-specified character, or wide character, to use as the delimiter for the beginning and end of the string.  
  
 `escape`  
 A user-specified character, or wide character, to use as the escape character for escape sequences within the string.  
  
## Property Value/Return Value  
 Produces an object that manipulates the stream.  
  
## Exceptions  
 [ios_base::failure](../vs140/ios_base--failure.md)  
  
## Remarks  
 See [Using Insertion Operators and Controlling Format](../vs140/using-insertion-operators-and-controlling-format.md).  
  
## Example  
 This example shows how to use `quoted` with the default delimiter and escape character using narrow strings. Wide strings are equally supported.  
  
```  
  
#include <iostream>  
#include <iomanip>  
#include <sstream>  
  
using namespace std;  
  
void show_quoted_v_nonquoted()  
{  
    // Results are identical regardless of input string type:  
    // string inserted { R"(This is a "sentence".)" }; // raw string literal  
    // string inserted { "This is a \"sentence\"." };  // regular string literal  
    const char* inserted = "This is a \"sentence\".";  // const char*  
    stringstream ss, ss_quoted;  
    string extracted, extracted_quoted;  
  
    ss << inserted;  
    ss_quoted << quoted(inserted);  
  
    cout << "ss.str() is storing       : " << ss.str() << endl;  
    cout << "ss_quoted.str() is storing: " << ss_quoted.str() << endl << endl;  
  
    // Round-trip the strings   
    ss >> extracted;  
    ss_quoted >> quoted(extracted_quoted);  
  
    cout << "After round trip: " << endl;  
    cout << "Non-quoted      : " << extracted << endl;  
    cout << "Quoted          : " << extracted_quoted << endl;  
}  
  
void main(int argc, char* argv[])  
{  
    show_quoted_v_nonquoted();  
  
    // Keep console window open in debug mode.  
    cout << endl << "Press Enter to exit" << endl;  
    string input{};  
    getline(cin, input);  
}  
  
/* Output:  
ss.str() is storing       : This is a "sentence".  
ss_quoted.str() is storing: "This is a \"sentence\"."  
  
After round trip:  
Non-quoted      : This  
Quoted          : This is a "sentence".  
  
Press Enter to exit  
*/  
```  
  
## Example  
 The following example shows how to provide custom a delimiter and/or escape character:  
  
```  
#include <iostream>  
#include <iomanip>  
#include <sstream>  
  
using namespace std;  
  
void show_custom_delimiter()  
{  
    string inserted{ R"("This" "is" "a" "heavily-quoted" "sentence".)" };  
    // string inserted{ "\"This\" \"is\" \"a\" \"heavily-quoted\" \"sentence\"" };  
    // const char* inserted{ "\"This\" \"is\" \"a\" \"heavily-quoted\" \"sentence\"" };  
    stringstream ss, ss_quoted;  
    string extracted;  
  
    ss_quoted << quoted(inserted, '*');  
    ss << inserted;  
    cout << "ss_quoted.str() is storing: " << ss_quoted.str() << endl;  
    cout << "ss.str() is storing       : " << ss.str() << endl << endl;  
  
    // Use the same quoted arguments as on insertion.  
    ss_quoted >> quoted(extracted, '*');  
  
    cout << "After round trip: " << endl;  
    cout << "Quoted          : " << extracted << endl;  
  
    extracted = {};  
    ss >> extracted;  
    cout << "Non-quoted      : " << extracted << endl << endl;  
}  
  
void show_custom_escape()  
{  
    string inserted{ R"(\\root\trunk\branch\nest\egg\yolk)" };  
    // string inserted{ "\\\\root\\trunk\\branch\\nest\\egg\\yolk" };  
    stringstream ss, ss_quoted, ss_quoted_custom;  
    string extracted;  
  
    // Use '"' as delimiter and '~' as escape character.  
    ss_quoted_custom << quoted(inserted, '"', '~');  
    ss_quoted << quoted(inserted);  
    ss << inserted;  
    cout << "ss_quoted_custom.str(): " << ss_quoted_custom.str() << endl;  
    cout << "ss_quoted.str()       : " << ss_quoted.str() << endl;  
    cout << "ss.str()              : " << ss.str() << endl << endl;  
  
    // No spaces in this string, so non-quoted behaves same as quoted  
    // after round-tripping.  
}  
  
void main(int argc, char* argv[])  
{  
    cout << "Custom delimiter:" << endl;  
    show_custom_delimiter();  
    cout << "Custom escape character:" << endl;  
    show_custom_escape();  
  
    // Keep console window open in debug mode.  
    cout << endl << "Press Enter to exit" << endl;  
    string input{};  
    getline(cin, input);  
}  
/* Output:  
Custom delimiter:  
ss_quoted.str() is storing: *"This" "is" "a" "heavily-quoted" "sentence".*  
ss.str() is storing       : "This" "is" "a" "heavily-quoted" "sentence".  
  
After round trip:  
Quoted          : "This" "is" "a" "heavily-quoted" "sentence".  
Non-quoted      : "This"  
  
Custom escape character:  
ss_quoted_custom.str(): "\\root\trunk\branch\nest\egg\yolk"  
ss_quoted.str()       : "\\\\root\\trunk\\branch\\nest\\egg\\yolk"  
ss.str()              : \\root\trunk\branch\nest\egg\yolk  
  
Press Enter to exit  
*/  
  
```  
  
## Requirements  
 **Header:** <iomanip\>  
  
 **Namespace:** std  
  
## See Also  
 [<iomanip\>](../vs140/-iomanip-.md)   
 [Using Insertion Operators and Controlling Format](../vs140/using-insertion-operators-and-controlling-format.md)