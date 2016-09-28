---
title: "istreambuf_iterator::char_type"
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
  - "char_type"
  - "std.istreambuf_iterator.char_type"
  - "std::istreambuf_iterator::char_type"
  - "istreambuf_iterator::char_type"
  - "streambuf/std::istreambuf_iterator::char_type"
  - "istreambuf_iterator.char_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "char_type typedef"
ms.assetid: 18a30a39-f0e0-4b5d-aebd-f963537b1c65
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# istreambuf_iterator::char_type
A type that provides for the character type of the `ostreambuf_iterator`.  
  
## Syntax  
  
```  
  
typedef CharType char_type;  
  
```  
  
## Remarks  
 The type is a synonym for the template parameter **CharType**.  
  
## Example  
  
```  
// istreambuf_iterator_char_type.cpp  
// compile with: /EHsc  
#include <iterator>  
#include <vector>  
#include <iostream>  
#include <algorithm>  
  
int main( )  
{  
   using namespace std;  
  
   typedef istreambuf_iterator<char>::char_type CHT1;  
   typedef istreambuf_iterator<char>::traits_type CHTR1;  
  
   cout << "(Try the example: 'So many dots to be done'\n"  
        << " then an Enter key to insert into the output,\n"  
        << " & use a ctrl-Z Enter key combination to exit): ";  
  
   // istreambuf_iterator for input stream  
   istreambuf_iterator< CHT1, CHTR1> charInBuf ( cin );  
   ostreambuf_iterator<char> charOut ( cout );  
  
   // Used in conjunction with replace_copy algorithm  
   // to insert into output stream and replace spaces  
   // with dot-separators  
   replace_copy ( charInBuf , istreambuf_iterator<char>( ),  
        charOut , ' ' , '.' );  
}  
```  
  
  **`So many dots to be done` `So many dots to be done`(Try the example: 'So many dots to be done'**  
 **then an Enter key to insert into the output,**  
 **& use a ctrl-Z Enter key combination to exit): So many dots to be done**  
**So.many.dots.to.be.done**  
**^Z**   
## Requirements  
 **Header:** <iterator\>  
  
 **Namespace:** std  
  
## See Also  
 [istreambuf_iterator Class](../vs140/istreambuf_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)