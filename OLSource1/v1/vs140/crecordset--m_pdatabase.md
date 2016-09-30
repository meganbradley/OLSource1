---
title: "CRecordset::m_pDatabase"
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
  - "m_pDatabase"
  - "CRecordset::m_pDatabase"
  - "CRecordset.m_pDatabase"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_pDatabase"
ms.assetid: bb4a5049-6be0-47bf-b430-5a316a597b92
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRecordset::m_pDatabase
Contains a pointer to the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> object through which the recordset is connected to a data source.  
  
## Remarks  
 This variable is set in two ways. Typically, you pass a pointer to an already connected <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object when you construct the recordset object. If you pass **NULL** instead, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> creates a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object for you and connects it. In either case, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> stores the pointer in this variable.  
  
 Normally you will not directly need to use the pointer stored in **m_pDatabase**. If you write your own extensions to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, however, you might need to use the pointer. For example, you might need the pointer if you throw your own <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>s. Or you might need it if you need to do something using the same <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object, such as running transactions, setting timeouts, or calling the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> member function of class <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to execute SQL statements directly.  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CRecordset Class](../vs140/crecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)