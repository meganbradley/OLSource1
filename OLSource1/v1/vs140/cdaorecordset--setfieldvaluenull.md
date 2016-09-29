---
title: "CDaoRecordset::SetFieldValueNull"
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
  - "CDaoRecordset.SetFieldValueNull"
  - "CDaoRecordset::SetFieldValueNull"
  - "SetFieldValueNull"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "recordsets, setting field flags and values"
  - "CDaoRecordset class, setting field value to null"
  - "SetFieldValueNull method"
  - "null values, recordset fields"
ms.assetid: aacc76d8-0a1e-4560-9c3d-04934c2f077a
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoRecordset::SetFieldValueNull
Call this member function to set the field to a Null value.  
  
## Syntax  
  
```  
  
      void SetFieldValueNull(  
   int nIndex   
);  
void SetFieldValueNull(  
   LPCTSTR lpszName   
);  
```  
  
#### Parameters  
 `nIndex`  
 The index of the field in the recordset, for lookup by zero-based index.  
  
 `lpszName`  
 The name of the field in the recordset, for lookup by name.  
  
## Remarks  
 C++ **NULL** is not the same as Null, which, in database terminology, means "having no value."  
  
 For related information, see the topics "Field Object" and "Value Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::SetFieldValue](../vs140/cdaorecordset--setfieldvalue.md)