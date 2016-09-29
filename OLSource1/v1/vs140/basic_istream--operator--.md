---
title: "basic_istream::operator&gt;&gt;"
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
  - "std.basic_istream.operator>>"
  - "basic_istream.operator>>"
  - "basic_istream::operator>>"
  - "istream/std::basic_istream::operator>>"
  - ">>"
  - "std::basic_istream::operator>>"
  - "operator>>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator>>"
  - "operator>>, streams"
  - "operator >>"
  - ">> operator, stream"
  - "operator >>, streams"
ms.assetid: 1b995193-33a7-40fd-baa9-26f80a40f81b
caps.latest.revision: 23
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_istream::operator&gt;&gt;
Calls a function on the input stream or reads formatted data from the input stream.  
  
## Syntax  
  
```  
basic_istream& operator>>(  
   basic_istream& (*_Pfn)(basic_istream&)  
);  
basic_istream& operator>>(  
   ios_base& (*_Pfn)(ios_base&)  
);  
basic_istream& operator>>(  
   basic_ios<Elem, Tr>& (*_Pfn)(basic_ios<Elem, Tr>&))  
;  
basic_istream& operator>>(  
   basic_streambuf<Elem, Tr> *_Strbuf  
);  
basic_istream& operator>>(  
   bool& _Val  
);  
basic_istream& operator>>(  
   short& _Val  
);  
basic_istream& operator>>(  
   unsigned short& _Val  
);  
basic_istream& operator>>(  
   int& _Val  
);  
basic_istream& operator>>(  
   unsigned int& _Val  
);  
basic_istream& operator>>(  
   long& _Val  
);  
basic_istream& operator>>(  
   unsigned long& _Val  
);  
basic_istream& operator>>(  
   long long& _Val  
);  
basic_istream& operator>>(  
   unsigned long long& _Val  
);  
basic_istream& operator>>(  
   void *& _Val  
);  
basic_istream& operator>>(  
   float& _Val  
);  
basic_istream& operator>>(  
   double& _Val  
);  
basic_istream& operator>>(  
   long double& _Val  
);  
```  
  
#### Parameters  
 `_Pfn`  
 A function pointer.  
  
 `_Strbuf`  
 An object of type **stream_buf**.  
  
 `_Val`  
 The value to read from the stream.  
  
## Return Value  
 The stream (**\*this**).  
  
## Remarks  
 The `<istream>` header also defines several global extraction operators. For more information, see [operator>> (<istream\>)](../vs140/operator-----istream--.md).  
  
 The first member function ensures that an expression of the form **istr** >> `ws` calls [ws](../vs140/ws.md)(**istr**), and then returns **\*this**. The second and third functions ensure that other manipulators, such as [hex](../vs140/hex.md), behave similarly. The remaining functions constitute the formatted input functions.  
  
 The function:  
  
```  
basic_istream& operator>>(  
    basic_streambuf<Elem, Tr> *_Strbuf);  
```  
  
 extracts elements, if _*Strbuf* is not a null pointer, and inserts them in `_Strbuf`. Extraction stops on end of file. It also stops without extracting the element in question, if an insertion fails or throws an exception (which is caught but not rethrown). If the function extracts no elements, it calls [setstate](../vs140/basic_ios--setstate.md)(**failbit**). In any case, the function returns **\*this**.  
  
 The function:  
  
```  
basic_istream& operator>>(bool& _Val);  
```  
  
 extracts a field and converts it to a Boolean value by calling [use_facet](../vs140/basic_filebuf--open.md) <`num_get`<**Elem**, **InIt**>([getloc](../vs140/ios_base--getloc.md)). [get](../vs140/ios_base--getloc.md)(**InIt**( [rdbuf](../vs140/basic_ios--rdbuf.md)), `Init`(0), **\*this**, `getloc`, `_Val`). Here, **InIt** is defined as [istreambuf_iterator](../vs140/istreambuf_iterator-class.md)<**Elem**, **Tr**>. The function returns **\*this**.  
  
 The functions:  
  
```  
basic_istream& operator>>(short& _Val);  
basic_istream& operator>>(unsigned short& _Val);  
basic_istream& operator>>(int& _Val);  
basic_istream& operator>>(unsigned int& _Val);  
basic_istream& operator>>(long& _Val);  
basic_istream& operator>>(unsigned long& _Val);  
  
basic_istream& operator>>(long long& _Val);  
basic_istream& operator>>(unsigned long long& _Val);  
  
basic_istream& operator>>(void *& _Val);  
```  
  
 each extract a field and convert it to a numeric value by calling `use_facet`<`num_get`<**Elem**, **InIt**>(`getloc`). [get](../vs140/basic_istream--get.md)(**InIt**( `rdbuf`), `Init`(0), **\*this**, `getloc`, `_Val`). Here, **InIt** is defined as `istreambuf_iterator`<**Elem**, **Tr**>, and `_Val` has type **long***,* `unsigned long`*,* or **void \*** as needed.  
  
 If the converted value cannot be represented as the type of `_Val`, the function calls [setstate](../vs140/basic_ios--setstate.md)(**failbit**). In any case, the function returns **\*this**.  
  
 The functions:  
  
```  
basic_istream& operator>>(float& _Val);  
basic_istream& operator>>(double& _Val);  
basic_istream& operator>>(long double& _Val);  
```  
  
 each extract a field and convert it to a numeric value by calling `use_facet`<`num_get`<**Elem**, **InIt**>(`getloc`). **get**(**InIt**( `rdbuf`), `Init`(0), **\*this**, `getloc`, `_Val`). Here, **InIt** is defined as `istreambuf_iterator`<**Elem**, **Tr**>, and `_Val` has type **double** or `long double` as needed.  
  
 If the converted value cannot be represented as the type of `_Val`, the function calls `setstate`(**failbit**). In any case, it returns **\*this**.  
  
## Example  
  
```  
// istream_basic_istream_op_is.cpp  
// compile with: /EHsc  
#include <iostream>  
  
using namespace std;  
  
ios_base& hex2( ios_base& ib )   
{  
   ib.unsetf( ios_base::dec );  
   ib.setf( ios_base::hex );  
   return ib;  
}  
  
basic_istream<char, char_traits<char> >& somefunc(basic_istream<char, char_traits<char> > &i)  
{  
   if ( i == cin )   
   {  
      cerr << "i is cin" << endl;  
   }  
   return i;  
}  
  
int main( )   
{  
   int i = 0;  
   cin >> somefunc;  
   cin >> i;  
   cout << i << endl;  
   cin >> hex2;  
   cin >> i;  
   cout << i << endl;  
}  
```  
  
## Input  
  
```  
10  
10  
```  
  
## Sample Output  
  
```  
i is cin  
10  
10  
10  
16  
```  
  
## Requirements  
 **Header:** <istream\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_istream Class](../vs140/basic_istream-class.md)   
 [operator>> (<istream\>)](../vs140/operator-----istream--.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)