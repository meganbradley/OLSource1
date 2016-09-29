---
title: "CFieldExchange::IsFieldType"
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
  - "CFieldExchange.IsFieldType"
  - "IsFieldType"
  - "CFieldExchange::IsFieldType"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsFieldType method"
ms.assetid: d63c8fb9-2b6b-4ebe-b92c-e78c4df3c9d3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFieldExchange::IsFieldType
If you write your own RFX function, call `IsFieldType` at the beginning of your function to determine whether the current operation can be performed on a particular field or parameter data member type (a **CFieldExchange::outputColumn**, **CFieldExchange::inputParam**, **CFieldExchange::param**, **CFieldExchange::outputParam**, or **CFieldExchange::inoutParam**).  
  
## Syntax  
  
```  
  
      BOOL IsFieldType(  
   UINT* pnField   
);  
```  
  
#### Parameters  
 *pnField*  
 The sequential number of the field or parameter data member is returned in this parameter. This number corresponds to the data member's order in the [CRecordset::DoFieldExchange](../vs140/crecordset--dofieldexchange.md) or [CRecordset::DoBulkFieldExchange](../vs140/crecordset--dobulkfieldexchange.md) function.  
  
## Return Value  
 Nonzero if the current operation can be performed on the current field or parameter type.  
  
## Remarks  
 Follow the model of the existing RFX functions.  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CFieldExchange Class](../vs140/cfieldexchange-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)