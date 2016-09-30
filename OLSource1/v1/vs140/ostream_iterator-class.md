---
title: "ostream_iterator Class"
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
  - "ostream_iterator"
  - "std.ostream_iterator"
  - "std::ostream_iterator"
  - "iterator/std::ostream_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ostream_iterator class"
ms.assetid: 24d842d3-9f45-4bf6-a697-62f5968f5a03
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ostream_iterator Class
The template class ostream_iterator describes an output iterator object that writes successive elements onto the output stream with the extraction **operator <<**.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *Type*  
 The type of object to be inserted into the output stream.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The type that represents the character type for the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. This argument is optional and the default value is <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>*.*  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 The type that represents the character type for the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. This argument is optional and the default value is <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>\<                        *CharType>.*  
  
 The ostream_iterator class must satisfy the requirements for an output iterator. Algorithms can be written directly to output streams using an <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
### Constructors  
  
|||  
|-|-|  
|[ostream_iterator](#ostream_iterator__ostream_iterator)|Constructs an <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> that is initialized and delimited to write to the output stream.|  
  
### Typedefs  
  
|||  
|-|-|  
|[char_type](#ostream_iterator__char_type)|A type that provides for the character type of the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.|  
|[ostream_type](#ostream_iterator__ostream_type)|A type that provides for the stream type of the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.|  
|[traits_type](#ostream_iterator__traits_type)|A type that provides for the character traits type of the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.|  
  
### Operators  
  
|||  
|-|-|  
|[operator*](#ostream_iterator__operator_star)|Dereferencing operator used to implement the output iterator expression * <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> = <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.|  
|[operator++](#ostream_iterator__operator_add_add)|A nonfunctional increment operator that returns an <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> to the same object it addressed before the operation was called.|  
|[operator=](#ostream_iterator__operator_eq)|Assignment operator used to implement the output iterator expression * <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> = <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> for writing to an output stream.|  
  
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
##  \<a name="ostream_iterator__char_type">\</a>  ostream_iterator::char_type  
 A type that provides for the character type of the iterator.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter **CharType**.  
  
### Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
##  \<a name="ostream_iterator__operator_star">\</a>  ostream_iterator::operator*  
 Dereferencing operator used to implement the output iterator expression \*                *ii* =                 *x*.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 A reference to the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
### Remarks  
 The requirements for an output iterator that the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> must satisfy require only the expression \*                        *ii* =                         *t* be valid and says nothing about the **operator** or the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> on their own. The member operator in this implementation returns **\*this**.  
  
### Example  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
##  \<a name="ostream_iterator__operator_add_add">\</a>  ostream_iterator::operator++  
 A nonfunctional increment operator that returns an <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> to the same object it addressed before the operation was called.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 A reference to the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.  
  
### Remarks  
 These member operators both return **\*this**.  
  
### Example  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
##  \<a name="ostream_iterator__operator_eq">\</a>  ostream_iterator::operator=  
 Assignment operator used to implement the output_iterator expression * <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> = <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> for writing to an output stream.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 The value of the object of type <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> to be inserted into the output stream.  
  
### Return Value  
 The operator inserts <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> into the output stream associated with the object, followed by the delimiter specified in the [ostream_iterator constructor](#ostream_iterator__ostream_iterator) (if any), and then returns a reference to the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.  
  
### Remarks  
 The requirements for an output iterator that the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> must satisfy require only the expression * <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> = <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> be valid and says nothing about the operator or the operator= on their own. This member operator returns <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
##  \<a name="ostream_iterator__ostream_iterator">\</a>  ostream_iterator::ostream_iterator  
 Constructs an <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> that is initialized and delimited to write to the output stream.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 The output stream of type [ostream_iterator::ostream_type](#ostream_iterator__ostream_type) to be iterated over.  
  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 The delimiter that is inserted into the output stream between values.  
  
### Remarks  
 The first constructor initializes the output stream pointer with <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>. The delimiter string pointer designates an empty string.  
  
 The second constructor initializes the output stream pointer with <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> and the delimiter string pointer with <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
##  \<a name="ostream_iterator__ostream_type">\</a>  ostream_iterator::ostream_type  
 A type that provides for the stream type of the iterator.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for [basic_ostream](../vs140/basic_ostream-class.md)< <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>>, a stream class of the iostream hierarchy that defines objects that can be used for writing.  
  
### Example  
  See [ostream_iterator](#ostream_iterator__ostream_iterator) for an example of how to declare and use <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>.  
  
##  \<a name="ostream_iterator__traits_type">\</a>  ostream_iterator::traits_type  
 A type that provides for the character traits type of the iterator.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for the template parameter **Traits**.  
  
### Example  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
## See Also  
 [\<iterator>](../vs140/-iterator-.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [Standard Template Library](../vs140/standard-template-library.md)