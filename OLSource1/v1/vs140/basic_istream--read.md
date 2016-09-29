---
title: "basic_istream::read"
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
  - "istream/std::basic_istream::read"
  - "std::basic_istream::read"
  - "basic_istream.read"
  - "read"
  - "basic_istream::read"
  - "std.basic_istream.read"
  - "Read"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "read method"
ms.assetid: c74acbf9-da14-424d-a2a6-bb05a6a1bc0c
caps.latest.revision: 26
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_istream::read
Reads a specified number of characters from the stream and stores them in an array.  
  
 This method is potentially unsafe, as it relies on the caller to check that the passed values are correct.  
  
## Syntax  
  
```  
basic_istream<Elem, Tr>& read(  
    char_type *_Str,   
    streamsize _Count  
);  
```  
  
#### Parameters  
 `_Str`  
 The array in which to read the characters.  
  
 `_Count`  
 The number of characters to read.  
  
## Return Value  
 The stream (`*this`).  
  
## Remarks  
 The unformatted input function extracts up to `count` elements and stores them in the array beginning at _`Str`. Extraction stops early on end of file, in which case the function calls [setstate](../vs140/basic_ios--setstate.md)(`failbit`). In any case, it returns `*this`.  
  
## Example  
  
```  
// basic_istream_read.cpp  
// compile with: /EHsc  
#include <iostream>  
using namespace std;  
  
int main()  
{  
    char c[10];  
    int count = 5;  
  
    cout << "Type 'abcde': ";  
  
    // Note: cin::read is potentially unsafe, consider  
    // using cin::_Read_s instead.  
    cin.read(&c[0], count);  
    c[count] = 0;  
  
    cout << c << endl;  
}  
```  
  
  **`abcde` `abcde`Type 'abcde': abcde**  
**abcde**   
## Requirements  
 **Header:** \<istream>  
  
 **Namespace:** std  
  
## See Also  
 [basic_istream Class](../vs140/basic_istream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)