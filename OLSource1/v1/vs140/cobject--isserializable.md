---
title: "CObject::IsSerializable"
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
  - "CObject::IsSerializable"
  - "CObject.IsSerializable"
  - "IsSerializable"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsSerializable method"
  - "CObject class, serialization"
ms.assetid: d8db85a8-4586-4578-97cf-d005370180e8
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CObject::IsSerializable
Tests whether this object is eligible for serialization.  
  
## Syntax  
  
```  
  
BOOL IsSerializable( ) const;  
```  
  
## Return Value  
 Nonzero if this object can be serialized; otherwise 0.  
  
## Remarks  
 For a class to be serializable, its declaration must contain the [DECLARE_SERIAL](../vs140/declare_serial.md) macro, and the implementation must contain the [IMPLEMENT_SERIAL](../vs140/implement_serial.md) macro.  
  
> [!NOTE]
>  Do not override this function.  
  
## Example  
 See [CObList::CObList](../vs140/coblist--coblist.md) for a listing of the `CAge` class used in all `CObject` examples.  
  
 [!code[NVC_MFCCObjectSample#12](../vs140/codesnippet/CPP/cobject--isserializable_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CObject Class](../vs140/cobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObject::Serialize](../vs140/cobject--serialize.md)