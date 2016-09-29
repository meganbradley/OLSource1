---
title: "ostreambuf_iterator::ostreambuf_iterator"
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
  - "std.ostreambuf_iterator.ostreambuf_iterator"
  - "ostreambuf_iterator::ostreambuf_iterator"
  - "std::ostreambuf_iterator::ostreambuf_iterator"
  - "streambuf/std::ostreambuf_iterator::ostreambuf_iterator"
  - "ostreambuf_iterator.ostreambuf_iterator"
  - "ostreambuf_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ostreambuf_iterator method"
  - "ostreambuf_iterator class, constructor"
ms.assetid: 2d66302f-0ee4-4e52-9817-731e6f410845
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ostreambuf_iterator::ostreambuf_iterator
Constructs an `ostreambuf_iterator` that is initialized to write characters to the output stream.  
  
## Syntax  
  
```  
  
      ostreambuf_iterator(  
   streambuf_type* _Strbuf  
) throw( );  
ostreambuf_iterator(  
   ostream_type& _Ostr  
) throw( );  
```  
  
#### Parameters  
 `_Strbuf`  
 The output streambuf object used to initialize the output stream-buffer pointer.  
  
 `_Ostr`  
 The output stream object used to initialize the output stream-buffer pointer.  
  
## Remarks  
 The first constructor initializes the output stream-buffer pointer with `_Strbuf`.  
  
 The second constructor initializes the output stream-buffer pointer with `_Ostr`.`rdbuf`. The stored pointer must not be a null pointer.  
  
## Example  
  
```  
// ostreambuf_iterator_ostreambuf_iterator.cpp  
// compile with: /EHsc  
#include <iterator>  
#include <vector>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
  
   // ostreambuf_iterator for stream cout  
   ostreambuf_iterator<char> charOut ( cout );  
  
   *charOut = 'O';  
   charOut ++;  
   *charOut  = 'U';  
   charOut ++;     
   *charOut = 'T';  
   cout << " are characters output individually." << endl;  
  
   ostreambuf_iterator<char> strOut ( cout );  
   string str = "These characters are being written to the output stream.\n ";  
   copy ( str.begin ( ), str. end ( ), strOut );  
}  
```  
  
 **OUT are characters output individually.**  
**These characters are being written to the output stream.**   
## Requirements  
 **Header:** <iterator\>  
  
 **Namespace:** std  
  
## See Also  
 [ostreambuf_iterator Class](../vs140/ostreambuf_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)