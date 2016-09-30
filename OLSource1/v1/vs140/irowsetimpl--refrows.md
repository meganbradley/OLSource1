---
title: "IRowsetImpl::RefRows"
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
  - "ATL::IRowsetImpl::RefRows"
  - "ATL.IRowsetImpl.RefRows"
  - "IRowsetImpl.RefRows"
  - "RefRows"
  - "IRowsetImpl::RefRows"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RefRows method"
ms.assetid: 1c048a2a-65dc-4bba-9c81-a23c0dc249c8
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IRowsetImpl::RefRows
Called by [AddRefRows](../vs140/irowsetimpl--addrefrows.md) and [ReleaseRows](../vs140/irowsetimpl--releaserows.md) to either increment or release a reference count to an existing row handle.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 See [IRowset::AddRefRows](https://msdn.microsoft.com/en-us/library/ms719619.aspx) in the *OLE DB Programmer's Reference*.  
  
## Return Value  
 A standard <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> value.  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [IRowsetImpl Class](../vs140/irowsetimpl-class.md)   
 [CSimpleRow Class](../vs140/csimplerow-class.md)