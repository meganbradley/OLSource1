---
title: "basic_string::empty"
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
  - "std::basic_string::empty"
  - "std.basic_string.empty"
  - "basic_string.empty"
  - "basic_string::empty"
  - "xstring/std::basic_string::empty"
  - "empty"
  - "Empty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "empty method"
ms.assetid: 360af490-1b51-422f-92d0-7f0bbb8eb960
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::empty
Tests whether the string contains characters or not.  
  
## Syntax  
  
```  
bool empty( ) const;  
```  
  
## Return Value  
 **true** if the string object contains no characters; **false** if it has at least one character.  
  
## Remarks  
 The member function is equivalent to [size](../vs140/basic_string--size.md) == 0.  
  
## Example  
  
```  
// basic_string_empty.cpp  
// compile with: /EHsc  
#include <string>  
#include <iostream>  
  
int main() {  
   using namespace std;  
  
   bool b1, b2;  
  
   string str1 ("Hello world");  
   cout << "The original string object str1 is: " << str1 << endl;  
   b1 = str1.empty();  
   if (b1)  
      cout << "The string object str1 is empty." << endl;  
   else  
      cout << "The string object str1 is not empty." << endl;  
   cout << endl;  
  
   // An example of an empty string object  
   string str2;  
   b2 = str2.empty();  
   if (b2)  
      cout << "The string object str2 is empty." << endl;  
   else  
      cout << "The string object str2 is not empty." << endl;  
}  
```  
  
## Output  
  
```  
The original string object str1 is: Hello world  
The string object str1 is not empty.  
  
The string object str2 is empty.  
```  
  
## Requirements  
 **Header:** <string\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)