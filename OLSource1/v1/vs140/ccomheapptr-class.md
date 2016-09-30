---
title: "CComHeapPtr Class"
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
  - "ATL::CComHeapPtr"
  - "ATL.CComHeapPtr<T>"
  - "ATL::CComHeapPtr<T>"
  - "CComHeapPtr"
  - "ATL.CComHeapPtr"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComHeapPtr class"
ms.assetid: bd08b53d-da2b-43ab-a79c-e7c8dbbc5994
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComHeapPtr Class
A smart pointer class for managing heap pointers.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The object type to be stored on the heap.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CComHeapPtr::CComHeapPtr](../vs140/ccomheapptr--ccomheapptr.md)|The constructor.|  
  
## Remarks  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> derives from <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, but uses [CComAllocator](../vs140/ccomallocator-class.md) to allocate memory using COM routines. See [CHeapPtr](../vs140/cheapptr-class.md) and [CHeapPtrBase](../vs140/cheapptrbase-class.md) for the methods available.  
  
## Inheritance Hierarchy  
 [CHeapPtrBase](../vs140/cheapptrbase-class.md)  
  
 [CHeapPtr](../vs140/cheapptr-class.md)  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlbase.h  
  
##  \<a name="ccomheapptr__ccomheapptr">\</a>  CComHeapPtr::CComHeapPtr  
 The constructor.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 An existing <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object.  
  
### Remarks  
 The heap pointer can optionally be created using an existing <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object. If so, the new <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object assumes responsibility for managing the new pointer and resources.  
  
## See Also  
 [CHeapPtr Class](../vs140/cheapptr-class.md)   
 [CHeapPtrBase Class](../vs140/cheapptrbase-class.md)   
 [CComAllocator Class](../vs140/ccomallocator-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)