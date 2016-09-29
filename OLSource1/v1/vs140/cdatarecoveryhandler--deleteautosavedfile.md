---
title: "CDataRecoveryHandler::DeleteAutosavedFile"
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
  - "CDataRecoveryHandler::DeleteAutosavedFile"
  - "DeleteAutosavedFile"
  - "CDataRecoveryHandler.DeleteAutosavedFile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DeleteAutosavedFile method"
ms.assetid: eb5c233e-238b-410b-b5ba-034a7e1aed43
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDataRecoveryHandler::DeleteAutosavedFile
Deletes the specified autosaved file.  
  
## Syntax  
  
```  
virtual BOOL DeleteAutosavedFile(  
   const CString &strAutosavedFile  
);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] `strAutosavedFile`|A string that contains the autosaved file name.|  
  
## Return Value  
 The default implementation always return `TRUE`.  
  
## Remarks  
 If this method cannot delete the autosaved file, it saves the name of the file in a list. The destructor for the `CDataRecoveryHandler` tries to delete each autosaved file specified in that list.  
  
## Requirements  
 **Header:** afxdatarecovery.h  
  
## See Also  
 [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDataRecoveryHandler::DeleteAllAutosavedFiles](../vs140/cdatarecoveryhandler--deleteallautosavedfiles.md)