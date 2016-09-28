---
title: "CDaoRecordset::GetEditMode"
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
  - "CDaoRecordset::GetEditMode"
  - "CDaoRecordset.GetEditMode"
  - "GetEditMode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "recordsets, getting information"
  - "CDaoRecordset class, getting edit mode"
  - "GetEditMode method"
ms.assetid: d7e3bbe9-82e3-427f-bc98-c3037de4a0dc
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoRecordset::GetEditMode
Call this member function to determine the state of editing, which is one of the following values:  
  
## Syntax  
  
```  
  
short GetEditMode( );  
  
```  
  
## Return Value  
 Returns a value that indicates the state of editing for the current record.  
  
## Remarks  
  
|Value|Description|  
|-----------|-----------------|  
|**dbEditNone**|No editing operation is in progress.|  
|**dbEditInProgress**|**Edit** has been called.|  
|**dbEditAdd**|`AddNew` has been called.|  
  
 For related information, see the topic "EditMode Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)