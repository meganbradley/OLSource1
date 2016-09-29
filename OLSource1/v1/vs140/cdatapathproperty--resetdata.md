---
title: "CDataPathProperty::ResetData"
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
  - "CDataPathProperty::ResetData"
  - "ResetData"
  - "CDataPathProperty.ResetData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ResetData method"
ms.assetid: f096a8cf-761f-4e5e-ba75-d81a47bb285f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDataPathProperty::ResetData
Call this function to get `CAsyncMonikerFile::OnDataAvailable` to notify the container that the control properties have changed, and all the information loaded asynchronously is no longer useful.  
  
## Syntax  
  
```  
  
virtual void ResetData( );  
```  
  
## Remarks  
 Opening should be restarted. Derived classes can override this function for different defaults.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [CDataPathProperty Class](../vs140/cdatapathproperty-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CAsyncMonikerFile::OnDataAvailable](../vs140/casyncmonikerfile--ondataavailable.md)   
 [CDataPathProperty::Open](../vs140/cdatapathproperty--open.md)