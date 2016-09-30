---
title: "IRowsetImpl::m_bReset"
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
  - "ATL.IRowsetImpl.m_bReset"
  - "IRowsetImpl.m_bReset"
  - "m_bReset"
  - "IRowsetImpl::m_bReset"
  - "ATL::IRowsetImpl::m_bReset"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_bReset"
ms.assetid: d423f9f3-4d48-4d0c-b152-684c81a0b34e
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IRowsetImpl::m_bReset
A bit flag used to determine if the cursor position is defined on the rowset.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 If the consumer calls [GetNextRows](../vs140/irowsetimpl--getnextrows.md) with a negative <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> or *cRows* and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is true, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> moves to the end of the rowset. If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is false, the consumer receives an error code, in conformance with the OLE DB specification. The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> flag gets set to **true** when the rowset is first created and when the consumer calls [IRowsetImpl::RestartPosition](../vs140/irowsetimpl--restartposition.md). It gets set to **false** when you call <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [IRowsetImpl Class](../vs140/irowsetimpl-class.md)