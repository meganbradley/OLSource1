---
title: "CAutoVectorPtrElementTraits Class"
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
  - "ATL::CAutoVectorPtrElementTraits<T>"
  - "ATL.CAutoVectorPtrElementTraits"
  - "ATL.CAutoVectorPtrElementTraits<T>"
  - "ATL::CAutoVectorPtrElementTraits"
  - "CAutoVectorPtrElementTraits"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CAutoVectorPtrElementTraits class"
ms.assetid: 16b81a56-55fb-46ca-b376-66a1884231a6
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAutoVectorPtrElementTraits Class
This class provides methods, static functions, and typedefs useful when creating collections of smart pointers using vector new and delete operators.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The pointer type.  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|[CAutoVectorPtrElementTraits::INARGTYPE](../vs140/cautovectorptrelementtraits--inargtype.md)|The data type to use for adding elements to the collection class object.|  
|[CAutoVectorPtrElementTraits::OUTARGTYPE](../vs140/cautovectorptrelementtraits--outargtype.md)|The data type to use for retrieving elements from the collection class object.|  
  
## Remarks  
 This class provides methods, static functions, and typedefs for aiding the creation of collection class objects containing smart pointers. Unlike [CAutoPtrElementTraits](../vs140/cautoptrelementtraits-class.md), this class uses vector new and delete operators.  
  
## Inheritance Hierarchy  
 [CDefaultCompareTraits](../vs140/cdefaultcomparetraits-class.md)  
  
 [CDefaultHashTraits](../vs140/cdefaulthashtraits-class.md)  
  
 [CElementTraitsBase](../vs140/celementtraitsbase-class.md)  
  
 [CDefaultElementTraits](../vs140/cdefaultelementtraits-class.md)  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlcoll.h  
  
##  \<a name="cautovectorptrelementtraits__inargtype">\</a>  CAutoVectorPtrElementTraits::INARGTYPE  
 The data type to use for adding elements to the collection class object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="cautovectorptrelementtraits__outargtype">\</a>  CAutoVectorPtrElementTraits::OUTARGTYPE  
 The data type to use for retrieving elements from the collection class object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [CDefaultElementTraits Class](../vs140/cdefaultelementtraits-class.md)   
 [CAutoVectorPtr Class](../vs140/cautovectorptr-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)