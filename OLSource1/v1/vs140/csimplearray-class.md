---
title: "CSimpleArray Class"
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
  - "ATL.CSimpleArray"
  - "ATL::CSimpleArray"
  - "CSimpleArray"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CSimpleArray class"
ms.assetid: ee0c9f39-b61c-4c18-bc43-4eada21dca3a
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSimpleArray Class
This class provides methods for managing a simple array.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 The type of data to store in the array.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 A trait object, defining the equality test for elements of type <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CSimpleArray::CSimpleArray](../vs140/csimplearray--csimplearray.md)|The constructor for the simple array.|  
|[CSimpleArray::~CSimpleArray](../vs140/csimplearray--~csimplearray.md)|The destructor for the simple array.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CSimpleArray::Add](../vs140/csimplearray--add.md)|Adds a new element to the array.|  
|[CSimpleArray::Find](../vs140/csimplearray--find.md)|Finds an element in the array.|  
|[CSimpleArray::GetData](../vs140/csimplearray--getdata.md)|Returns a pointer to the data stored in the array.|  
|[CSimpleArray::GetSize](../vs140/csimplearray--getsize.md)|Returns the number of elements stored in the array.|  
|[CSimpleArray::Remove](../vs140/csimplearray--remove.md)|Removes a given element from the array.|  
|[CSimpleArray::RemoveAll](../vs140/csimplearray--removeall.md)|Removes all elements from the array.|  
|[CSimpleArray::RemoveAt](../vs140/csimplearray--removeat.md)|Removes the specified element from the array.|  
|[CSimpleArray::SetAtIndex](../vs140/csimplearray--setatindex.md)|Sets the specified element in the array.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CSimpleArray::operator &#91;&#93;](../vs140/csimplearray--operator.md)|Retrieves an element from the array.|  
|[CSimpleArray::operator =](../vs140/csimplearray--operator-=.md)|Assignment operator.|  
  
## Remarks  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> provides methods for creating and managing a simple array, of any given type <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
 The parameter <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> provides a means of defining an equality function for two elements of type <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. By creating a class similar to [CSimpleArrayEqualHelper](../vs140/csimplearrayequalhelper-class.md), it is possible to alter the behavior of the equality test for any given array. For example, when dealing with an array of pointers, it may be useful to define the equality as depending on the values the pointers reference. The default implementation utilizes **operator=()**.  
  
 Both <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and [CSimpleMap](../vs140/csimplemap-class.md) are designed for a small number of elements. [CAtlArray](../vs140/catlarray-class.md) and [CAtlMap](../vs140/catlmap-class.md) should be used when the array contains a large number of elements.  
  
## Requirements  
 **Header:** atlsimpcoll.h  
  
## Example  
 [!code[NVC_ATL_Utilities#86](../vs140/codesnippet/CPP/csimplearray-class_1.cpp)]  
  
##  \<a name="csimplearray__add">\</a>  CSimpleArray::Add  
 Adds a new element to the array.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 *t*  
 The element to add to the array.  
  
### Return Value  
 Returns TRUE if the element is successfully added to the array, FALSE otherwise.  
  
### Example  
 [!code[NVC_ATL_Utilities#87](../vs140/codesnippet/CPP/csimplearray-class_2.cpp)]  
  
##  \<a name="csimplearray__csimplearray">\</a>  CSimpleArray::CSimpleArray  
 The constructor for the array object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 *src*  
 An existing <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object.  
  
### Remarks  
 Initializes the data members, creating a new empty <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object, or a copy of an existing <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object.  
  
##  \<a name="csimplearray___dtorcsimplearray">\</a>  CSimpleArray::~CSimpleArray  
 The destructor.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 Frees all allocated resources.  
  
##  \<a name="csimplearray__find">\</a>  CSimpleArray::Find  
 Finds an element in the array.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 *t*  
 The element for which to search.  
  
### Return Value  
 Returns the index of the found element, or -1 if the element is not found.  
  
### Example  
 [!code[NVC_ATL_Utilities#88](../vs140/codesnippet/CPP/csimplearray-class_3.cpp)]  
  
##  \<a name="csimplearray__getdata">\</a>  CSimpleArray::GetData  
 Returns a pointer to the data stored in the array.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 Returns a pointer to the data in the array.  
  
##  \<a name="csimplearray__getsize">\</a>  CSimpleArray::GetSize  
 Returns the number of elements stored in the array.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 Returns the number of elements stored in the array.  
  
##  \<a name="csimplearray__operator__at">\</a>  CSimpleArray::operator []  
 Retrieves an element from the array.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 The element index.  
  
### Return Value  
 Returns the element of the array referenced by <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
### Example  
 [!code[NVC_ATL_Utilities#89](../vs140/codesnippet/CPP/csimplearray-class_4.cpp)]  
  
##  \<a name="csimplearray__operator__eq">\</a>  CSimpleArray::operator =  
 Assignment operator.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 *src*  
 The array to copy.  
  
### Return Value  
 Returns a pointer to the updated <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object.  
  
### Remarks  
 Copies all elements from the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object referenced by *src* into the current array object, replacing all existing data.  
  
### Example  
 [!code[NVC_ATL_Utilities#90](../vs140/codesnippet/CPP/csimplearray-class_5.cpp)]  
  
##  \<a name="csimplearray__remove">\</a>  CSimpleArray::Remove  
 Removes a given element from the array.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 *t*  
 The element to remove from the array.  
  
### Return Value  
 Returns TRUE if the element is found and removed, FALSE otherwise.  
  
### Remarks  
 When an element is removed, the remaining elements in the array are renumbered to fill the empty space.  
  
##  \<a name="csimplearray__removeall">\</a>  CSimpleArray::RemoveAll  
 Removes all elements from the array.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Remarks  
 Removes all elements currently stored in the array.  
  
##  \<a name="csimplearray__removeat">\</a>  CSimpleArray::RemoveAt  
 Removes the specified element from the array.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 Index pointing to the element to remove.  
  
### Return Value  
 Returns TRUE if the element was removed, FALSE if the index was invalid.  
  
### Remarks  
 When an element is removed, the remaining elements in the array are renumbered to fill the empty space.  
  
##  \<a name="csimplearray__setatindex">\</a>  CSimpleArray::SetAtIndex  
 Set the specified element in the array.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 The index of the element to change.  
  
 *t*  
 The value to assign to the specified element.  
  
### Return Value  
 Returns TRUE if successful, FALSE if the index was not valid.  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)