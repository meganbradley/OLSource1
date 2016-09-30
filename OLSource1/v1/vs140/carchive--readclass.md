---
title: "CArchive::ReadClass"
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
  - "ReadClass"
  - "CArchive.ReadClass"
  - "CArchive::ReadClass"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CArchive class, object input/output"
  - "ReadClass method"
ms.assetid: 9ebd026f-086d-4aa4-82b0-b201e0b03246
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CArchive::ReadClass
Call this member function to read a reference to a class previously stored with [WriteClass](../vs140/carchive--writeclass.md).  
  
## Syntax  
  
```  
  
      CRuntimeClass* ReadClass(   
   const CRuntimeClass* pClassRefRequested = NULL,   
   UINT* pSchema = NULL,   
   DWORD* pObTag = NULL    
);  
```  
  
#### Parameters  
 `pClassRefRequested`  
 A pointer to the [CRuntimeClass](../vs140/cruntimeclass-structure.md) structure that corresponds to the class reference requested. Can be **NULL**.  
  
 `pSchema`  
 A pointer to a schema of the run-time class previously stored.  
  
 `pObTag`  
 A number that refers to an object's unique tag. Used internally by the implementation of [ReadObject](../vs140/carchive--readobject.md). Exposed for advanced programming only; `pObTag` normally should be **NULL**.  
  
## Return Value  
 A pointer to the [CRuntimeClass](../vs140/cruntimeclass-structure.md) structure.  
  
## Remarks  
 If `pClassRefRequested` is not **NULL**, `ReadClass` verifies that the archived class information is compatible with your runtime class. If it is not compatible, `ReadClass` will throw a [CArchiveException](../vs140/carchiveexception-class.md).  
  
 Your runtime class must use [DECLARE_SERIAL](../vs140/declare_serial.md) and [IMPLEMENT_SERIAL](../vs140/implement_serial.md); otherwise, `ReadClass` will throw a [CNotSupportedException](../vs140/cnotsupportedexception-class.md).  
  
 If `pSchema` is **NULL**, the schema of the stored class can be retrieved by calling [CArchive::GetObjectSchema](../vs140/carchive--getobjectschema.md); otherwise, **\***`pSchema` will contain the schema of the run-time class that was previously stored.  
  
 You can use [SerializeClass](../vs140/carchive--serializeclass.md) instead of `ReadClass`, which handles both reading and writing of the class reference.  
  
## Example  
 See the example for [CArchive::WriteClass](../vs140/carchive--writeclass.md).  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CArchive Class](../vs140/carchive-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CArchive::WriteClass](../vs140/carchive--writeclass.md)   
 [CArchive::GetObjectSchema](../vs140/carchive--getobjectschema.md)   
 [CArchive::SetObjectSchema](../vs140/carchive--setobjectschema.md)   
 [CArchiveException Class](../vs140/carchiveexception-class.md)   
 [CNotSupportedException Class](../vs140/cnotsupportedexception-class.md)   
 [CArchive::SerializeClass](../vs140/carchive--serializeclass.md)