---
title: "CArchive::ReadObject"
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
  - "CArchive::ReadObject"
  - "ReadObject"
  - "CArchive.ReadObject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CArchive class, object input/output"
  - "ReadObject method"
ms.assetid: cb52fddb-dfad-4445-a72b-8f04d98945c6
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CArchive::ReadObject
Reads object data from the archive and constructs an object of the appropriate type.  
  
## Syntax  
  
```  
  
      CObject* ReadObject(  
   const CRuntimeClass* pClass   
);  
```  
  
#### Parameters  
 `pClass`  
 A constant pointer to the [CRuntimeClass](../vs140/cruntimeclass-structure.md) structure that corresponds to the object you expect to read.  
  
## Return Value  
 A [CObject](../vs140/cobject-class.md) pointer that must be safely cast to the correct derived class by using [CObject::IsKindOf](../vs140/cobject--iskindof.md).  
  
## Remarks  
 This function is normally called by the `CArchive` extraction (**>>**) operator overloaded for a [CObject](../vs140/cobject-class.md) pointer. **ReadObject**, in turn, calls the `Serialize` function of the archived class.  
  
 If you supply a nonzero `pClass` parameter, which is obtained by the [RUNTIME_CLASS](../vs140/runtime_class.md) macro, then the function verifies the run-time class of the archived object. This assumes you have used the `IMPLEMENT_SERIAL` macro in the implementation of the class.  
  
## Example  
 See the example for [CArchive::WriteObject](../vs140/carchive--writeobject.md).  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CArchive Class](../vs140/carchive-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CArchive::WriteObject](../vs140/carchive--writeobject.md)   
 [CObject::IsKindOf](../vs140/cobject--iskindof.md)