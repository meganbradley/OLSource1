---
title: "&lt;bitset&gt; operators"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 84fe6a13-6f6e-4cdc-bf8f-6f65ab1134d4
caps.latest.revision: 12
---
# &lt;bitset&gt; operators
||||  
|-|-|-|  
|[operator&amp;](#operator_amp_)|[operator&gt;&gt;](#operator_gt__gt_)|[operator&lt;&lt;](#operator_lt__lt_)|  
|[operator^](#operator_xor)|[operator&#124;](#operator_or)|  
  
##  \<a name="operator_amp_">\</a>  operator&amp;  
 Performs a bitwise                 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> between two bitsets.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The first of the two bitsets whose respective elements are to be combined with the bitwise                                 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 The second of the two valarrays whose respective elements are to be combined with the bitwise                                 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
### Return Value  
 A bitset whose elements are the result of performing the                         <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> operation on the corresponding elements of                         <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and                         <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **bitset 1: 0101**  
**bitset 2: 0011**  
**bitset 3: 0001**    
##  \<a name="operator_lt__lt_">\</a>  operator&lt;&lt;  
 Inserts a text representation of the bit sequence into the output stream.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 An object of type                                 **bitset\<N>** that is to be inserted into the output stream as a string.  
  
### Return Value  
 A text representation of the bit sequence in                         **ostr**.  
  
### Remarks  
 The template function overloads                         **operator<<**, allowing a bitset to be written out without first converting it into a string. The template function effectively executes:  
  
 **ostr** << _                        *Right*.                                               [to_string](https://msdn.microsoft.com/en-us/library/2f93c55z.aspx) <                        **CharType**,                         **Traits**,                         **allocator**\<                        **CharType**> > ( )  
  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="operator_gt__gt_">\</a>  operator&gt;&gt;  
 Reads a string of bit characters into a bitset.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 The string that is entered into the input stream to be inserted into the bitset.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 The bitset that is receiving the bits from the input stream.  
  
### Return Value  
 The template function returns the string                         <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
### Remarks  
 The template function overloads                         **operator>>** to store in the bitset _                        *Right* the value bitset(                        <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>), where                         <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is an object of type                                                                   [basic_string](https://msdn.microsoft.com/en-us/library/syxtdd4f.aspx) <                        **CharType**,                         **Traits**,                         **allocator**\<                        **CharType**> >                        **&** extracted from                         <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
 The template function extracts elements from                         <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and inserts them into the bitset until:  
  
-   All the bit elements have been extracted from the input stream and stored in the bitset.  
  
-   The bitset is filled up with bits from the input stream.  
  
-   An input element is encountered that is neither 0 nor 1.  
  
### Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="operator_xor">\</a>  operator_xor  
 Performs a bitwise                 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> between two bitsets.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 The first of the two bitsets whose respective elements are to be combined with the bitwise                                 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 The second of the two valarrays whose respective elements are to be combined with the bitwise                                 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
### Return Value  
 A bitset whose elements are the result of performing the                         <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> operation on the corresponding elements of                         <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> and                         <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  **bitset 1: 0101**  
**bitset 2: 0011**  
**bitset 3: 0110**    
##  \<a name="operator_or">\</a>  operator_or  
 Performs a bitwise                 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> between two bitsets.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 The first of the two bitsets whose respective elements are to be combined with the bitwise                                 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 The second of the two valarrays whose respective elements are to be combined with the bitwise                                 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
### Return Value  
 A bitset whose elements are the result of performing the                         <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> operation on the corresponding elements of                         <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> and                         <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  **bitset 1: 0101**  
**bitset 2: 0011**  
**bitset 3: 0111**    
## See Also  
 [&lt;bitset&gt;](../vs140/-bitset-.md)