---
title: "CRowsetImpl::GetCommandFromID"
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
  - CRowsetImpl::GetCommandFromID
  - GetCommandFromID
  - CRowsetImpl.GetCommandFromID
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetCommandFromID method
ms.assetid: 9f39cb07-1c40-486f-ba5b-cb4a65fab8a7
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CRowsetImpl::GetCommandFromID
Checks to see if either or both parameters contain string values, and if so, copies the string values to the data members [m_strCommandText](../vs140/crowsetimpl--m_strcommandtext.md) and [m_strIndexText](../vs140/crowsetimpl--m_strindextext.md).  
  
## Syntax  
  
```  
  
      HRESULT CRowsetBaseImpl::GetCommandFromID(  
   DBID* pTableID,  
   DBID* pIndexID   
);  
```  
  
#### Parameters  
 `pTableID`  
 [in] A pointer to the **DBID** representing the Table ID.  
  
 `pIndexID`  
 [in] A pointer to the **DBID** representing the Index ID.  
  
## Return Value  
 A standard `HRESULT`.  
  
## Remarks  
 This method is called through a static upcast by `CRowsetImpl` to populate the data members [m_strCommandText](../vs140/crowsetimpl--m_strcommandtext.md) and [m_strIndexText](../vs140/crowsetimpl--m_strindextext.md). By default, this method checks to see if either or both parameters contain string values. If they contain string values, this method copies the string values to the data members. By placing a method with this signature in your `CRowsetImpl`-derived class, your method will be called instead of the base implementation.  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [CRowsetImpl Class](../vs140/crowsetimpl-class.md)   
 [CRowsetImpl::SetCommandText](../vs140/crowsetimpl--setcommandtext.md)