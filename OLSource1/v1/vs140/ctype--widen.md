---
title: "ctype::widen"
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
  - "widen"
  - "std::ctype::widen"
  - "ctype::widen"
  - "xlocale/std::ctype::widen"
  - "std.ctype.widen"
  - "ctype.widen"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "widen method"
ms.assetid: 02a9ded9-4af9-44aa-a35e-235f2a586fd4
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ctype::widen
Converts a character of type `char` in the native character set to the corresponding character of type `CharType` used by a locale.  
  
## Syntax  
  
```  
CharType widen(  
    char byte  
) const;  
const char *widen(  
    const char* first,   
    const char* last,   
    CharType* dest  
) const;  
```  
  
#### Parameters  
 `byte`  
 The character of type char in the native character set to be converted.  
  
 `first`  
 A pointer to the first character in the range of characters to be converted.  
  
 `last`  
 A pointer to the character immediately following the last character in the range of characters to be converted.  
  
 `dest`  
 A pointer to the first character of type `CharType` in the destination range that stores the converted range of characters.  
  
## Return Value  
 The first member function returns the character of type `CharType` that corresponds to the parameter character of native type `char`.  
  
 The second member function returns a pointer to the destination range of characters of type `CharType` used by a locale converted from native characters of type `char`.  
  
## Remarks  
 The first member function returns [do_widen](../vs140/ctype--do_widen.md)(`byte`). The second member function returns [do_widen](../vs140/ctype--do_widen.md)(`first`, `last`, `dest`).  
  
## Example  
  
```  
// ctype_widen.cpp  
// compile with: /EHsc /W3  
#include <locale>  
#include <iostream>  
using namespace std;  
  
int main( )  
{  
   locale loc1 ( "English" );  
   char *str1 = "Hello everyone!";  
   wchar_t str2 [16];  
   bool result1 = (use_facet<ctype<wchar_t> > ( loc1 ).widen  
      ( str1, str1 + strlen(str1), &str2[0] ) != 0);  // C4996  
   str2[strlen(str1)] = '\0';  
   cout << str1 << endl;  
   wcout << &str2[0] << endl;  
  
   ctype<wchar_t>::char_type charT;  
   charT = use_facet<ctype<char> > ( loc1 ).widen( 'a' );  
}  
```  
  
 **Hello everyone!**  
**Hello everyone!**   
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [ctype Class](../vs140/ctype-class.md)