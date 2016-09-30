---
title: "IRowsetUpdateImpl::Update"
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
  - "ATL::IRowsetUpdateImpl::Update"
  - "IRowsetUpdateImpl::Update"
  - "IRowsetUpdateImpl.Update"
  - "ATL.IRowsetUpdateImpl.Update"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Update method"
ms.assetid: 9ec6884d-aa9c-4871-a803-c048f162403c
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IRowsetUpdateImpl::Update
Transmits any changes made to the row since the last fetch or update.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] Corresponds to the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter in [IRowsetUpdate::Update](https://msdn.microsoft.com/en-us/library/ms719709.aspx).  
  
 For other parameters, see [IRowsetUpdate::Update](https://msdn.microsoft.com/en-us/library/ms719709.aspx) in the *OLE DB Programmer's Reference*.  
  
## Remarks  
 Changes are transmitted by calling [IRowsetChangeImpl::FlushData](../vs140/irowsetchangeimpl--flushdata.md). The consumer must call [CRowset::Update](../vs140/crowset--update.md) for the changes to take effect. Set *prgRowstatus* to an appropriate value as described in [Row States](https://msdn.microsoft.com/en-us/library/ms722752.aspx) in the *OLE DB Programmer's Reference*.  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [IRowsetUpdateImpl Class](../vs140/irowsetupdateimpl-class.md)