---
title: "ostreambuf_iterator::failed"
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
  - "std::ostreambuf_iterator::failed"
  - "failed"
  - "ostreambuf_iterator::failed"
  - "ostreambuf_iterator.failed"
  - "streambuf/std::ostreambuf_iterator::failed"
  - "std.ostreambuf_iterator.failed"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "failed method"
ms.assetid: 3e316ed5-1a04-491a-8f08-ef67dc09dc50
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ostreambuf_iterator::failed
Tests for failure of an insertion into the output stream buffer.  
  
## Syntax  
  
```  
  
bool failed( ) const throw( );  
  
```  
  
## Return Value  
 **true** if no insertion into the output stream buffer has failed earlier; otherwise **false**.  
  
## Remarks  
 The member function returns **true** if, in any prior use of member `operator=`, the call to **subf**_->`sputc` returned **eof**.  
  
## Example  
  
```  
// ostreambuf_iterator_failed.cpp  
// compile with: /EHsc  
#include <iterator>  
#include <vector>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
  
   // ostreambuf_iterator for stream cout  
   ostreambuf_iterator<char> charOut ( cout );  
  
   *charOut = 'a';  
   charOut ++;  
   *charOut  = 'b';  
   charOut ++;     
   *charOut = 'c';  
   cout << " are characters output individually." << endl;  
  
   bool b1 = charOut.failed ( );  
   if (b1)   
       cout << "At least one insertion failed." << endl;  
   else  
       cout << "No insertions failed." << endl;  
}  
```  
  
 **abc are characters output individually.**  
**No insertions failed.**   
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
## See Also  
 [ostreambuf_iterator Class](../vs140/ostreambuf_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)