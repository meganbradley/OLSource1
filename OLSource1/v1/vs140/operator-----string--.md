---
title: "operator&gt;&gt; (&lt;string&gt;)"
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
  - "std::operator>>"
  - "std::>>"
  - "std.>>"
  - "string/std::operator>>"
  - ">>"
  - "std.operator>>"
  - "operator>>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - ">> operator, strings"
  - "operator>>"
  - "operator >>, strings"
  - "operator>>, strings"
ms.assetid: 68aefbcf-65c1-4800-bbf7-ba47314e58a4
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator&gt;&gt; (&lt;string&gt;)
A template function that reads a string from an input stream.  
  
## Syntax  
  
```  
template<class CharType, class Traits, class Allocator>  
   basic_istream<CharType, Traits>& operator>>(  
      basic_istream<CharType, Traits>& _Istr,  
      basic_string<CharType, Traits, Allocator>& _Right  
   );  
```  
  
#### Parameters  
 `_Istr`  
 The input stream used to extract the sequence  
  
 `_Right`  
 The string that is being extracted from the input stream.  
  
## Return Value  
 Reads the value of the specified string from `_Istr` and returns it into `_Right.`  
  
## Remarks  
 The operator skips the leading white spaces unless the `skipws` flag is set. It reads all the following characters until the next character is a white space or the end of the file is reached.  
  
 The template function overloads **operator>>** to replace the sequence controlled by `_Right` with a sequence of elements extracted from the stream `_Istr`. Extraction stops:  
  
-   At end of file.  
  
-   After the function extracts `_Istr`.**width** elements, if that value is nonzero.  
  
 After the function extracts `_Istr`.[max_size](../vs140/basic_string--max_size.md) elements.  
  
-   After the function extracts an element *ch* for which [use_facet](../vs140/basic_filebuf--open.md)<**ctype**<**CharType**> >( `getloc`). **is**( **ctype**<**CharType**>::**space**, *ch*) is true, in which case the character is put back.  
  
 If the function extracts no elements, it calls [setstate](../vs140/basic_ios--setstate.md)(`ios_base::failbit`). In any case, it calls **istr**.**width**(0) and returns ***this**.  
  
## Example  
  
```  
// string_op_read_.cpp  
// compile with: /EHsc  
#include <string>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
  
   string c0;  
   cout << "Input a string c0 ( try: Fibonacci numbers ): ";  
   cin >> c0;  
   cout << "The string entered is c0 = " << c0 << endl;  
}  
```  
  
## Input  
  
```  
Fibonacci numbers  
```  
  
## Sample Output  
  
```  
Input a string c0 ( try: Fibonacci numbers ): Fibonacci numbers  
The string entered is c0 = Fibonacci  
```  
  
## Requirements  
 **Header:** <string\>  
  
 **Namespace:** std  
  
## See Also  
 [string::operator>>](../vs140/string--operator--.md)