---
title: "ostreambuf_iterator Class"
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
  - "std.ostreambuf_iterator"
  - "streambuf/std::ostreambuf_iterator"
  - "ostreambuf_iterator"
  - "std::ostreambuf_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ostreambuf_iterator class"
ms.assetid: dad1e624-2f45-4e94-8887-a885e95f9071
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ostreambuf_iterator Class
The template class ostreambuf_iterator describes an output iterator object that writes successive character elements onto the output stream with the extraction **operator>>**. The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>s differ from those of the [ostream_iterator Class](../vs140/ostream_iterator-class.md) in having characters instead of a generic type at the type of object being inserted into the output stream.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 The type that represents the character type for the ostreambuf_iterator. This argument is optional and the default value is <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>*.*  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 The type that represents the character type for the ostreambuf_iterator. This argument is optional and the default value is <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>\<                        *CharType>.*  
  
## Remarks  
 The ostreambuf_iterator class must satisfy the requirements for an output iterator. Algorithms can be written directly to output streams using an <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. The class provides a low-level stream iterator that allows access to the raw (unformatted) I/O stream in the form of characters and the ability to bypass the buffering and character translations associated with the high-level stream iterators.  
  
### Constructors  
  
|||  
|-|-|  
|[ostreambuf_iterator](#ostreambuf_iterator__ostreambuf_iterator)|Constructs an <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> that is initialized to write characters to the output stream.|  
  
### Typedefs  
  
|||  
|-|-|  
|[char_type](#ostreambuf_iterator__char_type)|A type that provides for the character type of the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.|  
|[ostream_type](#ostreambuf_iterator__ostream_type)|A type that provides for the stream type of the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.|  
|[streambuf_type](#ostreambuf_iterator__streambuf_type)|A type that provides for the stream type of the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.|  
|[traits_type](#ostreambuf_iterator__traits_type)|A type that provides for the character traits type of the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.|  
  
### Member Functions  
  
|||  
|-|-|  
|[failed](#ostreambuf_iterator__failed)|Tests for failure of an insertion into the output stream buffer.|  
  
### Operators  
  
|||  
|-|-|  
|[operator*](#ostreambuf_iterator__operator_star)|Dereferencing operator used to implement the output iterator expression * <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> = <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.|  
|[operator++](#ostreambuf_iterator__operator_add_add)|A nonfunctional increment operator that returns an <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> to the same object it addressed before the operation was called.|  
|[operator=](#ostreambuf_iterator__operator_eq)|The operator inserts a character into the associated stream buffer.|  
  
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
##  \<a name="ostreambuf_iterator__char_type">\</a>  ostreambuf_iterator::char_type  
 A type that provides for the character type of the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter **CharType**.  
  
### Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
##  \<a name="ostreambuf_iterator__failed">\</a>  ostreambuf_iterator::failed  
 Tests for failure of an insertion into the output stream buffer.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 **true** if no insertion into the output stream buffer has failed earlier; otherwise **false**.  
  
### Remarks  
 The member function returns **true** if, in any prior use of member <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, the call to **subf**_-> <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> returned **eof**.  
  
### Example  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
##  \<a name="ostreambuf_iterator__operator_star">\</a>  ostreambuf_iterator::operator*  
 A nonfunctional dereferencing operator used to implement the output iterator expression \*                *i* =                 *x*.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 The ostreambuf iterator object.  
  
### Remarks  
 This operator functions only in the output iterator expression \*                        *i* =                         *x* to output characters to stream buffer. Applied to an ostreambuf iterator, it returns the iterator; **\*iter** returns **iter**,  
  
### Example  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
##  \<a name="ostreambuf_iterator__operator_add_add">\</a>  ostreambuf_iterator::operator++  
 A nonfunctional increment operator that returns an ostream iterator to the same character it addressed before the operation was called.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 A reference to the character originally addressed or to an implementation-defined object that is convertible to <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>\< **CharType**, **Traits**>.  
  
### Remarks  
 The operator is used to implement the output iterator expression \*                        *i* =                         *x*.  
  
### Example  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
##  \<a name="ostreambuf_iterator__operator_eq">\</a>  ostreambuf_iterator::operator=  
 The operator inserts a character into the associated stream buffer.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 The character to be inserted into the stream buffer.  
  
### Return Value  
 A reference to the character inserted into the stream buffer.  
  
### Remarks  
 Assignment operator used to implement the output iterator expression \*                        *i* =                         *x* for writing to an output stream.  
  
### Example  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
##  \<a name="ostreambuf_iterator__ostreambuf_iterator">\</a>  ostreambuf_iterator::ostreambuf_iterator  
 Constructs an <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> that is initialized to write characters to the output stream.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 The output streambuf object used to initialize the output stream-buffer pointer.  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 The output stream object used to initialize the output stream-buffer pointer.  
  
### Remarks  
 The first constructor initializes the output stream-buffer pointer with <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>.  
  
 The second constructor initializes the output stream-buffer pointer with <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>. The stored pointer must not be a null pointer.  
  
### Example  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
##  \<a name="ostreambuf_iterator__ostream_type">\</a>  ostreambuf_iterator::ostream_type  
 A type that provides for the stream type of the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>\< **CharType**, **Traits**>  
  
### Example  
  See [ostreambuf_iterator](#ostreambuf_iterator__ostreambuf_iterator) for an example of how to declare and use <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.  
  
##  \<a name="ostreambuf_iterator__streambuf_type">\</a>  ostreambuf_iterator::streambuf_type  
 A type that provides for the stream type of the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>\< **CharType**, **Traits**>, a stream class for I/O buffers that becomes <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> when specialized to character type <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>.  
  
### Example  
  See [ostreambuf_iterator](#ostreambuf_iterator__ostreambuf_iterator) for an example of how to declare and use <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>.  
  
##  \<a name="ostreambuf_iterator__traits_type">\</a>  ostreambuf_iterator::traits_type  
 A type that provides for the character traits type of the <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter **Traits**.  
  
### Example  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
## See Also  
 [\<iterator>](../vs140/-iterator-.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [Standard Template Library](../vs140/standard-template-library.md)