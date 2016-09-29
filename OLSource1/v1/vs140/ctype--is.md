---
title: "ctype::is"
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
  - "ctype::is"
  - "ctype.is"
  - "std::ctype::is"
  - "is"
  - "xlocale/std::ctype::is"
  - "std.ctype.is"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "is method"
ms.assetid: 4aaf34d9-55b5-4fe2-b6d1-116dc1753e63
caps.latest.revision: 22
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# ctype::is
Tests whether a single character has a particular attribute or classifies the attributes of each character in a range and stores them in an array.  
  
## Syntax  
  
```  
bool is(  
    mask maskVal,   
    CharType ch  
) const;  
const CharType *is(  
    const CharType* first,   
    const CharType* last,  
    mask* dest  
) const;  
```  
  
#### Parameters  
 `maskVal`  
 The mask value for which the character is to be tested.  
  
 `ch`  
 The character whose attributes are to be tested.  
  
 `first`  
 A pointer to the first character in the range whose attributes are to be classified.  
  
 `last`  
 A pointer to the character immediately following the last character in the range whose attributes are to be classified.  
  
 `dest`  
 A pointer to the beginning of the array where the mask values characterizing the attributes of each of the characters are to be stored.  
  
## Return Value  
 The first member function returns `true` if the character tested has the attribute described by the mask value; `false` if it fails to have the attribute.  
  
 The second member function returns a pointer to the last character in the range whose attributes are to be classified.  
  
## Remarks  
 The mask values classifying the attributes of the characters are provided by the class [ctype_base Class](../vs140/ctype_base-class.md), from which ctype derives. The first member function can accept expressions for its first parameter referred to as bitmasks and formed from the combination of mask values by the logical bitwise operators (&#124; , & , ^ , ~).  
  
## Example  
  
```  
// ctype_is.cpp  
// compile with: /EHsc  
#include <locale>  
#include <iostream>  
using namespace std;  
  
int main() {  
   locale loc1 ( "German_Germany" ), loc2 ( "English_Australia" );  
  
   if (use_facet<ctype<char> > ( loc1 ).is( ctype_base::alpha, 'a' ))  
      cout << "The character 'a' in locale loc1 is alphabetic."   
           << endl;  
   else  
      cout << "The character 'a' in locale loc1 is not alphabetic."   
           << endl;  
  
   if (use_facet<ctype<char> > ( loc2 ).is( ctype_base::alpha, '!' ))  
      cout << "The character '!' in locale loc2 is alphabetic."   
           << endl;  
   else  
      cout << "The character '!' in locale loc2 is not alphabetic."   
           << endl;  
  
   char *string = "Hello, my name is John!";  
   ctype<char>::mask maskarray[30];  
   use_facet<ctype<char> > ( loc2 ).is(  
      string, string + strlen(string), maskarray );  
   for (unsigned int i = 0; i < strlen(string); i++) {  
      cout << string[i] << ": "  
           << (maskarray[i] & ctype_base::alpha ? "alpha"  
                                                : "not alpha")  
           << endl;;  
   };  
}  
```  
  
## Output  
  
```  
The character 'a' in locale loc1 is alphabetic.  
The character '!' in locale loc2 is not alphabetic.  
H: alpha  
e: alpha  
l: alpha  
l: alpha  
o: alpha  
,: not alpha  
 : not alpha  
m: alpha  
y: alpha  
 : not alpha  
n: alpha  
a: alpha  
m: alpha  
e: alpha  
 : not alpha  
i: alpha  
s: alpha  
 : not alpha  
J: alpha  
o: alpha  
h: alpha  
n: alpha  
!: not alpha  
```  
  
## Requirements  
 **Header:** <locale\>  
  
 **Namespace:** std  
  
## See Also  
 [ctype Class](../vs140/ctype-class.md)