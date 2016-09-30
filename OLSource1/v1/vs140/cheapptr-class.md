---
title: "CHeapPtr Class"
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
  - "ATL::CHeapPtr"
  - "CHeapPtr"
  - "ATL.CHeapPtr"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CHeapPtr class"
ms.assetid: e5c5bfd4-9bf1-4164-8a83-8155fe253454
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHeapPtr Class
A smart pointer class for managing heap pointers.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The object type to be stored on the heap.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The memory allocation class to use.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CHeapPtr::CHeapPtr](../vs140/cheapptr--cheapptr.md)|The constructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CHeapPtr::Allocate](../vs140/cheapptr--allocate.md)|Call this method to allocate memory on the heap to store objects.|  
|[CHeapPtr::Reallocate](../vs140/cheapptr--reallocate.md)|Call this method to reallocate the memory on the heap.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CHeapPtr::operator =](../vs140/cheapptr--operator-=.md)|The assignment operator.|  
  
## Remarks  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is derived from                 [CHeapPtrBase](../vs140/cheapptrbase-class.md) and by default uses the CRT routines (in                 [CCRTAllocator](../vs140/ccrtallocator-class.md)) to allocate and free memory. The class                 [CHeapPtrList](../vs140/cheapptrlist-class.md) may be used to construct a list of heap pointers. See also                 [CComHeapPtr](../vs140/ccomheapptr-class.md), which uses COM memory allocation routines.  
  
## Inheritance Hierarchy  
 [CHeapPtrBase](../vs140/cheapptrbase-class.md)  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlcore.h  
  
##  \<a name="cheapptr__allocate">\</a>  CHeapPtr::Allocate  
 Call this method to allocate memory on the heap to store objects.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The number of elements used to calculate the amount of memory to allocate. The default value is 1.  
  
### Return Value  
 Returns true if the memory was successfully allocated, false on failure.  
  
### Remarks  
 The allocator routines are used to reserve enough memory on the heap to store                         *nElement* objects of a type defined in the constructor.  
  
### Example  
 [!code[NVC_ATL_Utilities#77](../vs140/codesnippet/CPP/cheapptr-class_1.cpp)]  
  
##  \<a name="cheapptr__cheapptr">\</a>  CHeapPtr::CHeapPtr  
 The constructor.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 An existing heap pointer or                                 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
### Remarks  
 The heap pointer can optionally be created using an existing pointer, or a                         <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object. If so, the new                         <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object assumes responsibility for managing the new pointer and resources.  
  
### Example  
 [!code[NVC_ATL_Utilities#78](../vs140/codesnippet/CPP/cheapptr-class_2.cpp)]  
  
##  \<a name="cheapptr__operator__eq">\</a>  CHeapPtr::operator =  
 Assignment operator.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 An existing                                 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object.  
  
### Return Value  
 Returns a reference to the updated                         <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
### Example  
 [!code[NVC_ATL_Utilities#80](../vs140/codesnippet/CPP/cheapptr-class_3.cpp)]  
  
##  \<a name="cheapptr__reallocate">\</a>  CHeapPtr::Reallocate  
 Call this method to reallocate the memory on the heap.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 The new number of elements used to calculate the amount of memory to allocate.  
  
### Return Value  
 Returns true if the memory was successfully allocated, false on failure.  
  
### Example  
 [!code[NVC_ATL_Utilities#79](../vs140/codesnippet/CPP/cheapptr-class_4.cpp)]  
  
## See Also  
 [CHeapPtrBase Class](../vs140/cheapptrbase-class.md)   
 [CCRTAllocator Class](../vs140/ccrtallocator-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)