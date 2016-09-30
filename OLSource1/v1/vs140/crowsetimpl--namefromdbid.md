---
title: "CRowsetImpl::NameFromDBID"
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
  - "CRowsetImpl.NameFromDBID"
  - "CRowsetImpl::NameFromDBID"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "NameFromDBID method"
ms.assetid: 6aa5b074-90c7-4434-adfd-c64c13e76c78
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRowsetImpl::NameFromDBID
Extracts a string from a **DBID** and copies it to the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> passed in.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *pDBID*  
 [in] A pointer to the **DBID** from which to extract a string.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] A [CComBSTR](../vs140/ccombstr-class.md) reference to place a copy of the **DBID** string.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] **true** if an index **DBID**; **false** if a table **DBID**.  
  
## Return Value  
 A standard <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. Depending on whether the **DBID** is a table or an index (denoted by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>), the method will either return **DB_E_NOINDEX** or **DB_E_NOTABLE**.  
  
## Remarks  
 This method is called by the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> implementations of [ValidateCommandID](../vs140/crowsetimpl--validatecommandid.md) and [GetCommandFromID](../vs140/crowsetimpl--getcommandfromid.md).  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [CRowsetImpl Class](../vs140/crowsetimpl-class.md)