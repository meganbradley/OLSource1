---
title: "CDaoRecordset::GetDefaultSQL"
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
  - "CDaoRecordset.GetDefaultSQL"
  - "CDaoRecordset::GetDefaultSQL"
  - "GetDefaultSQL"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "recordsets, getting SQL"
  - "GetDefaultSQL method"
  - "CDaoRecordset class, getting default SQL"
ms.assetid: 0d59f7fe-9e6a-4a3b-a7ad-0ec765ba0740
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoRecordset::GetDefaultSQL
The framework calls this member function to get the default SQL statement on which the recordset is based.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> that contains the default SQL statement.  
  
## Remarks  
 This might be a table name or a SQL **SELECT** statement.  
  
 You indirectly define the default SQL statement by declaring your recordset class with ClassWizard, and ClassWizard performs this task for you.  
  
 If you pass a null SQL string to [Open](../vs140/cdaorecordset--open.md), then this function is called to determine the table name or SQL for your recordset.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::GetDefaultDBName](../vs140/cdaorecordset--getdefaultdbname.md)   
 [CDaoRecordset::GetName](../vs140/cdaorecordset--getname.md)   
 [CDaoRecordset::GetSQL](../vs140/cdaorecordset--getsql.md)   
 [CDaoRecordset::GetType](../vs140/cdaorecordset--gettype.md)