---
title: "basic_ostream::operator&lt;&lt;"
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
  - "ostream/std::basic_ostream::operator<<"
  - "basic_ostream.operator<<"
  - "std::basic_ostream::operator<<"
  - "std.basic_ostream.operator<<"
  - "<<"
  - "basic_ostream::operator<<"
  - "operator<<"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator <<"
  - "<< operator"
  - "<< operator, with specific objects"
  - "operator<<, streams"
  - "operator<<"
  - "operator <<, streams"
ms.assetid: 74ebcbcf-2e63-480b-89a1-5cf41e316ce8
caps.latest.revision: 27
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_ostream::operator&lt;&lt;
Writes to the stream.  
  
## Syntax  
  
```  
basic_ostream<_Elem, _Tr>& operator<<(  
    basic_ostream<_Elem, _Tr>& (*_Pfn)(basic_ostream<_Elem, _Tr>&)  
);  
basic_ostream<_Elem, _Tr>& operator<<(  
    ios_base& (*_Pfn)(ios_base&)  
);  
basic_ostream<_Elem, _Tr>& operator<<(  
    basic_ios<_Elem, _Tr>& (*_Pfn)(basic_ios<_Elem, _Tr>&)  
);  
basic_ostream<_Elem, _Tr>& operator<<(  
    basic_streambuf<_Elem, _Tr> *_Strbuf  
);  
basic_ostream<_Elem, _Tr>& operator<<(  
    bool _Val  
);  
basic_ostream<_Elem, _Tr>& operator<<(  
    short _Val  
);  
basic_ostream<_Elem, _Tr>& operator<<(  
    unsigned short _Val  
);  
basic_ostream<_Elem, _Tr>& operator<<(  
    int __w64 _Val  
);  
basic_ostream<_Elem, _Tr>& operator<<(  
    unsigned int __w64 _Val  
);  
basic_ostream<_Elem, _Tr>& operator<<(  
    long _Val  
);  
basic_ostream<_Elem, _Tr>& operator<<(  
    unsigned long __w64 _Val  
);  
basic_ostream<_Elem, _Tr>& operator<<(  
     long long _Val  
);  
basic_ostream<_Elem, _Tr>& operator<<(  
     unsigned long long _Val  
);  
basic_ostream<_Elem, _Tr>& operator<<(  
    float _Val  
);  
basic_ostream<_Elem, _Tr>& operator<<(  
    double _Val  
);  
basic_ostream<_Elem, _Tr>& operator<<(  
    long double _Val  
);  
basic_ostream<_Elem, _Tr>& operator<<(  
    const void *_Val  
);  
```  
  
#### Parameters  
 `_Pfn`  
 A function pointer.  
  
 `_Strbuf`  
 A pointer to a **stream_buf** object.  
  
 `_Val`  
 An element to write to the stream.  
  
## Return Value  
 A reference to the basic_ostream object.  
  
## Remarks  
 The `<ostream>` header also defines several global insertion operators. For more information, see [operator<< (<ostream\>)](../vs140/operator-----ostream--.md).  
  
 The first member function ensures that an expression of the form **ostr << endl** calls [endl](../vs140/endl.md)**(ostr)**, and then returns **\*this**. The second and third functions ensure that other manipulators, such as [hex](../vs140/hex.md), behave similarly. The remaining functions are all formatted output functions.  
  
 The function  
  
```  
basic_ostream<_Elem, _Tr>& operator<<(basic_streambuf<Elem, Tr> *_Strbuf);  
```  
  
 extracts elements from `_Strbuf`, if `_Strbuf` is not a null pointer, and inserts them. Extraction stops on end of file, or if an extraction throws an exception (which is rethrown). It also stops, without extracting the element in question, if an insertion fails. If the function inserts no elements, or if an extraction throws an exception, the function calls [setstate](../vs140/basic_ios--setstate.md)(**failbit**). In any case, the function returns **\*this**.  
  
 The function  
  
```  
basic_ostream<_Elem, _Tr>& operator<<(bool _Val);  
```  
  
 converts _`Val` to a Boolean field and inserts it by calling [use_facet](../vs140/basic_filebuf--open.md)**<num_put<Elem, OutIt>**`(`[getloc](../vs140/ios_base--getloc.md)). [put](../vs140/basic_ostream--put.md)(**OutIt**([rdbuf](../vs140/basic_ios--rdbuf.md)), **\*this**, `getloc`, **val**). Here, **OutIt** is defined as [ostreambuf_iterator](../vs140/ostreambuf_iterator-class.md)**<Elem, Tr>**. The function returns **\*this**.  
  
 The functions  
  
```  
basic_ostream<_Elem, _Tr>& operator<<(short _Val);  
basic_ostream<_Elem, _Tr>& operator<<(unsigned short _Val);  
basic_ostream<_Elem, _Tr>& operator<<(int _Val);  
basic_ostream<_Elem, _Tr>& operator<<(unsigned int __w64 _Val);  
basic_ostream<_Elem, _Tr>& operator<<(long _Val);  
basic_ostream<_Elem, _Tr>& operator<<(unsigned long _Val);  
basic_ostream<_Elem, _Tr>& operator<<(long long _Val);  
basic_ostream<_Elem, _Tr>& operator<<(unsigned long long _Val);  
basic_ostream<_Elem, _Tr>& operator<<(const void *_Val);  
```  
  
 each convert `_Val` to a numeric field and insert it by calling **use_facet<num_put<Elem, OutIt>**(`getloc`). **put**(**OutIt**(`rdbuf`), **\*this**, `getloc`, **val**). Here, **OutIt** is defined as **ostreambuf_iterator<Elem, Tr>**. The function returns **\*this**.  
  
 The functions  
  
```  
basic_ostream<_Elem, _Tr>& operator<<(float _Val);  
basic_ostream<_Elem, _Tr>& operator<<(double _Val);  
basic_ostream<_Elem, _Tr>& operator<<(long double _Val);  
```  
  
 each convert _`Val` to a numeric field and insert it by calling **use_facet<num_put<Elem, OutIt>**(`getloc`)**. put**(**OutIt**(`rdbuf`), **\*this**, `getloc`, **val**). Here, **OutIt** is defined as **ostreambuf_iterator<Elem, Tr>**. The function returns **\*this**.  
  
## Example  
  
```  
// basic_ostream_op_write.cpp  
// compile with: /EHsc  
#include <iostream>  
#include <string.h>  
  
using namespace std;  
  
ios_base& hex2( ios_base& ib )  
{  
   ib.unsetf( ios_base::dec );  
   ib.setf( ios_base::hex );  
   return ib;  
}  
  
basic_ostream<char, char_traits<char> >& somefunc(basic_ostream<char, char_traits<char> > &i)  
{  
   if ( i == cout )  
   {  
      i << "i is cout" << endl;  
   }  
   return i;  
}  
  
class CTxtStreambuf : public basic_streambuf< char, char_traits< char > >  
{  
public:  
   CTxtStreambuf(char *_pszText)  
   {  
      pszText = _pszText;  
      setg(pszText, pszText, pszText+strlen(pszText));  
   };  
          char *pszText;  
};  
  
int main( )  
{  
   cout << somefunc;  
   cout << 21 << endl;  
  
   hex2(cout);  
   cout << 21 << endl;  
  
   CTxtStreambuf f("text in streambuf");  
   cout << &f << endl;  
}  
```  
  
## Output  
  
```  
i is cout  
21  
15  
text in streambuf  
```  
  
## Requirements  
 **Header:** <ostream\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_ostream Class](../vs140/basic_ostream-class.md)   
 [operator<< (<ostream\>)](../vs140/operator-----ostream--.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)