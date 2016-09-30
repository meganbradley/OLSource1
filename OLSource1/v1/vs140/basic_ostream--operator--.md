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
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_ostream::operator&lt;&lt;
Writes to the stream.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A function pointer.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 A pointer to a **stream_buf** object.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 An element to write to the stream.  
  
## Return Value  
 A reference to the basic_ostream object.  
  
## Remarks  
 The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> header also defines several global insertion operators. For more information, see [operator<< (\<ostream>)](../vs140/operator-----ostream--.md).  
  
 The first member function ensures that an expression of the form **ostr << endl** calls [endl](../vs140/endl.md)**(ostr)**, and then returns **\*this**. The second and third functions ensure that other manipulators, such as [hex](../vs140/hex.md), behave similarly. The remaining functions are all formatted output functions.  
  
 The function  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 extracts elements from <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, if <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is not a null pointer, and inserts them. Extraction stops on end of file, or if an extraction throws an exception (which is rethrown). It also stops, without extracting the element in question, if an insertion fails. If the function inserts no elements, or if an extraction throws an exception, the function calls [setstate](../vs140/basic_ios--setstate.md)(**failbit**). In any case, the function returns **\*this**.  
  
 The function  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 converts _<CodeContentPlaceHolder>13\</CodeContentPlaceHolder> to a Boolean field and inserts it by calling [use_facet](../vs140/basic_filebuf--open.md)**<num_put\<Elem, OutIt>**<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>[getloc](../vs140/ios_base--getloc.md)). [put](../vs140/basic_ostream--put.md)(**OutIt**([rdbuf](../vs140/basic_ios--rdbuf.md)), **\*this**, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, **val**). Here, **OutIt** is defined as [ostreambuf_iterator](../vs140/ostreambuf_iterator-class.md)**\<Elem, Tr>**. The function returns **\*this**.  
  
 The functions  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 each convert <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> to a numeric field and insert it by calling **use_facet<num_put\<Elem, OutIt>**(<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>). **put**(**OutIt**(<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>), **\*this**, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, **val**). Here, **OutIt** is defined as **ostreambuf_iterator\<Elem, Tr>**. The function returns **\*this**.  
  
 The functions  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 each convert _<CodeContentPlaceHolder>20\</CodeContentPlaceHolder> to a numeric field and insert it by calling **use_facet<num_put\<Elem, OutIt>**(<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>)**. put**(**OutIt**(<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>), **\*this**, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, **val**). Here, **OutIt** is defined as **ostreambuf_iterator\<Elem, Tr>**. The function returns **\*this**.  
  
## Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<ostream>  
  
 **Namespace:** std  
  
## See Also  
 [basic_ostream Class](../vs140/basic_ostream-class.md)   
 [operator<< (\<ostream>)](../vs140/operator-----ostream--.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)