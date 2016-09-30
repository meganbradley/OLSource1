---
title: "CPrimitiveElementTraits Class"
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
  - "ATL.CPrimitiveElementTraits<T>"
  - "CPrimitiveElementTraits"
  - "ATL.CPrimitiveElementTraits"
  - "ATL::CPrimitiveElementTraits<T>"
  - "ATL::CPrimitiveElementTraits"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CPrimitiveElementTraits class"
ms.assetid: 21c1cea8-2c5a-486c-b65c-85490f3ed4e6
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPrimitiveElementTraits Class
This class provides default methods and functions for a collection class composed of primitive data types.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The type of data to be stored in the collection class object.  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|[CPrimitiveElementTraits::INARGTYPE](../vs140/cprimitiveelementtraits--inargtype.md)|The data type to use for adding elements to the collection class object.|  
|[CPrimitiveElementTraits::OUTARGTYPE](../vs140/cprimitiveelementtraits--outargtype.md)|The data type to use for retrieving elements from the collection class object.|  
  
## Remarks  
 This class provides default static functions and methods for moving, copying, comparing, and hashing primitive data type elements stored in a collection class object.  
  
 For more information, see [ATL Collection Classes](../vs140/atl-collection-classes.md).  
  
## Inheritance Hierarchy  
 [CDefaultCompareTraits](../vs140/cdefaultcomparetraits-class.md)  
  
 [CDefaultHashTraits](../vs140/cdefaulthashtraits-class.md)  
  
 [CElementTraitsBase](../vs140/celementtraitsbase-class.md)  
  
 [CDefaultElementTraits](../vs140/cdefaultelementtraits-class.md)  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlcoll.h  
  
##  \<a name="cprimitiveelementtraits__inargtype">\</a>  CPrimitiveElementTraits::INARGTYPE  
 The data type to use for adding elements to the collection class object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="cprimitiveelementtraits__outargtype">\</a>  CPrimitiveElementTraits::OUTARGTYPE  
 The data type to use for retrieving elements from the collection class object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [CDefaultElementTraits Class](../vs140/cdefaultelementtraits-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)