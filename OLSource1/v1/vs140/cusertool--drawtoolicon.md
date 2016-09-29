---
title: "CUserTool::DrawToolIcon"
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
  - "CUserTool::DrawToolIcon"
  - "CUserTool.DrawToolIcon"
  - "DrawToolIcon"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DrawToolIcon method"
ms.assetid: a4906b54-e6e0-4143-9791-f060a7bd8954
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CUserTool::DrawToolIcon
Draws the user tool icon at the center of a specified rectangle.  
  
## Syntax  
  
```  
void DrawToolIcon(  
   CDC* pDC,  
   const CRect& rectImage   
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `rectImage`  
 Specifies the coordinates of the area to display the icon.  
  
## Requirements  
 **Header:** afxusertool.h  
  
## See Also  
 [CUserTool Class](../vs140/cusertool-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)