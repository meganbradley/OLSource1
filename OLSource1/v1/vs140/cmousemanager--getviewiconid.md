---
title: "CMouseManager::GetViewIconId"
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
  - "CMouseManager::GetViewIconId"
  - "CMouseManager.GetViewIconId"
  - "GetViewIconId"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetViewIconId method"
ms.assetid: a2aafb89-ee87-4d08-833b-8c1b2ba7c283
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMouseManager::GetViewIconId
Retrieves the icon associated with a view ID.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The view ID.  
  
## Return Value  
 An icon resource identifier if successful; otherwise 0.  
  
## Remarks  
 This method will fail if the view is not first registered by using [CMouseManager::AddView](../vs140/cmousemanager--addview.md).  
  
## Requirements  
 **Header:** afxmousemanager.h  
  
## See Also  
 [CMouseManager Class](../vs140/cmousemanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMouseManager::AddView](../vs140/cmousemanager--addview.md)