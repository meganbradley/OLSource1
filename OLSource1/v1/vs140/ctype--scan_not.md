---
title: "ctype::scan_not"
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
  - "scan_not"
  - "std.ctype.scan_not"
  - "ctype::scan_not"
  - "ctype.scan_not"
  - "xlocale/std::ctype::scan_not"
  - "std::ctype::scan_not"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "scan_not method"
ms.assetid: 262053b9-51f7-402d-b4b4-7be43100fd99
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ctype::scan_not
Locates the first character in a range that does not match a specified mask.  
  
## Syntax  
  
```  
const CharType *scan_not(  
    mask maskVal,   
    const CharType* first,   
    const CharType* last,  
) const;  
```  
  
#### Parameters  
 `maskVal`  
 The mask value not to be matched by a character.  
  
 `first`  
 A pointer to the first character in the range to be scanned.  
  
 `last`  
 A pointer to the character immediately following the last character in the range to be scanned.  
  
## Return Value  
 A pointer to the first character in a range that does not match a specified mask. If no such value exists, the function returns `last`.  
  
## Remarks  
 The member function returns [do_scan_not](../vs140/ctype--do_scan_not.md)(`maskVal`, `first`, `last`).  
  
## Example  
  
```  
// ctype_scan_not.cpp  
// compile with: /EHsc  
#include <locale>  
#include <iostream>  
using namespace std;  
  
int main( )     
{  
   locale loc1 ( "German_Germany" );  
  
   char *string = "Hello, my name is John!";  
  
   const char* i = use_facet<ctype<char> > ( loc1 ).scan_not  
      ( ctype_base::alpha, string, string + strlen(string) );  
   cout << "First nonalpha character is \"" << *i << "\" at position: "   
      << i - string << endl;  
}  
```  
  
 **First nonalpha character is "," at position: 5**   
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [ctype Class](../vs140/ctype-class.md)