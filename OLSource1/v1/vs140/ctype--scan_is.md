---
title: "ctype::scan_is"
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
  - "ctype.scan_is"
  - "ctype::scan_is"
  - "xlocale/std::ctype::scan_is"
  - "std::ctype::scan_is"
  - "scan_is"
  - "std.ctype.scan_is"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "scan_is method"
ms.assetid: f0b84f19-d3d6-47c9-a097-98165e68af79
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ctype::scan_is
Locates the first character in a range that matches a specified mask.  
  
## Syntax  
  
```  
const CharType *scan_is(  
    mask maskVal,   
    const CharType* first,   
    const CharType* last,  
) const;  
```  
  
#### Parameters  
 `maskVal`  
 The mask value to be matched by a character.  
  
 `first`  
 A pointer to the first character in the range to be scanned.  
  
 `last`  
 A pointer to the character immediately following the last character in the range to be scanned.  
  
## Return Value  
 A pointer to the first character in a range that does match a specified mask. If no such value exists, the function returns `last.`  
  
## Remarks  
 The member function returns [do_scan_is](../vs140/ctype--do_scan_is.md)(`maskVal`, `first`, `last`).  
  
## Example  
  
```  
// ctype_scan_is.cpp  
// compile with: /EHsc  
#include <locale>  
#include <iostream>  
using namespace std;  
  
int main( )     
{  
   locale loc1 ( "German_Germany" );  
  
   char *string = "Hello, my name is John!";  
  
   const char* i = use_facet<ctype<char> > ( loc1 ).scan_is  
      ( ctype_base::punct, string, string + strlen(string) );  
   cout << "The first punctuation is \"" << *i << "\" at position: "   
      << i - string << endl;  
}  
```  
  
 **The first punctuation is "," at position: 5**   
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [ctype Class](../vs140/ctype-class.md)