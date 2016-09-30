---
title: "IRowsetUpdateImpl::Undo"
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
  - "ATL.IRowsetUpdateImpl.Undo"
  - "ATL::IRowsetUpdateImpl::Undo"
  - "IRowsetUpdateImpl::Undo"
  - "IRowsetUpdateImpl.Undo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Undo method"
ms.assetid: f3dc7764-050c-4322-9b2f-9ca772a0fb88
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IRowsetUpdateImpl::Undo
Undoes any changes to the row since the last fetch or update.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] Corresponds to the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter in [IRowsetUpdate::Undo](https://msdn.microsoft.com/en-us/library/ms719655.aspx).  
  
 *pcRowsUndone*  
 [out] Corresponds to the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter in [IRowsetUpdate::Undo](https://msdn.microsoft.com/en-us/library/ms719655.aspx).  
  
 *prgRowsUndone*  
 [in] Corresponds to the *prgRows* parameter in [IRowsetUpdate::Undo](https://msdn.microsoft.com/en-us/library/ms719655.aspx).  
  
 For other parameters, see [IRowsetUpdate::Undo](https://msdn.microsoft.com/en-us/library/ms719655.aspx) in the *OLE DB Programmer's Reference*.  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [IRowsetUpdateImpl Class](../vs140/irowsetupdateimpl-class.md)