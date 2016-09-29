---
title: "ctype::toupper"
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
  - "std.ctype.toupper"
  - "xlocale/std::ctype::toupper"
  - "std::ctype::toupper"
  - "ctype::toupper"
  - "ctype.toupper"
  - "toupper"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "toupper method"
ms.assetid: 4f7668d5-0e58-4db4-8f73-05fecb67d140
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ctype::toupper
Converts a character or a range of characters to upper case.  
  
## Syntax  
  
```  
CharType toupper(  
    CharType ch  
) const;  
const CharType *toupper(  
    CharType* first,   
    const CharType* last  
) const;  
```  
  
#### Parameters  
 `ch`  
 The character to be converted to uppercase.  
  
 `first`  
 A pointer to the first character in the range of characters whose cases are to be converted.  
  
 `last`  
 A pointer to the character immediately following the last character in the range of characters whose cases are to be converted.  
  
## Return Value  
 The first member function returns the uppercase form of the parameter `ch`. If no uppercase form exists, it returns `ch`.  
  
 The second member function returns `last`.  
  
## Remarks  
 The first member function returns [do_toupper](../vs140/ctype--do_toupper.md)(`ch`). The second member function returns [do_toupper](../vs140/ctype--do_toupper.md)(`first`, `last`).  
  
## Example  
  
```  
// ctype_toupper.cpp  
// compile with: /EHsc  
#include <locale>  
#include <iostream>  
using namespace std;  
  
int main( )     
{  
   locale loc1 ( "German_Germany" );  
  
   char string[] = "Hello, my name is John";  
  
   use_facet<ctype<char> > ( loc1 ).toupper  
      ( string, string + strlen(string) );  
   cout << "The uppercase string is: " << string << endl;  
}  
```  
  
 **The uppercase string is: HELLO, MY NAME IS JOHN**   
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [ctype Class](../vs140/ctype-class.md)