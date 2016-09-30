---
title: "basic_string::operator="
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
  - "="
  - "operator="
  - "basic_string::operator="
  - "std.basic_string.operator="
  - "std::basic_string::operator="
  - "xstring/std::basic_string::operator="
  - "basic_string.operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator =, strings"
  - "operator=, strings"
  - "= operator, with specific standard C++ library objects"
ms.assetid: d33ec313-af68-4bd8-8f34-2cf974a6964d
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::operator=
Assigns new character values to the contents of a string.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The character value to be assigned.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to the characters of the C-string to be assigned to the target string.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The source string whose characters are to be assigned to the target string.  
  
## Return Value  
 A reference to the string object that is being assigned new characters by the member function.  
  
## Remarks  
 The strings may be assigned new character values. The new value may be either a string and C-string or a single character. The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> may be used if the new value can be described by a single parameter, otherwise the member function [assign](../vs140/basic_string--assign.md), which has multiple parameters, may be used to specify which part of the string is to be assigned to a target string.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The string str1 assigned with the zero character is: 0**  
**The C-string cstr1b is: Out There.**  
**Assigning the C-string cstr1a to string str1 gives: Out There.**  
**The original string str1 is: Hello.**  
**The string str2c is: Wide.**  
**The string str1 newly assigned with string str2c is: Wide.**  
**The string str3c is: World.**  
**The string str1 reassigned with string str3c is: World.**   
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)