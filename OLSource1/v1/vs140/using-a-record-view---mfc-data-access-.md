---
title: "Using a Record View  (MFC Data Access)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "record views, customizing default code"
ms.assetid: 91f2828f-0666-4273-ae28-e4703fd98521
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using a Record View  (MFC Data Access)
This topic explains how you might commonly customize the default code for record views that the wizard writes for you. Typically, you want to constrain the record selection with a [filter](../vs140/recordset--filtering-records--odbc-.md) or [parameters](../vs140/recordset--parameterizing-a-recordset--odbc-.md), perhaps [sort](../vs140/recordset--sorting-records--odbc-.md) the records, customize the SQL statement.  
  
 This information applies to both [CRecordView](../vs140/crecordview-class.md) (ODBC) and [CDaoRecordView](../vs140/cdaorecordview-class.md) (DAO).  
  
 Using <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is much the same as using [CFormView](../vs140/cformview-class.md). The basic approach is to use the record view to display and perhaps update the records of a single recordset. Beyond that, you might want to use other recordsets as well, as discussed in [Record Views: Filling a List Box from a Second Recordset](../vs140/filling-a-list-box-from-a-second-recordset---mfc-data-access-.md).  
  
## See Also  
 [Record Views  (MFC Data Access)](../vs140/record-views---mfc-data-access-.md)   
 [ODBC Driver List](../vs140/odbc-driver-list.md)