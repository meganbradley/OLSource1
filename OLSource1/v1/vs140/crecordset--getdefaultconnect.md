---
title: "CRecordset::GetDefaultConnect"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - GetDefaultConnect
  - CRecordset.GetDefaultConnect
  - CRecordset::GetDefaultConnect
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetDefaultConnect method
ms.assetid: 67499451-fe0e-4324-92a9-70e3d813be10
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CRecordset::GetDefaultConnect
Called to get the default connection string.  
  
## Syntax  
  
```  
  
virtual CString GetDefaultConnect( );  
```  
  
## Return Value  
 A `CString` that contains the default connection string.  
  
## Remarks  
 The framework calls this member function to get the default connection string for the data source on which the recordset is based. ClassWizard implements this function for you by identifying the same data source you use in ClassWizard to get information about tables and columns. You will probably find it convenient to rely on this default connection while developing your application. But the default connection may not be appropriate for users of your application. If that is the case, you should reimplement this function, discarding ClassWizard's version. For more information about connection strings, see the article [Data Source (ODBC)](../vs140/data-source--odbc-.md).  
  
## Requirements  
 **Header:** afxdb.h  
  
## See Also  
 [CRecordset Class](../vs140/crecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)