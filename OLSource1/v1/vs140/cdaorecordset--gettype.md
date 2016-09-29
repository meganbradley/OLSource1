---
title: "CDaoRecordset::GetType"
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
  - "CDaoRecordset.GetType"
  - "GetType"
  - "CDaoRecordset::GetType"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "recordsets, getting information"
  - "GetType method"
  - "CDaoRecordset class, getting recordset types"
ms.assetid: 3d4c9db2-d0be-4af3-9909-f4bd13fbcbd7
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoRecordset::GetType
Call this member function after opening the recordset to determine the type of the recordset object.  
  
## Syntax  
  
```  
  
short GetType( );  
  
```  
  
## Return Value  
 One of the following values that indicates the type of a recordset:  
  
-   **dbOpenTable** Table-type recordset  
  
-   **dbOpenDynaset** Dynaset-type recordset  
  
-   **dbOpenSnapshot** Snapshot-type recordset  
  
## Remarks  
 For related information, see the topic "Type Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::GetDefaultDBName](../vs140/cdaorecordset--getdefaultdbname.md)   
 [CDaoRecordset::GetDefaultSQL](../vs140/cdaorecordset--getdefaultsql.md)   
 [CDaoRecordset::GetName](../vs140/cdaorecordset--getname.md)   
 [CDaoRecordset::GetSQL](../vs140/cdaorecordset--getsql.md)