---
title: "initializer_list Class"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
ms.assetid: 1f2c0ff4-5636-4f79-b008-e75426e3d2ab
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# initializer_list Class
Provides access to an array of elements in which each member is of the specified type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|The element data type to be stored in the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|The pointer to the first element of the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|The pointer to the last element of the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.|  
  
## Remarks  
 An <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> can be constructed using a braced initializer list:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The compiler transforms braced initializer lists with homogeneous elements into an <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> whenever the function signature requires an <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. For more details on using <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, see [Uniform Initialization and Delegating Constructors](../vs140/uniform-initialization-and-delegating-constructors.md)  
  
### Constructors  
  
|||  
|-|-|  
|[initializer_list](../vs140/forward_list-class.md#forward_list__forward_list)|Constructs an object of type <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.|  
  
### Typedefs  
  
|||  
|-|-|  
|value_type|The type of the elements in the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.|  
|reference|A type that provides a reference to an element in the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.|  
|const_reference|A type that provides a constant reference to an element in the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.|  
|size_type|A type that represents the number of elements in the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.|  
|iterator|A type that provides an iterator for the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.|  
|const_iterator|A type that provides a constant iterator for the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.|  
  
### Member Functions  
  
|||  
|-|-|  
|[begin](#initializer_list__begin)|Returns a pointer to the first element in an <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.|  
|[end](#initializer_list__end)|Returns a pointer to one past the last element in an <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.|  
|[size](#initializer_list__size)|Returns the number of elements in the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.|  
  
## Requirements  
 **Header:** \<initializer_list>  
  
 **Namespace:** std  
  
##  \<a name="initializer_list__begin">\</a>  initializer_list::begin  
 Returns a pointer to the first element in an <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the first element of the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>. If the list is empty, the pointer is the same for the beginning and end of the list.  
  
### Remarks  
  
##  \<a name="initializer_list__end">\</a>  initializer_list::end  
 Returns a pointer to one past the last element in an <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to one past the last element in the list. If the list is empty, this is the same as the pointer to the first element in the list.  
  
##  \<a name="initializer_list__initializer_list">\</a>  initializer_list::initializer_list  
 Constructs an object of type <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|The position of the first element in the range of elements to be copied.|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|The position of the first element beyond the range of elements to be copied.|  
  
### Remarks  
 An <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is based on an array of objects of the specified type. Copying an <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> creates a second instance of a list pointing to the same objects; the underlying objects are not copied.  
  
### Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  **c1 = 3c2 = 5 4 3 2 1c3 = 5 4 3 2 1c4 = 5 4c5 = 5 4**    
##  \<a name="initializer_list__size">\</a>  initializer_list::size  
 Returns the number of elements in the list.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 The number of elements in the list.  
  
### Remarks  
  
## See Also  
 [\<initializer_list>](../vs140/-forward_list-.md)