---
title: "basic_istream::readsome"
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
  - "basic_istream.readsome"
  - "basic_istream::readsome"
  - "std::basic_istream::readsome"
  - "std.basic_istream.readsome"
  - "istream/std::basic_istream::readsome"
  - "readsome"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "readsome method"
ms.assetid: 280423b5-9c5d-4133-b558-87b0285c019d
caps.latest.revision: 29
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_istream::readsome
Reads the specified number of character values.  
  
 This method is potentially unsafe, as it relies on the caller to check that the passed values are correct.  
  
## Syntax  
  
```  
streamsize readsome(  
    char_type *str,  
    streamsize count  
);  
```  
  
#### Parameters  
 `str`  
 The array in which `readsome` stores the characters it reads.  
  
 `count`  
 The number of characters to read.  
  
## Return Value  
 The number of characters actually read, [gcount](../vs140/basic_istream--gcount.md).  
  
## Remarks  
 This unformatted input function extracts up to `count` elements from the input stream and stores them in the array `str`.  
  
 This function does not wait for input. It reads whatever data is available.  
  
## Example  
  
```  
// basic_istream_readsome.cpp  
// compile with: /EHsc /W3  
#include <iostream>  
using namespace std;  
  
int main( )  
{  
   char c[10];  
   int count = 5;  
  
   cout << "Type 'abcdefgh': ";  
  
   // cin.read blocks until user types input.  
   // Note: cin::read is potentially unsafe, consider  
   // using cin::_Read_s instead.  
   cin.read(&c[0], 2);  
  
   // Note: cin::readsome is potentially unsafe, consider  
   // using cin::_Readsome_s instead.  
   int n = cin.readsome(&c[0], count);  // C4996  
   c[n] = 0;  
   cout << n << " characters read" << endl;  
   cout << c << endl;  
}  
```  
  
## Input  
  
```  
abcdefgh  
```  
  
## Sample Output  
  
```  
Type 'abcdefgh': abcdefgh  
5 characters read  
cdefg  
```  
  
## Requirements  
 **Header:** \<istream>  
  
 **Namespace:** std  
  
## See Also  
 [basic_istream Class](../vs140/basic_istream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)