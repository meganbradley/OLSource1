---
title: "basic_string::rbegin"
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
  - "std.basic_string.rbegin"
  - "rbegin"
  - "basic_string.rbegin"
  - "std::basic_string::rbegin"
  - "xstring/std::basic_string::rbegin"
  - "basic_string::rbegin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rbegin method"
ms.assetid: 76896399-50ec-41e9-a2c0-3f1aff3b2a4f
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::rbegin
Returns an iterator to the first element in a reversed string.  
  
## Syntax  
  
```  
const_reverse_iterator rbegin( ) const;  
reverse_iterator rbegin( );  
```  
  
## Return Value  
 Returns a random-access iterator to the first element in a reversed string, addressing what would be the last element in the corresponding unreversed string.  
  
## Remarks  
 `rbegin` is used with a reversed string just as [begin](../vs140/basic_string--begin.md) is used with a string.  
  
 If the return value of `rbegin` is assigned to a `const_reverse_iterator`, the string object cannot be modified. If the return value of `rbegin` is assigned to a `reverse_iterator`, the string object can be modified.  
  
 `rbegin` can be used to initialize an iteration through a string backwards.  
  
## Example  
  
```  
// basic_string_rbegin.cpp  
// compile with: /EHsc  
#include <string>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   string str1 ( "Able was I ere I saw Elba" ), str2;  
   basic_string <char>::reverse_iterator str_rIter, str1_rIter, str2_rIter;  
   basic_string <char>::const_reverse_iterator str1_rcIter;  
  
   str1_rIter = str1.rbegin ( );  
   // str1_rIter--;  
   cout << "The first character-letter of the reversed string str1 is: "  
        << *str1_rIter << endl;  
   cout << "The full reversed string str1 is:\n ";  
   for ( str_rIter = str1.rbegin( ); str_rIter != str1.rend( ); str_rIter++ )  
      cout << *str_rIter;  
   cout << endl;  
  
   // The dereferenced iterator can be used to modify a character  
    *str1_rIter = 'A';  
   cout << "The first character-letter of the modified str1 is now: "  
        << *str1_rIter << endl;  
   cout << "The full modified reversed string str1 is now:\n ";  
   for ( str_rIter = str1.rbegin( ); str_rIter != str1.rend( ); str_rIter++ )  
      cout << *str_rIter;  
   cout << endl;  
  
   // The following line would be an error because iterator is const  
   // *str1_rcIter = 'A';  
  
   // For an empty string, begin is equivalent to end  
   if ( str2.rbegin( ) == str2.rend ( ) )  
      cout << "The string str2 is empty." << endl;  
   else  
      cout << "The stringstr2  is not empty." << endl;  
}  
```  
  
 **The first character-letter of the reversed string str1 is: a**  
**The full reversed string str1 is:**  
 **ablE was I ere I saw elbA**  
**The first character-letter of the modified str1 is now: A**  
**The full modified reversed string str1 is now:**  
 **AblE was I ere I saw elbA**  
**The string str2 is empty.**   
## Requirements  
 **Header:** <string\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)