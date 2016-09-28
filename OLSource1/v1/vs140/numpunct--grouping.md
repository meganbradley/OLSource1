---
title: "numpunct::grouping"
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
  - "numpunct.grouping"
  - "grouping"
  - "std::numpunct::grouping"
  - "numpunct::grouping"
  - "xlocnum/std::numpunct::grouping"
  - "std.numpunct.grouping"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "grouping method"
ms.assetid: 271b17ec-9e2b-4d6a-aa87-4e25e537d864
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# numpunct::grouping
Returns a locale-specific rule for determining how digits are grouped to the left of any decimal point.  
  
## Syntax  
  
```  
string grouping( ) const;  
```  
  
## Return Value  
 A locale-specific rule for determining how digits are grouped to the left of any decimal point.  
  
## Remarks  
 The member function returns [do_grouping](../vs140/numpunct--do_grouping.md).  
  
## Example  
  
```  
// numpunct_grouping.cpp  
// compile with: /EHsc  
#include <locale>  
#include <iostream>  
#include <sstream>  
using namespace std;  
int main( )  
{  
   locale loc( "german_germany");  
  
   const numpunct <char> &npunct =   
       use_facet < numpunct <char> >( loc );  
   for (unsigned int i = 0; i < npunct.grouping( ).length( ); i++)  
   {  
      cout << loc.name( ) << " international grouping:\n the "  
           << i <<"th group to the left of the radix character "  
           << "is of size " << (int)(npunct.grouping ( )[i])   
           << endl;  
   }  
}  
```  
  
 **German_Germany.1252 international grouping:**  
 **the 0th group to the left of the radix character is of size 3**   
## Requirements  
 **Header:** <locale\>  
  
 **Namespace:** std  
  
## See Also  
 [numpunct Class](../vs140/numpunct-class.md)