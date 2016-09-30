---
title: "CAsyncMonikerFile::OnDataAvailable"
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
  - "OnDataAvailable"
  - "CAsyncMonikerFile.OnDataAvailable"
  - "CAsyncMonikerFile::OnDataAvailable"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BSCF enumeration"
  - "OnDataAvailable method"
ms.assetid: 0d349d71-4f5a-443f-8f5d-33a3e17e8863
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAsyncMonikerFile::OnDataAvailable
An asynchronous moniker calls <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to provide data to the client as it becomes available, during asynchronous bind operations.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The cumulative amount (in bytes) of data available since the beginning of the binding. Can be zero, indicating that the amount of data is not relevant to the operation, or that no specific amount became available.  
  
 *bscfFlag*  
 A **BSCF** enumeration value. Can be one or more of the following values:  
  
-   **BSCF_FIRSTDATANOTIFICATION** Identifies the first call to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> for a given bind operation.  
  
-   **BSCF_INTERMEDIATEDATANOTIFICATION** Identifies an intermediary call to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> for a bind operation.  
  
-   **BSCF_LASTDATANOTIFICATION** Identifies the last call to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> for a bind operation.  
  
## Remarks  
 The default implementation of this function does nothing. See the following example for a sample implementation.  
  
## Example  
 [!code[NVC_MFCWinInet#5](../vs140/codesnippet/CPP/casyncmonikerfile--ondataavailable_1.cpp)]  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [CAsyncMonikerFile Class](../vs140/casyncmonikerfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDataPathProperty Class](../vs140/cdatapathproperty-class.md)