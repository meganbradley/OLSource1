---
title: "ctype::narrow"
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
  - "xlocale/std::ctype::narrow"
  - "ctype.narrow"
  - "narrow"
  - "ctype::narrow"
  - "Narrow"
  - "std.ctype.narrow"
  - "std::ctype::narrow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "narrow method"
ms.assetid: 2d2f6865-babb-400e-9d65-eb651c31feda
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ctype::narrow
Converts characters of type `CharType` used by a locale to the corresponding characters of type `char` in the native character set.  
  
## Syntax  
  
```  
char narrow(  
    CharType ch,   
    char default = '\0'  
) const;  
const CharType* narrow(  
    const CharType* first,   
    const CharType* last,  
    char default,   
    char* dest  
) const;  
```  
  
#### Parameters  
 `ch`  
 The character of type `Chartype` used by the locale to be converted.  
  
 `default`  
 The default value to be assigned by the member function to characters of type `CharType` that do not have counterpart characters of type `char`.  
  
 `first`  
 A pointer to the first character in the range of characters to be converted.  
  
 `last`  
 A pointer to the character immediately following the last character in the range of characters to be converted.  
  
 `dest`  
 A const pointer to the first character of type `char` in the destination range that stores the converted range of characters.  
  
## Return Value  
 The first member function returns the native character of type `char` that corresponds to the parameter character of type `CharType` `default` if not counterpart is defined.  
  
 The second member function returns a pointer to the destination range of native characters converted from characters of type `CharType`.  
  
## Remarks  
 The first member function returns [do_narrow](../vs140/ctype--do_narrow.md)(`ch`, `default`). The second member function returns [do_narrow](../vs140/ctype--do_narrow.md) (`first`, `last`, `default`, `dest`). Only the basic source characters are guaranteed to have a unique inverse image `CharType` under `narrow`. For these basic source characters, the following invariant holds: `narrow` ( [widen](../vs140/ctype--widen.md) ( **c** ), 0 ) == **c**.  
  
## Example  
  
```  
// ctype_narrow.cpp  
// compile with: /EHsc /W3  
#include <locale>  
#include <iostream>  
using namespace std;  
  
int main( )  
{  
   locale loc1 ( "english" );  
   wchar_t *str1 = L"\x0392fhello everyone";  
   char str2 [16];  
   bool result1 = (use_facet<ctype<wchar_t> > ( loc1 ).narrow  
      ( str1, str1 + wcslen(str1), 'X', &str2[0] ) != 0);  // C4996  
   str2[wcslen(str1)] = '\0';  
   wcout << str1 << endl;  
   cout << &str2[0] << endl;  
}  
```  
  
 **Xhello everyone**   
## Requirements  
 **Header:** <locale\>  
  
 **Namespace:** std  
  
## See Also  
 [ctype Class](../vs140/ctype-class.md)