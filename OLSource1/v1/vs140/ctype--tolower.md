---
title: "ctype::tolower"
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
  - "tolower"
  - "ctype.tolower"
  - "std.ctype.tolower"
  - "std::ctype::tolower"
  - "xlocale/std::ctype::tolower"
  - "ctype::tolower"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "tolower method"
ms.assetid: 364c6bd3-b65a-45d0-9dcc-3fd05d08ed6f
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ctype::tolower
Converts a character or a range of characters to lower case.  
  
## Syntax  
  
```  
CharType tolower(  
    CharType ch  
) const;  
const CharType *tolower(  
    CharType* first,   
    const CharType* last,  
) const;  
```  
  
#### Parameters  
 `ch`  
 The character to be converted to lower case.  
  
 `first`  
 A pointer to the first character in the range of characters whose cases are to be converted.  
  
 `last`  
 A pointer to the character immediately following the last character in the range of characters whose cases are to be converted.  
  
## Return Value  
 The first member function returns the lowercase form of the parameter `ch`. If no lowercase form exists, it returns `ch`.  
  
 The second member function returns `last`.  
  
## Remarks  
 The first member function returns [do_tolower](../vs140/ctype--do_tolower.md)(`ch`). The second member function returns [do_tolower](../vs140/ctype--do_tolower.md)(`first`, `last`).  
  
## Example  
  
```  
// ctype_tolower.cpp  
// compile with: /EHsc  
#include <locale>  
#include <iostream>  
using namespace std;  
  
int main( )  
{  
   locale loc1 ( "German_Germany" );  
  
   char string[] = "HELLO, MY NAME IS JOHN";  
  
   use_facet<ctype<char> > ( loc1 ).tolower  
      ( string, string + strlen(string) );  
   cout << "The lowercase string is: " << string << endl;  
}  
```  
  
 **The lowercase string is: hello, my name is john**   
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [ctype Class](../vs140/ctype-class.md)