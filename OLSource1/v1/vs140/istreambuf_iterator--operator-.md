---
title: "istreambuf_iterator::operator*"
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
  - std.istreambuf_iterator.operator*
  - istreambuf_iterator.operator*
  - std::istreambuf_iterator::operator*
  - operator*
  - istreambuf_iterator::operator*
  - streambuf/std::istreambuf_iterator::operator*
dev_langs: 
  - C++
helpviewer_keywords: 
  - * operator
  - operator*
  - * operator, with specific iterator expressions
  - multiplication operator, iterator expressions
ms.assetid: 2ba63aed-b733-4bb4-9281-c4a7b7761cc4
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# istreambuf_iterator::operator*
The dereferencing operator returns the next character in the stream.  
  
## Syntax  
  
```  
CharType operator*( ) const;  
```  
  
## Return Value  
 The next character in the stream.  
  
## Example  
  
```  
// istreambuf_iterator_operator_deref.cpp  
// compile with: /EHsc  
#include <iterator>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
  
   cout << "Type string of characters & enter to output it,\n"  
      << " with stream buffer iterators,(try: 'I'll be back.')\n"  
      << " repeat as many times as desired,\n"   
      << " then keystroke ctrl-Z Enter to exit program: ";  
   istreambuf_iterator<char> inpos ( cin );  
   istreambuf_iterator<char> endpos;  
   ostreambuf_iterator<char> outpos ( cout );  
   while ( inpos != endpos )  
   {  
      *outpos = *inpos;   //Put value of outpos equal to inpos  
      ++inpos;  
      ++outpos;  
   }  
}  
```  
  
  **`I'll be back.` `I'll be back.`Type string of characters & enter to output it,**  
 **with stream buffer iterators,(try: 'I'll be back.')**  
 **repeat as many times as desired,**  
 **then keystroke ctrl-Z Enter to exit program: I'll be back.**  
**I'll be back.**  
**^Z**   
## Requirements  
 **Header:** <iterator\>  
  
 **Namespace:** std  
  
## See Also  
 [istreambuf_iterator Class](../vs140/istreambuf_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)