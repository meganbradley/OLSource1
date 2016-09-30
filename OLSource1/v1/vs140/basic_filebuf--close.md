---
title: "basic_filebuf::close"
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
  - "std.basic_filebuf.close"
  - "fstream/std::basic_filebuf::close"
  - "Close"
  - "close"
  - "std::basic_filebuf::close"
  - "basic_filebuf::close"
  - "basic_filebuf.close"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "close method"
ms.assetid: 04a7b7ca-c541-4055-b07f-8c61b22fa497
caps.latest.revision: 21
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_filebuf::close
Closes a file.  
  
## Syntax  
  
```  
basic_filebuf<Elem, Tr> *close( );  
```  
  
## Return Value  
 The member function returns a null pointer if the file pointer is a null pointer.  
  
## Remarks  
 **close** calls `fclose`(**fp**). If that function returns a nonzero value, the function returns a null pointer. Otherwise, it returns **this** to indicate that the file was successfully closed.  
  
 For a wide stream, if any insertions have occurred since the stream was opened, or since the last call to `streampos`, the function calls [overflow](../vs140/basic_filebuf--overflow.md). It also inserts any sequence needed to restore the initial conversion state, by using the file conversion facet **fac** to call **fac.unshift** as needed. Each element **byte** of type `char` thus produced is written to the associated stream designated by the file pointer **fp** as if by successive calls of the form `fputc`(**byte**, **fp**). If the call to **fac.unshift** or any write fails, the function does not succeed.  
  
## Example  
 The following sample assumes two files in the current directory: basic_filebuf_close.txt (contents is "testing") and iotest.txt (contents is "ssss").  
  
```  
// basic_filebuf_close.cpp  
// compile with: /EHsc  
#include <fstream>  
#include <iostream>  
  
int main() {  
   using namespace std;  
   ifstream file;  
   basic_ifstream <wchar_t> wfile;  
   char c;  
   // Open and close with a basic_filebuf  
   file.rdbuf()->open( "basic_filebuf_close.txt", ios::in );  
   file >> c;  
   cout << c << endl;  
   file.rdbuf( )->close( );  
  
   // Open/close directly  
   file.open( "iotest.txt" );  
   file >> c;  
   cout << c << endl;  
   file.close( );  
  
   // open a file with a wide character name  
   wfile.open( L"iotest.txt" );  
  
   // Open and close a nonexistent with a basic_filebuf  
   file.rdbuf()->open( "ziotest.txt", ios::in );  
   cout << file.fail() << endl;  
   file.rdbuf( )->close( );  
  
   // Open/close directly  
   file.open( "ziotest.txt" );  
   cout << file.fail() << endl;  
   file.close( );  
}  
```  
  
 **t**  
**s**  
**0**  
**1**   
## Requirements  
 **Header:** \<fstream>  
  
 **Namespace:** std  
  
## See Also  
 [basic_filebuf Class](../vs140/basic_filebuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)