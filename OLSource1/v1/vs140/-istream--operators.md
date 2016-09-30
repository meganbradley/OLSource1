---
title: "&lt;istream&gt; operators"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 7174da41-f301-4a34-b631-0ab918b188d2
caps.latest.revision: 14
---
# &lt;istream&gt; operators
||  
|-|  
|[operator&gt;&gt;](#operator_gt__gt_)|  
  
##  \<a name="operator_gt__gt_">\</a>  operator&gt;&gt;  
 Extracts characters and strings from the stream.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 A character.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 A stream.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 A string.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 A type.  
  
### Return Value  
 The stream  
  
### Remarks  
 The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> class also defines several extraction operators. For more information, see [basic_istream::operator&gt;&gt;](../vs140/basic_istream-class.md#basic_istream__operator_gt__gt_).  
  
 The template function:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 extracts up to                         *N* - 1 elements and stores them in the array starting at _                        *Str*. If <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. [width](../vs140/ios_base-class.md#ios_base__width) is greater than zero,                         *N* is <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. **width**; otherwise, it is the size of the largest array of **Elem** that can be declared. The function always stores the value **Elem()** after any extracted elements it stores. Extraction stops early on end of file, on a character with value **Elem**(0) (which is not extracted), or on any element (which is not extracted) that would be discarded by [ws](../vs140/-istream--functions.md#ws). If the function extracts no elements, it calls <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. [setstate](../vs140/basic_ios-class.md#basic_ios__setstate)( **failbit**). In any case, it calls <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. **width**(0) and returns <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
 **Security Note** The null-terminated string being extracted from the input stream must not exceed the size of the destination buffer <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. For more information, see                         [Avoiding Buffer Overruns](http://msdn.microsoft.com/library/windows/desktop/ms717795).  
  
 The template function:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 extracts an element, if it is possible, and stores it in <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. Otherwise, it calls **is**. [setstate](../vs140/basic_ios-class.md#basic_ios__setstate)( **failbit**). In any case, it returns <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
 The template function:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 returns <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> >> ( <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>**\***) <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
 The template function:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 returns <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> >> ( **char&**) <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
 The template function:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 returns <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> >> ( **char \***) <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
 The template function:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 returns <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> >> ( **char&**) <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
 The template function:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 returns <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> (and converts an <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> to an <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> in the process).  
  
### Example  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
## See Also  
 [&lt;istream&gt;](../vs140/-istream-.md)