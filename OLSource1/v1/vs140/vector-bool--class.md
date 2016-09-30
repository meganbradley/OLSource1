---
title: "vector&lt;bool&gt; Class"
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
  - "vector<bool>"
  - "std.vector<bool>"
  - "std::vector<bool>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "vector<bool> class"
ms.assetid: 8028c8ed-ac9c-4f06-aba1-5de45c00aafb
caps.latest.revision: 29
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# vector&lt;bool&gt; Class
The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> class is a partial specialization of [vector](../vs140/vector-class.md) for elements of type <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. It has an allocator for the underlying type that's used by the specialization, which provides space optimization by storing one <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> value per bit.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 This class template specialization behaves like [vector](../vs140/vector-class.md), except for the differences explained in this article.  
  
 Operations that deal with the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> type correspond to values in the container storage. <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is not used to construct these values.  
  
### Typedefs  
  
|||  
|-|-|  
|[const_pointer](#vector_lt_bool_gt___const_pointer)|A typedef to a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> that can serve as a constant pointer to a Boolean element of the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.|  
|[const_reference](#vector_lt_bool_gt___const_reference)|A typedef for <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. After initialization, it does not observe updates to the original value.|  
|[pointer](#vector_lt_bool_gt___pointer)|A typedef to an <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> that can serve as a pointer to a Boolean element of the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.|  
  
### Member Functions  
  
|||  
|-|-|  
|[flip](#vector_lt_bool_gt___flip)|Reverses all bits in the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.|  
|[swap](#vector_lt_bool_gt___swap)|Exchanges the elements of two <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>s.|  
|[operator&#91;&#93;](#vector_lt_bool_gt___operator_at)|Returns a simulated reference to the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> element at a specified position.|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|Functions the same as the unspecialized [vector::at](../vs140/vector-class.md#vector__at) function, except that it uses the proxy class [vector\<bool>::reference](#vector_lt_bool_gt___reference_class). Also see [operator&#91;&#93;](#vector_lt_bool_gt___operator_at).|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|Functions the same as the unspecialized [vector::front](../vs140/vector-class.md#vector__front) function, except that it uses the proxy class [vector\<bool>::reference](#vector_lt_bool_gt___reference_class). Also see [operator&#91;&#93;](#vector_lt_bool_gt___operator_at).|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|Functions the same as the unspecialized [vector::back](../vs140/vector-class.md#vector__back) function, except that it uses the proxy class [vector\<bool>::reference](#vector_lt_bool_gt___reference_class). Also see [operator&#91;&#93;](#vector_lt_bool_gt___operator_at).|  
  
### Proxy Class  
  
|||  
|-|-|  
|[vector\<bool> reference Class](#vector_lt_bool_gt___reference_class)|A class that acts as a proxy to simulate <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> behavior, and whose objects can provide references to elements (single bits) within a <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object.|  
  
## Requirements  
 **Header**: \<vector>  
  
 **Namespace:** std  
  
##  \<a name="vector_lt_bool_gt___const_pointer">\</a>  vector\<bool>::const_pointer  
 A type that describes an object that can serve as a constant pointer to a Boolean element of the sequence contained by the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="vector_lt_bool_gt___const_reference">\</a>  vector\<bool>::const_reference  
 A type that describes an object that can serve as a constant reference to a Boolean element of the sequence contained by the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 For more information and code examples, see [vector\<bool>::reference::operator=](#vector_lt_bool_gt___reference_operator_eq).  
  
##  \<a name="vector_lt_bool_gt___flip">\</a>  vector\<bool>::flip  
 Reverses all bits in a <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Example  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
##  \<a name="vector_lt_bool_gt___operator_at">\</a>  vector\<bool>::operator[]  
 Returns a simulated reference to the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> element at a specified position.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|The position of the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> element.|  
  
### Return Value  
 A [vector\<bool>::reference](#vector_lt_bool_gt___reference_class) or [vector\<bool>::const_reference](#vector_lt_bool_gt___const_reference) object that contains the value of the indexed element.  
  
 If the position specified is greater than or equal to the size of the container, the result is undefined.  
  
### Remarks  
 If you compile with <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> set, a run-time error occurs if you attempt to access an element outside the bounds of the vector.  For more information, see [Checked Iterators](../vs140/checked-iterators.md).  
  
### Example  
  This code example shows the correct use of <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> and two common coding mistakes, which are commented out. These mistakes cause errors because the address of the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> object that <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> returns cannot be taken.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
##  \<a name="vector_lt_bool_gt___pointer">\</a>  vector\<bool>::pointer  
 A type that describes an object that can serve as a pointer to a Boolean element of the sequence contained by the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
##  \<a name="vector_lt_bool_gt___reference_class">\</a>  vector\<bool>::reference Class  
 The <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> class is a proxy class provided by the [vector\<bool> Class](../vs140/vector-bool--class.md) to simulate <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>.  
  
### Remarks  
 A simulated reference is required because C++ does not natively allow direct references to bits. <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> uses only one bit per element, which can be referenced by using this proxy class. However, the reference simulation is not complete because certain assignments are not valid. For example, because the address of the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> object cannot be taken, the following code that uses [vector\<bool>::operator&#91;&#93;](#vector_lt_bool_gt___operator_at) is not correct:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
###  \<a name="vector_lt_bool_gt___reference_flip">\</a>  vector\<bool>::reference::flip  
 Inverts the Boolean value of a referenced [vector\<bool>](../vs140/vector-bool--class.md) element.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
#### Remarks  
  
#### Example  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
###  \<a name="vector_lt_bool_gt___reference_operator_bool">\</a>  vector\<bool>::reference::operator bool  
 Provides an implicit conversion from <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
#### Return Value  
 The Boolean value of the element of the vector\<bool> object.  
  
#### Remarks  
 The <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> object cannot be modified by this operator.  
  
###  \<a name="vector_lt_bool_gt___reference_operator_eq">\</a>  vector\<bool>::reference::operator=  
 Assigns a Boolean value to a bit, or the value held by a referenced element to a bit.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 The element reference whose value is to be assigned to the bit.  
  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 The Boolean value to be assigned to the bit.  
  
#### Example  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
##  \<a name="vector_lt_bool_gt___swap">\</a>  vector\<bool>::swap  
 Static member function that exchanges two elements of Boolean vectors ( <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>) by using the proxy class [vector\<bool>::reference](#vector_lt_bool_gt___reference_class).  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 The element to be exchanged with the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> element.  
  
 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 The element to be exchanged with the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> element.  
  
### Remarks  
 This overload supports the special proxy requirements of <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>. [vector::swap](../vs140/vector-class.md#vector__swap) has the same functionality as the single-argument overload of <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>.  
  
## See Also  
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [Standard Template Library](../vs140/standard-template-library.md)