---
title: "CRowset::UpdateAll"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - CRowset::UpdateAll
  - ATL.CRowset.UpdateAll
  - CRowset<TAccessor>.UpdateAll
  - ATL.CRowset<TAccessor>.UpdateAll
  - UpdateAll
  - CRowset.UpdateAll
  - ATL::CRowset<TAccessor>::UpdateAll
  - CRowset<TAccessor>::UpdateAll
  - ATL::CRowset::UpdateAll
dev_langs: 
  - C++
helpviewer_keywords: 
  - UpdateAll method
ms.assetid: e5b26c0a-40fc-4c91-a293-5084951788e6
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CRowset::UpdateAll
Transmits any pending changes made to all rows since the last fetch or **Update** call on it.  
  
## Syntax  
  
```  
  
      HRESULT UpdateAll(   
   DBCOUNTITEM* pcRows = NULL,   
   HROW** pphRow = NULL,   
   DBROWSTATUS** ppStatus = NULL    
) throw( );  
```  
  
#### Parameters  
 `pcRows`  
 [out] A pointer to the location where `UpdateAll` returns the number of rows it attempted to update, if required.  
  
 `pphRow`  
 [out] A pointer to memory in which `UpdateAll` returns the handle of the row it attempted to update. No handle is returned if `pphRow` is null.  
  
 `ppStatus`  
 [out] A pointer to the location where **Update** returns the row status value. No status is returned if `ppStatus` is null.  
  
## Remarks  
 Transmits any pending changes made to all rows since those rows were last fetched or updated using [Update](../vs140/crowset--update.md) or `UpdateAll`. `UpdateAll` will update every row that has been modified, regardless of whether you still have the handle for them (see `pphRow`) or not.  
  
 For example, if you used **Insert** to insert five rows in a rowset, you could either call **Update** five times or call `UpdateAll` once to update them all.  
  
 This method requires the optional interface `IRowsetUpdate`, which might not be supported on all providers; if this is the case, the method returns **E_NOINTERFACE**. You must also set **DBPROP_IRowsetUpdate** to `VARIANT_TRUE` before calling **Open** on the table or command containing the rowset.  
  
## Return Value  
 A standard `HRESULT`.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [CRowset Class](../vs140/crowset-class.md)   
 [IRowsetUpdate::Update](https://msdn.microsoft.com/en-us/library/ms719709.aspx)   
 [CRowset::SetData](../vs140/crowset--setdata.md)   
 [CRowset::Update](../vs140/crowset--update.md)