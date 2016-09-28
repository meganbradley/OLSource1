---
title: "basic_streambuf::sungetc"
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
  - "std.basic_streambuf.sungetc"
  - "sungetc"
  - "basic_streambuf.sungetc"
  - "std::basic_streambuf::sungetc"
  - "basic_streambuf::sungetc"
  - "streambuf/std::basic_streambuf::sungetc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "sungetc method"
ms.assetid: 2ab42d0f-7252-4a14-8887-a25cc997b2d1
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_streambuf::sungetc
Gets a character from the stream.  
  
## Syntax  
  
```  
  
int  
_  
type sungetc( );  
  
```  
  
## Return Value  
 Returns either the character or failure.  
  
## Remarks  
 If a putback position is available, the member function decrements the next pointer for the input buffer and returns `traits_type::`[to_int_type](../vs140/char_traits--to_int_type.md)(`*`[gptr](../vs140/basic_streambuf--gptr.md)). However, it is not always possible to determine the last character read so that it can be captured in the state of the current buffer. If this is true, then the function returns [pbackfail](../vs140/basic_streambuf--pbackfail.md). To avoid this situation, keep track of the character to put back and call `sputbackc(ch)`, which will not fail provided you don't call it at the beginning of the stream and you don't try to put back more than one character.  
  
## Example  
  
```  
// basic_streambuf_sungetc.cpp  
// compile with: /EHsc  
#include <iostream>  
#include <fstream>  
  
int main( )   
{  
   using namespace std;  
  
   ifstream myfile( "basic_streambuf_sungetc.txt", ios::in );  
  
   // Read and increment  
   int i = myfile.rdbuf( )->sbumpc( );  
   cout << ( char )i << endl;  
  
   // Read and increment  
   i = myfile.rdbuf( )->sbumpc( );  
   cout << ( char )i << endl;  
  
   // Decrement, read, and do not increment  
   i = myfile.rdbuf( )->sungetc( );  
   cout << ( char )i << endl;  
  
   i = myfile.rdbuf( )->sungetc( );   
   cout << ( char )i << endl;  
  
   i = myfile.rdbuf( )->sbumpc( );  
   cout << ( char )i << endl;  
}  
```  
  
## Input: basic_streambuf_sungetc.txt  
  
```  
testing  
```  
  
### Output  
  
```  
t  
e  
e  
t  
t  
```  
  
## Requirements  
 **Header:** <streambuf\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_streambuf Class](../vs140/basic_streambuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)