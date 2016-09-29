---
title: "istreambuf_iterator::operator++"
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
  - "istreambuf_iterator::operator++"
  - "std::istreambuf_iterator::operator++"
  - "istreambuf_iterator.operator++"
  - "operator++"
  - "++"
  - "streambuf/std::istreambuf_iterator::operator++"
  - "std.istreambuf_iterator.operator++"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "++ operator"
  - "operator++"
  - "++ operator, with specific objects"
ms.assetid: 5c1e046e-e0fc-4328-bd29-7e01bdb5cb6c
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# istreambuf_iterator::operator++
Either returns the next character from the input stream or copies the object before incrementing it and returns the copy.  
  
## Syntax  
  
```  
istreambuf_iterator<CharType, Traits>& operator++( );  
istreambuf_iterator<CharType, Traits> operator++( int );  
```  
  
## Return Value  
 An `istreambuf_iterator` or a reference to an `istreambuf_iterator`.  
  
## Remarks  
 The first operator eventually attempts to extract and store an object of type **CharType** from the associated input stream. The second operator makes a copy of the object, increments the object, and then returns the copy.  
  
## Example  
  
```  
// istreambuf_iterator_operator_incr.cpp  
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
      *outpos = *inpos;  
      ++inpos;   //Increment istreambuf_iterator  
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