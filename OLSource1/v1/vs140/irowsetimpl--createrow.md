---
title: "IRowsetImpl::CreateRow"
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
  - "IRowsetImpl.CreateRow"
  - "ATL.IRowsetImpl.CreateRow"
  - "ATL::IRowsetImpl::CreateRow"
  - "CreateRow"
  - "IRowsetImpl::CreateRow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateRow method"
ms.assetid: b01c430c-9484-4fef-a6cf-a2e8d9d99130
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IRowsetImpl::CreateRow
A helper method called by [GetNextRows](../vs140/irowsetimpl--getnextrows.md) to allocate a new **HROW**.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *lRowsOffset*  
 Cursor position of the row being created.  
  
 *cRowsObtained*  
 A reference passed back to the user indicating the number of rows created.  
  
 *rgRows*  
 An array of **HROW**s returned to the caller with the newly created row handles.  
  
## Remarks  
 If the row exists, this method calls [AddRefRows](../vs140/irowsetimpl--addrefrows.md) and returns. Otherwise, it allocates a new instance of the RowClass template variable and adds it to [m_rgRowHandles](../vs140/irowsetimpl--m_rgrowhandles.md).  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [IRowsetImpl Class](../vs140/irowsetimpl-class.md)