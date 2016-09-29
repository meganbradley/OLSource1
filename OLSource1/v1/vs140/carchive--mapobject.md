---
title: "CArchive::MapObject"
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
  - "MapObject"
  - "CArchive.MapObject"
  - "CArchive::MapObject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MapObject method"
ms.assetid: e314ae56-6fb3-443e-a9db-21b806be98ef
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CArchive::MapObject
Call this member function to place objects in the map that are not really serialized to the file, but that are available for subobjects to reference.  
  
## Syntax  
  
```  
  
      void MapObject(  
   const CObject* pOb   
);  
```  
  
#### Parameters  
 `pOb`  
 A constant pointer to the object being stored.  
  
## Remarks  
 For example, you might not serialize a document, but you would serialize the items that are part of the document. By calling `MapObject`, you allow those items, or subobjects, to reference the document. Also, serialized subitems can serialize their `m_pDocument` back pointer.  
  
 You can call `MapObject` when you store to and load from the `CArchive` object. `MapObject` adds the specified object to the internal data structures maintained by the `CArchive` object during serialization and deserialization, but unlike [ReadObject](../vs140/carchive--readobject.md) and [WriteObject](../vs140/carchive--writeobject.md)**,** it does not call serialize on the object.  
  
## Example  
 [!code[NVC_MFCSerialization#18](../vs140/codesnippet/CPP/carchive--mapobject_1.h)]  
  
 [!code[NVC_MFCSerialization#19](../vs140/codesnippet/CPP/carchive--mapobject_2.cpp)]  
  
 [!code[NVC_MFCSerialization#20](../vs140/codesnippet/CPP/carchive--mapobject_3.h)]  
  
 [!code[NVC_MFCSerialization#21](../vs140/codesnippet/CPP/carchive--mapobject_4.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CArchive Class](../vs140/carchive-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CArchive::ReadObject](../vs140/carchive--readobject.md)   
 [CArchive::WriteObject](../vs140/carchive--writeobject.md)