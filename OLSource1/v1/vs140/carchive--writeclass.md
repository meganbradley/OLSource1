---
title: "CArchive::WriteClass"
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
  - "CArchive.WriteClass"
  - "CArchive::WriteClass"
  - "WriteClass"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WriteClass method"
ms.assetid: 63bbf65a-51cf-4da3-9e7a-bd5b60d73403
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CArchive::WriteClass
Use `WriteClass` to store the version and class information of a base class during serialization of the derived class.  
  
## Syntax  
  
```  
  
      void WriteClass(  
   const CRuntimeClass* pClassRef   
);  
```  
  
#### Parameters  
 `pClassRef`  
 A pointer to the [CRuntimeClass](../vs140/cruntimeclass-structure.md) structure that corresponds to the class reference requested.  
  
## Remarks  
 `WriteClass` writes a reference to the [CRuntimeClass](../vs140/cruntimeclass-structure.md) for the base class to the `CArchive`. Use [CArchive::ReadClass](../vs140/carchive--readclass.md) to retrieve the reference.  
  
 `WriteClass` verifies that the archived class information is compatible with your runtime class. If it is not compatible, `WriteClass` will throw a [CArchiveException](../vs140/carchiveexception-class.md).  
  
 Your runtime class must use [DECLARE_SERIAL](../vs140/declare_serial.md) and [IMPLEMENT_SERIAL](../vs140/implement_serial.md); otherwise, `WriteClass` will throw a [CNotSupportedException](../vs140/cnotsupportedexception-class.md).  
  
 You can use [SerializeClass](../vs140/carchive--serializeclass.md) instead of `WriteClass`, which handles both reading and writing of the class reference.  
  
## Example  
 [!code[NVC_MFCSerialization#28](../vs140/codesnippet/CPP/carchive--writeclass_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CArchive Class](../vs140/carchive-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CArchive::ReadClass](../vs140/carchive--readclass.md)   
 [CArchive::GetObjectSchema](../vs140/carchive--getobjectschema.md)   
 [CArchive::SetObjectSchema](../vs140/carchive--setobjectschema.md)   
 [CArchive::SerializeClass](../vs140/carchive--serializeclass.md)   
 [CArchiveException Class](../vs140/carchiveexception-class.md)   
 [CNotSupportedException Class](../vs140/cnotsupportedexception-class.md)   
 [CObList::CObList](../vs140/coblist--coblist.md)