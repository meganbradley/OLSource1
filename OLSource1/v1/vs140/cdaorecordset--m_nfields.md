---
title: "CDaoRecordset::m_nFields"
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
  - "m_nFields"
  - "CDaoRecordset::m_nFields"
  - "CDaoRecordset.m_nFields"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_nFields"
  - "recordsets, number of fields"
  - "CDaoRecordset class, number of fields"
ms.assetid: 86be62c3-4435-4ced-a96b-026c8b4539f9
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoRecordset::m_nFields
Contains the number of field data members in the recordset class and the number of columns selected by the recordset from the data source.  
  
## Remarks  
 The constructor for the recordset class must initialize `m_nFields` with the correct number of statically bound fields. ClassWizard writes this initialization for you when you use it to declare your recordset class. You can also write it manually.  
  
 The framework uses this number to manage interaction between the field data members and the corresponding columns of the current record on the data source.  
  
> [!NOTE]
>  This number must correspond to the number of output columns registered in `DoFieldExchange` after a call to `SetFieldType` with the parameter **CDaoFieldExchange::outputColumn**.  
  
 You can bind columns dynamically by way of `CDaoRecordset::GetFieldValue` and `CDaoRecordset::SetFieldValue`. If you do so, you do not need to increment the count in `m_nFields` to reflect the number of DFX function calls in your `DoFieldExchange` member function.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::SetFieldValue](../vs140/cdaorecordset--setfieldvalue.md)   
 [CDaoRecordset::GetFieldValue](../vs140/cdaorecordset--getfieldvalue.md)