---
title: "CFixedStringT Class"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CFixedStringT"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CFixedStringT class"
  - "shared classes, CFixedStringT"
ms.assetid: 6d4171ba-3104-493a-a6cc-d515f4ba9a4b
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFixedStringT Class
This class represents a string object with a fixed character buffer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Used as the base class for the fixed string object and can be any                         <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>-based type. Some examples include                         <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>,                         <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, and                         <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 *t_nChars*  
 The number of characters stored in the buffer.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CFixedStringT::CFixedStringT](#cfixedstringt__cfixedstringt)|The constructor for the string object.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CFixedStringT::operator =](#cfixedstringt__operator__eq)|Assigns a new value to a                                         <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.|  
  
## Remarks  
 This class is an example of a custom string class based on                 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. Although quite similar, the two classes differ in implementation. The major differences between                 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and                 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> are:  
  
-   The initial character buffer is allocated as part of the object and has size                         *t_nChars*. This allows the                         **CFixedString** object to occupy a contiguous memory chunk for performance purposes. However, if the contents of a                         <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object grows beyond                         *t_nChars*, the buffer is allocated dynamically.  
  
-   The character buffer for a                         <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object is always the same length (                        *t_nChars*). There is no limitation on buffer size for                         <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> objects.  
  
-   The memory manager for                         <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is customized such that sharing of a                         [CStringData](../vs140/cstringdata-class.md) object between two or more                         <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> objectsis not allowed.                         <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> objects do not have this limitation.  
  
 For more information on the customization of                 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and memory management for string objects in general, see                 [Memory Management and CStringT](../vs140/memory-management-with-cstringt.md).  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** cstringt.h  
  
##  \<a name="cfixedstringt__cfixedstringt">\</a>  CFixedStringT::CFixedStringT  
 Constructs a                 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 A null-terminated string to be copied into this                                 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 An existing                                 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object to be copied into this                                 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 A pointer to the memory manager of the                                 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object. For more information on                                 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> and memory management for                                 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, see                                 [Memory Management and CStringT](../vs140/memory-management-with-cstringt.md).  
  
### Remarks  
 Because the constructors copy the input data into new allocated storage, you should be aware that memory exceptions may result. Note that some of these constructors act as conversion functions.  
  
##  \<a name="cfixedstringt__operator__eq">\</a>  CFixedStringT::operator =  
 Reinitializes an existing                 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> object with new data.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 A null-terminated string to be copied into this                                 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 An existing                                 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> to be copied into this                                 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object.  
  
### Remarks  
 You should be aware that memory exceptions may occur whenever you use the assignment operator because new storage is often allocated to hold the resulting                         <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> object.  
  
## See Also  
 [CStringT](../vs140/cstringt-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Shared Classes](../vs140/atl-mfc-shared-classes.md)