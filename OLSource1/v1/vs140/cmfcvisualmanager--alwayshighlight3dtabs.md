---
title: "CMFCVisualManager::AlwaysHighlight3DTabs"
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
  - "AlwaysHighlight3DTabs"
  - "CMFCVisualManager::AlwaysHighlight3DTabs"
  - "CMFCVisualManager.AlwaysHighlight3DTabs"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AlwaysHighlight3DTabs method"
ms.assetid: fac92223-d63e-43db-aece-a3ba0da30480
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::AlwaysHighlight3DTabs
The framework calls this method to determine whether 3D tabs should always be highlighted in the application.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if 3D tabs should be highlighted.  
  
## Remarks  
 Override this function in a derived visual manager and return <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if 3D tabs should always be highlighted. The default implementation of this method returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)