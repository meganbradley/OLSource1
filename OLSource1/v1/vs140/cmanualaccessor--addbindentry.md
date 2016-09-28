---
title: "CManualAccessor::AddBindEntry"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "ATL::CManualAccessor::AddBindEntry"
  - "ATL.CManualAccessor.AddBindEntry"
  - "CManualAccessor::AddBindEntry"
  - "AddBindEntry"
  - "CManualAccessor.AddBindEntry"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddBindEntry method"
ms.assetid: 8556dda9-dda1-4f67-96bc-6031e6c6a271
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CManualAccessor::AddBindEntry
Adds a bind entry to the output columns.  
  
## Syntax  
  
```  
  
      void AddBindEntry(  
   DBORDINAL nOrdinal,  
   DBTYPE wType,  
   DBLENGTH nColumnSize,  
   void* pData,  
   void* pLength = NULL,  
   void* pStatus = NULL   
) throw ( );  
```  
  
#### Parameters  
 See [DBBINDING](https://msdn.microsoft.com/en-us/library/ms716845.aspx) in the *OLE DB Programmer's Reference*.  
  
 `nOrdinal`  
 [in] Column number.  
  
 `wType`  
 [in] Data type.  
  
 `nColumnSize`  
 [in] Column size in bytes.  
  
 `pData`  
 [in] A pointer to the column data stored in the buffer.  
  
 `pLength`  
 [in] A pointer to the field length, if required.  
  
 `pStatus`  
 [in] A pointer to the variable to be bound to the column status, if required.  
  
## Remarks  
 To use this function, you must first call [CreateAccessor](../vs140/cmanualaccessor--createaccessor.md). You cannot add more entries than the number of columns specified in `CreateAccessor`.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [CManualAccessor Class](../vs140/cmanualaccessor-class.md)   
 [DBViewer sample](../vs140/visual-c---samples.md)