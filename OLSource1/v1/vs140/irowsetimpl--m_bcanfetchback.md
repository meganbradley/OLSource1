---
title: "IRowsetImpl::m_bCanFetchBack"
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
  - "ATL.IRowsetImpl.m_bCanFetchBack"
  - "ATL::IRowsetImpl::m_bCanFetchBack"
  - "IRowsetImpl.m_bCanFetchBack"
  - "IRowsetImpl::m_bCanFetchBack"
  - "m_bCanFetchBack"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_bCanFetchBack"
ms.assetid: cfa007b0-7ba5-48a3-9d05-9f1916305fb7
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IRowsetImpl::m_bCanFetchBack
Indicates whether a provider supports backward fetching.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Linked to the **DBPROP_CANFETCHBACKWARDS** property in the **DBPROPSET_ROWSET** group. The provider must support **DBPROP_CANFETCHBACKWARDS** for **m_bCanFetchBackwards** to be true.  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [IRowsetImpl Class](../vs140/irowsetimpl-class.md)   
 [IRowsetImpl::m_bCanScrollBack](../vs140/irowsetimpl--m_bcanscrollback.md)