---
title: "CRecordset::Close"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CRecordset.Close
  - CRecordset::Close
dev_langs: 
  - C++
helpviewer_keywords: 
  - Close method
ms.assetid: 6534443b-8816-447d-ae36-76f11b6016ee
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CRecordset::Close
Closes the recordset.  
  
## Syntax  
  
```  
  
virtual void Close( );  
```  
  
## Remarks  
 The ODBC **HSTMT** and all memory the framework allocated for the recordset are deallocated. Usually after calling **Close**, you delete the C++ recordset object if it was allocated with **new**.  
  
 You can call **Open** again after calling **Close**. This lets you reuse the recordset object. The alternative is to call **Requery**.  
  
## Example  
 [!code[NVC_MFCDatabase#17](../vs140/codesnippet/CPP/crecordset--close_1.cpp)]
  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CRecordset Class](../vs140/crecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRecordset::CRecordset](../vs140/crecordset--crecordset.md)   
 [CRecordset::Open](../vs140/crecordset--open.md)   
 [CRecordset::Requery](../vs140/crecordset--requery.md)