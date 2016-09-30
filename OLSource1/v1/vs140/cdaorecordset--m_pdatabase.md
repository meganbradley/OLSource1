---
title: "CDaoRecordset::m_pDatabase"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CDaoRecordset::m_pDatabase"
  - "m_pDatabase"
  - "CDaoRecordset.m_pDatabase"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_pDatabase"
  - "recordsets, database object"
  - "CDaoRecordset class, database objects"
ms.assetid: 1531cec9-7dcf-4900-acad-edac310d22ae
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoRecordset::m_pDatabase
Contains a pointer to the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> object through which the recordset is connected to a data source.  
  
## Remarks  
 This variable is set in two ways. Typically, you pass a pointer to an already open <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object when you construct the recordset object. If you pass **NULL** instead, **CDaoRecordset** creates a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object for you and opens it. In either case, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> stores the pointer in this variable.  
  
 Normally you will not directly need to use the pointer stored in **m_pDatabase**. If you write your own extensions to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, however, you might need to use the pointer. For example, you might need the pointer if you throw your own <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>(s).  
  
 For related information, see the topic "Database Object" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::m_pDAORecordset](../vs140/cdaorecordset--m_pdaorecordset.md)