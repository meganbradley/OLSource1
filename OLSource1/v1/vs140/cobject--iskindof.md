---
title: "CObject::IsKindOf"
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
  - "CObject::IsKindOf"
  - "CObject.IsKindOf"
  - "IsKindOf"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsKindOf method"
  - "CObject class, miscellaneous"
ms.assetid: 7c87c748-b7e0-4c6d-9694-6035e62fdfd6
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CObject::IsKindOf
Tests this object's relationship to a given class.  
  
## Syntax  
  
```  
  
      BOOL IsKindOf(  
   const CRuntimeClass* pClass   
) const;  
```  
  
#### Parameters  
 `pClass`  
 A pointer to a [CRuntimeClass](../vs140/cruntimeclass-structure.md) structure associated with your `CObject`-derived class.  
  
## Return Value  
 Nonzero if the object corresponds to the class; otherwise 0.  
  
## Remarks  
 This function tests `pClass` to see if (1) it is an object of the specified class or (2) it is an object of a class derived from the specified class. This function works only for classes declared with the [DECLARE_DYNAMIC](../vs140/declare_dynamic.md), [DECLARE_DYNCREATE](../vs140/declare_dyncreate.md), or [DECLARE_SERIAL](../vs140/declare_serial.md) macro.  
  
 Do not use this function extensively because it defeats the C++ polymorphism feature. Use virtual functions instead.  
  
## Example  
 See [CObList::CObList](../vs140/coblist--coblist.md) for a listing of the `CAge` class used in all `CObject` examples.  
  
 [!code[NVC_MFCCObjectSample#11](../vs140/codesnippet/CPP/cobject--iskindof_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CObject Class](../vs140/cobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObject::GetRuntimeClass](../vs140/cobject--getruntimeclass.md)   
 [RUNTIME_CLASS](../vs140/runtime_class.md)   
 [Accessing Run-Time Class Information](../vs140/accessing-run-time-class-information.md)