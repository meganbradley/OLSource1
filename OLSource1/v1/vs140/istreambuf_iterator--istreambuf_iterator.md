---
title: "istreambuf_iterator::istreambuf_iterator"
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
  - istreambuf_iterator
  - istreambuf_iterator.istreambuf_iterator
  - istreambuf_iterator::istreambuf_iterator
  - std::istreambuf_iterator::istreambuf_iterator
  - streambuf/std::istreambuf_iterator::istreambuf_iterator
  - std.istreambuf_iterator.istreambuf_iterator
dev_langs: 
  - C++
helpviewer_keywords: 
  - istreambuf_iterator class, constructor
  - istreambuf_iterator method
ms.assetid: e9eea9b9-00d9-40c9-9a09-9bc387e0d8d5
caps.latest.revision: 17
translation.priority.mt: 
  - de-de
  - ja-jp
---
# istreambuf_iterator::istreambuf_iterator
Constructs an istreambuf_iterator that is initialized to read characters from the input stream.  
  
## Syntax  
  
```  
  
      istreambuf_iterator(  
   streambuf_type* _Strbuf = 0  
) throw( );  
istreambuf_iterator(  
   istream_type& _Istr  
) throw( );  
```  
  
#### Parameters  
 `_Strbuf`  
 The input stream buffer to which the `istreambuf_iterator` is being attached.  
  
 `_Istr`  
 The input stream to which the `istreambuf_iterator` is being attached.  
  
## Remarks  
 The first constructor initializes the input stream-buffer pointer with `_Strbuf`. The second constructor initializes the input stream-buffer pointer with `_Istr`.`rdbuf`, and then eventually attempts to extract and store an object of type **CharType**.  
  
## Example  
  
```  
// istreambuf_iterator_istreambuf_iterator.cpp  
// compile with: /EHsc  
#include <iterator>  
#include <vector>  
#include <algorithm>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
  
   // Following declarations will not compile:  
   istreambuf_iterator<char>::istream_type &istrm = cin;  
   istreambuf_iterator<char>::streambuf_type *strmbf = cin.rdbuf( );  
  
   cout << "(Try the example: 'Oh what a world!'\n"  
      << " then an Enter key to insert into the output,\n"  
      << " & use a ctrl-Z Enter key combination to exit): ";  
   istreambuf_iterator<char> charReadIn ( cin );  
   ostreambuf_iterator<char> charOut ( cout );  
  
   // Used in conjunction with replace_copy algorithm  
   // to insert into output stream and replace spaces  
   // with hyphen-separators  
   replace_copy ( charReadIn , istreambuf_iterator<char>( ),  
      charOut , ' ' , '-' );  
}  
```  
  
  **`Oh what a world!` `Oh what a world!`(Try the example: 'Oh what a world!'**  
 **then an Enter key to insert into the output,**  
 **& use a ctrl-Z Enter key combination to exit): Oh what a world!**  
**Oh-what-a-world!**  
**^Z**   
## Requirements  
 **Header:** <iterator\>  
  
 **Namespace:** std  
  
## See Also  
 [istreambuf_iterator Class](../vs140/istreambuf_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)