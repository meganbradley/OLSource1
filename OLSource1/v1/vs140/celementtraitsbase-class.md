---
title: "CElementTraitsBase Class"
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
  - "CElementTraitsBase"
  - "ATL::CElementTraitsBase"
  - "ATL.CElementTraitsBase<T>"
  - "ATL::CElementTraitsBase<T>"
  - "ATL.CElementTraitsBase"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CElementTraitsBase class"
ms.assetid: 75284caf-347e-4355-a7d8-efc708dd514a
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CElementTraitsBase Class
This class provides default copy and move methods for a collection class.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The type of data to be stored in the collection.  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|[CElementTraitsBase::INARGTYPE](../vs140/celementtraitsbase--inargtype.md)|The data type to use for adding elements to the collection class object.|  
|[CElementTraitsBase::OUTARGTYPE](../vs140/celementtraitsbase--outargtype.md)|The data type to use for retrieving elements from the collection class object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CElementTraitsBase::CopyElements](../vs140/celementtraitsbase--copyelements.md)|Call this method to copy elements stored in a collection class object.|  
|[CElementTraitsBase::RelocateElements](../vs140/celementtraitsbase--relocateelements.md)|Call this method to relocate elements stored in a collection class object.|  
  
## Remarks  
 This base class defines methods for copying and relocating elements in a collection class. It is utilized by the classes [CDefaultElementTraits](../vs140/cdefaultelementtraits-class.md), [CStringRefElementTraits](../vs140/cstringrefelementtraits-class.md), and [CStringElementTraitsI](../vs140/cstringelementtraitsi-class.md).  
  
 For more information, see [ATL Collection Classes](../vs140/atl-collection-classes.md).  
  
## Requirements  
 **Header:** atlcoll.h  
  
##  \<a name="celementtraitsbase__copyelements">\</a>  CElementTraitsBase::CopyElements  
 Call this method to copy elements stored in a collection class object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Pointer to the first element that will receive the copied data.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Pointer to the first element to copy.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The number of elements to copy.  
  
### Remarks  
 The source and destination elements should not overlap.  
  
##  \<a name="celementtraitsbase__inargtype">\</a>  CElementTraitsBase::INARGTYPE  
 The data type to use for adding elements to the collection.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
##  \<a name="celementtraitsbase__outargtype">\</a>  CElementTraitsBase::OUTARGTYPE  
 The data type to use for retrieving elements from the collection.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="celementtraitsbase__relocateelements">\</a>  CElementTraitsBase::RelocateElements  
 Call this method to relocate elements stored in a collection class object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Pointer to the first element that will receive the relocated data.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Pointer to the first element to relocate.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The number of elements to relocate.  
  
### Remarks  
 This method calls [memmove](../vs140/memmove--wmemmove.md), which is sufficient for most data types. If the objects being moved contain pointers to their own members, this method will need to be overridden.  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)