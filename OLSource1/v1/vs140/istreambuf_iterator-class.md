---
title: "istreambuf_iterator Class"
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
  - "istreambuf_iterator"
  - "std.istreambuf_iterator"
  - "std::istreambuf_iterator"
  - "streambuf/std::istreambuf_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "istreambuf_iterator class"
ms.assetid: 39002da2-61a6-48a5-9d0c-5df8271f6038
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# istreambuf_iterator Class
The template class istreambuf_iterator describes an input iterator object that extracts character elements from an input stream buffer, which it accesses through an object it stores, of type pointer to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>\< **CharType**, **Traits**>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 The type that represents the character type for the istreambuf_iterator.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 The type that represents the character type for the istreambuf_iterator. This argument is optional and the default value is <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>\<                        *CharType>.*  
  
## Remarks  
 The istreambuf_iterator class must satisfy the requirements for an input iterator.  
  
 After constructing or incrementing an object of class istreambuf_iterator with a non-null stored pointer, the object effectively attempts to extract and store an object of type **CharType** from the associated input stream. The extraction may be delayed, however, until the object is actually dereferenced or copied. If the extraction fails, the object effectively replaces the stored pointer with a null pointer, thus making an end-of-sequence indicator.  
  
### Constructors  
  
|||  
|-|-|  
|[istreambuf_iterator](#istreambuf_iterator__istreambuf_iterator)|Constructs an <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> that is initialized to read characters from the input stream.|  
  
### Typedefs  
  
|||  
|-|-|  
|[char_type](#istreambuf_iterator__char_type)|A type that provides for the character type of the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.|  
|[int_type](#istreambuf_iterator__int_type)|A type that provides an integer type for an <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.|  
|[istream_type](#istreambuf_iterator__istream_type)|A type that provides for the stream type of the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.|  
|[streambuf_type](#istreambuf_iterator__streambuf_type)|A type that provides for the stream type of the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.|  
|[traits_type](../vs140/istream_iterator-class.md#istream_iterator__traits_type)|A type that provides for the character traits type of the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.|  
  
### Member Functions  
  
|||  
|-|-|  
|[equal](#istreambuf_iterator__equal)|Tests for equality between two input stream buffer iterators.|  
  
### Operators  
  
|||  
|-|-|  
|[operator*](#istreambuf_iterator__operator_star)|The dereferencing operator returns the next character in the stream.|  
|[operator++](#istreambuf_iterator__operator_add_add)|Either returns the next character from the input stream or copies the object before incrementing it and returns the copy.|  
|[operator->](#istreambuf_iterator__operator-_gt_)|Returns the value of a member, if any.|  
  
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
##  \<a name="istreambuf_iterator__char_type">\</a>  istreambuf_iterator::char_type  
 A type that provides for the character type of the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter **CharType**.  
  
### Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
##  \<a name="istreambuf_iterator__equal">\</a>  istreambuf_iterator::equal  
 Tests for equivalence between two input stream buffer iterators.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 The iterator for which to check for equality.  
  
### Return Value  
 **true** if both <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>s are end-of-stream iterators or if neither is an end-of-stream iterator; otherwise **false**.  
  
### Remarks  
 A range is defined by the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> to the current position and the end-of-stream iterator, but since all non-end-of stream iterators are equivalent under the **equal** member function, it is not possible to define any subranges using <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>s. The <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> operators have the same semantics.  
  
### Example  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
##  \<a name="istreambuf_iterator__int_type">\</a>  istreambuf_iterator::int_type  
 A type that provides an integer type for an <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for **Traits::int_type**.  
  
### Example  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
##  \<a name="istreambuf_iterator__istream_type">\</a>  istreambuf_iterator::istream_type  
 A type that provides for the stream type of the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>\< **CharType**, **Traits**>.  
  
### Example  
  See [istreambuf_iterator](#istreambuf_iterator__istreambuf_iterator) for an example of how to declare and use <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
##  \<a name="istreambuf_iterator__istreambuf_iterator">\</a>  istreambuf_iterator::istreambuf_iterator  
 Constructs an istreambuf_iterator that is initialized to read characters from the input stream.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 The input stream buffer to which the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> is being attached.  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 The input stream to which the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> is being attached.  
  
### Remarks  
 The first constructor initializes the input stream-buffer pointer with <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>. The second constructor initializes the input stream-buffer pointer with <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>, and then eventually attempts to extract and store an object of type **CharType**.  
  
### Example  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
##  \<a name="istreambuf_iterator__operator_star">\</a>  istreambuf_iterator::operator*  
 The dereferencing operator returns the next character in the stream.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 The next character in the stream.  
  
### Example  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
##  \<a name="istreambuf_iterator__operator_add_add">\</a>  istreambuf_iterator::operator++  
 Either returns the next character from the input stream or copies the object before incrementing it and returns the copy.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 An <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> or a reference to an <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>.  
  
### Remarks  
 The first operator eventually attempts to extract and store an object of type **CharType** from the associated input stream. The second operator makes a copy of the object, increments the object, and then returns the copy.  
  
### Example  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
##  \<a name="istreambuf_iterator__operator-_gt_">\</a>  istreambuf_iterator::operator-&gt;  
 Returns the value of a member, if any.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 The operator returns **&\*\*this**.  
  
##  \<a name="istreambuf_iterator__streambuf_type">\</a>  istreambuf_iterator::streambuf_type  
 A type that provides for the stream type of the istreambuf_iterator.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>\< **CharType**, **Traits**>.  
  
### Example  
  See [istreambuf_iterator](#istreambuf_iterator__istreambuf_iterator) for an example of how to declare and use **istreambuf_type**.  
  
##  \<a name="istreambuf_iterator__traits_type">\</a>  istreambuf_iterator::traits_type  
 A type that provides for the character traits type of the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter **Traits**.  
  
### Example  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
## See Also  
 [iterator Class](../vs140/iterator-struct.md)   
 [\<iterator>](../vs140/-iterator-.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [Standard Template Library](../vs140/standard-template-library.md)