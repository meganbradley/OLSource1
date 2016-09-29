---
title: "basic_string::rend"
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
  - "rend"
  - "basic_string.rend"
  - "xstring/std::basic_string::rend"
  - "std::basic_string::rend"
  - "basic_string::rend"
  - "std.basic_string.rend"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rend method"
ms.assetid: e4bd8ef0-f755-4616-ab46-3c963cef9f65
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::rend
Returns an iterator that addresses the location succeeding the last element in a reversed string.  
  
## Syntax  
  
```  
const_reverse_iterator rend( ) const;  
reverse_iterator rend( );  
```  
  
## Return Value  
 A reverse random-access iterator that addresses the location succeeding the last element in a reversed string.  
  
## Remarks  
 `rend` is used with a reversed string just as [end](../vs140/basic_string--end.md) is used with a string.  
  
 If the return value of `rend` is assigned to a `const_reverse_iterator`, the string object cannot be modified. If the return value of `rend` is assigned to a `reverse_iterator`, the string object can be modified.  
  
 `rend` can be used to test whether a reverse iterator has reached the end of its string.  
  
 The value returned by `rend` should not be dereferenced.  
  
## Example  
  
```  
// basic_string_rend.cpp  
// compile with: /EHsc  
#include <string>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   string str1 ("Able was I ere I saw Elba"), str2;  
   basic_string <char>::reverse_iterator str_rIter, str1_rIter, str2_rIter;  
   basic_string <char>::const_reverse_iterator str1_rcIter;  
  
   str1_rIter = str1.rend ( );  
   str1_rIter--;  
   cout << "The last character-letter of the reversed string str1 is: "  
        << *str1_rIter << endl;  
   cout << "The full reversed string str1 is:\n ";  
   for ( str_rIter = str1.rbegin( ); str_rIter != str1.rend( ); str_rIter++ )  
      cout << *str_rIter;  
   cout << endl;  
  
   // The dereferenced iterator can be used to modify a character  
    *str1_rIter = 'o';  
   cout << "The last character-letter of the modified str1 is now: "  
        << *str1_rIter << endl;  
   cout << "The full modified reversed string str1 is now:\n ";  
   for ( str_rIter = str1.rbegin( ); str_rIter != str1.rend( ); str_rIter++ )  
      cout << *str_rIter;  
   cout << endl;  
  
   // The following line would be an error because iterator is const  
   // *str1_rcIter = 'T';  
  
   // For an empty string, end is equivalent to begin  
   if ( str2.rbegin( ) == str2.rend ( ) )  
      cout << "The string str2 is empty." << endl;  
   else  
      cout << "The stringstr2  is not empty." << endl;  
}  
```  
  
 **The last character-letter of the reversed string str1 is: A**  
**The full reversed string str1 is:**  
 **ablE was I ere I saw elbA**  
**The last character-letter of the modified str1 is now: o**  
**The full modified reversed string str1 is now:**  
 **ablE was I ere I saw elbo**  
**The string str2 is empty.**   
## Requirements  
 **Header:** <string\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)