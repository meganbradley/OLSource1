---
title: "IRowsetImpl::GetData"
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
  - "ATL.IRowsetImpl.GetData"
  - "ATL::IRowsetImpl::GetData"
  - "IRowsetImpl::GetData"
  - "IRowsetImpl.GetData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetData method [OLE DB]"
ms.assetid: cb15f1cc-bd25-4b74-93c3-db71aa93829c
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IRowsetImpl::GetData
Retrieves data from the rowset's copy of the row.  
  
## Syntax  
  
```  
  
      STDMETHOD( GetData )(  
   HROW hRow,  
   HACCESSOR hAccessor,  
   void* pDstData   
);  
```  
  
#### Parameters  
 See [IRowset::GetData](https://msdn.microsoft.com/en-us/library/ms716988.aspx) in the *OLE DB Programmer's Reference*.  
  
 Some parameters correspond to *OLE DB Programmer's Reference* parameters of different names, which are described in **IRowset::GetData**:  
  
|OLE DB Template parameters|*OLE DB Programmer's Reference* parameters|  
|--------------------------------|------------------------------------------------|  
|*pDstData*|`pData`|  
  
## Remarks  
 Also handles data conversion using the OLE DB data conversion DLL.  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [IRowsetImpl Class](../vs140/irowsetimpl-class.md)