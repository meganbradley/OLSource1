---
title: "IRowsetUpdateImpl::IsUpdateAllowed"
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
  - "IRowsetUpdateImpl::IsUpdateAllowed"
  - "IRowsetUpdateImpl.IsUpdateAllowed"
  - "IsUpdateAllowed"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsUpdateAllowed method"
ms.assetid: d6daf3b3-a8e0-4275-a67d-897dea01e297
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IRowsetUpdateImpl::IsUpdateAllowed
Override this method to check for security, integrity, and so on before updates.  
  
## Syntax  
  
```  
  
      HRESULT IsUpdateAllowed(  
   DBPENDINGSTATUS /* [in] *//* status */,  
   HROW /* [in] *//* hRowUpdate */,  
   DBROWSTATUS* /* [out] *//* pRowStatus */  
);  
```  
  
#### Parameters  
 *status*  
 [in] The status of pending operations on the rows.  
  
 *hRowUpdate*  
 [in] Handle for the rows the user wants to update.  
  
 *pRowStatus*  
 [out] The status returned to the user.  
  
## Remarks  
 If you determine that an update should be allowed, returns `S_OK`; otherwise returns **E_FAIL**. If you allow an update, you also need to set the **DBROWSTATUS** in [IRowsetUpdateImpl::Update](../vs140/irowsetupdateimpl--update.md) to an appropriate [row state](https://msdn.microsoft.com/en-us/library/ms722752.aspx).  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [IRowsetUpdateImpl Class](../vs140/irowsetupdateimpl-class.md)