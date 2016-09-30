---
title: "istream_iterator Class"
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
  - "iterator/std::istream_iterator"
  - "std.istream_iterator"
  - "std::istream_iterator"
  - "istream_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "istream_iterator class"
ms.assetid: fb52a8cd-7f71-48d1-b73e-4b064e2a8d16
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# istream_iterator Class
Describes an input iterator object. It extracts objects of class <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> from an input stream, which it accesses through an object it stores, of type <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>< <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 The type of object to be extracted from the input stream.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 The type that represents the character type for the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. This argument is optional and the default value is <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 The type that represents the character type for the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. This argument is optional and the default value is <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>< <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>>.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 A signed integral type that represents the difference type for the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>. This argument is optional and the default value is <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
 After constructing or incrementing an object of class istream_iterator with a nonnull stored pointer, the object attempts to extract and store an object of type <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> from the associated input stream. If the extraction fails, the object effectively replaces the stored pointer with a null pointer, thus making an end-of-sequence indicator.  
  
### Constructors  
  
|||  
|-|-|  
|[istream_iterator](#istream_iterator__istream_iterator)|Constructs either an end-of-stream iterator as the default <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> or a <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> initialized to the iterator's stream type from which it reads.|  
  
### Typedefs  
  
|||  
|-|-|  
|[char_type](#istream_iterator__char_type)|A type that provides for the character type of the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.|  
|[istream_type](#istream_iterator__istream_type)|A type that provides for the stream type of the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.|  
|[traits_type](#istream_iterator__traits_type)|A type that provides for the character traits type of the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>.|  
  
### Operators  
  
|||  
|-|-|  
|[operator*](#istream_iterator__operator_star)|The dereferencing operator returns the stored object of type <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> addressed by the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>.|  
|[operator->](#istream_iterator__operator-_gt_)|Returns the value of a member, if any.|  
|[operator++](#istream_iterator__operator_add_add)|Either extracts an incremented object from the input stream or copies the object before incrementing it and returns the copy.|  
  
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
##  \<a name="istream_iterator__char_type">\</a>  istream_iterator::char_type  
 A type that provides for the character type of the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter **Chartype**.  
  
### Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
##  \<a name="istream_iterator__istream_iterator">\</a>  istream_iterator::istream_iterator  
 Constructs either an end-of-stream iterator as the default <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> or a <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> initialized to the iterator's stream type from which it reads.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 The input stream to be read use to initialize the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.  
  
### Remarks  
 The First constructor initializes the input stream pointer with a null pointer and creates an end-of-stream iterator. The second constructor initializes the input stream pointer with                         *&_Istr*, then attempts to extract and store an object of type **Type**.  
  
 The end-of-stream iterator can be use to test whether an <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> has reached the end of a stream.  
  
### Example  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
##  \<a name="istream_iterator__istream_type">\</a>  istream_iterator::istream_type  
 A type that provides for the stream type of the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>\< **CharType**, **Traits**>.  
  
### Example  
  See [istream_iterator](#istream_iterator__istream_iterator) for an example of how to declare and use <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>.  
  
##  \<a name="istream_iterator__operator_star">\</a>  istream_iterator::operator*  
 The dereferencing operator returns the stored object of type **Type** addressed by the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 The stored object of type **Type**.  
  
### Example  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
##  \<a name="istream_iterator__operator-_gt_">\</a>  istream_iterator::operator-&gt;  
 Returns the value of a member, if any.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 The value of a member, if any.  
  
### Remarks  
 *i* -> is equivalent to (\*                        *i*).                        *m*  
  
 The operator returns **&\*\*this**.  
  
### Example  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
##  \<a name="istream_iterator__operator_add_add">\</a>  istream_iterator::operator++  
 Either extracts an incremented object from the input stream or copies the object before incrementing it and returns the copy.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 The first member operator returns a reference to the incremented object of type **Type** extracted from the input stream and the second member function returns a copy of the object.  
  
### Example  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
##  \<a name="istream_iterator__traits_type">\</a>  istream_iterator::traits_type  
 A type that provides for the character traits type of the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter **Traits**.  
  
### Example  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
## See Also  
 [input_iterator_tag Struct](../vs140/input_iterator_tag-struct.md)   
 [iterator Class](../vs140/iterator-struct.md)   
 [\<iterator>](../vs140/-iterator-.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [Standard Template Library](../vs140/standard-template-library.md)