---
title: "IRowsetImpl::m_bCanScrollBack"
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
  - "IRowsetImpl::m_bCanScrollBack"
  - "ATL::IRowsetImpl::m_bCanScrollBack"
  - "IRowsetImpl.m_bCanScrollBack"
  - "ATL.IRowsetImpl.m_bCanScrollBack"
  - "m_bCanScrollBack"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_bCanScrollBack"
ms.assetid: 69de3179-bf56-415e-935f-e98bcb34debe
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IRowsetImpl::m_bCanScrollBack
Indicates whether a provider can have its cursor scroll backwards.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Linked to the **DBPROP_CANSCROLLBACKWARDS** property in the **DBPROPSET_ROWSET** group. The provider must support **DBPROP_CANSCROLLBACKWARDS** for **m_bCanFetchBackwards** to be true.  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [IRowsetImpl Class](../vs140/irowsetimpl-class.md)   
 [IRowsetImpl::m_bCanFetchBack](../vs140/irowsetimpl--m_bcanfetchback.md)