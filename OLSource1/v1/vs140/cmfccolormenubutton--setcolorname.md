---
title: "CMFCColorMenuButton::SetColorName"
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
  - "CMFCColorMenuButton.SetColorName"
  - "SetColorName"
  - "CMFCColorMenuButton::SetColorName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetColorName method"
ms.assetid: 0fb23857-153c-4097-bf92-1ece63254e8c
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCColorMenuButton::SetColorName
Sets a new name for the specified color.  
  
## Syntax  
  
```  
static void SetColorName(  
   COLORREF color,  
   const CString& strName   
);  
```  
  
#### Parameters  
 [in] `color`  
 The RGB value of the color whose name changes.  
  
 [in] `strName`  
 The new name of the color.  
  
## Remarks  
  
## Requirements  
 **Header:** afxcolormenubutton.h  
  
## See Also  
 [CMFCColorMenuButton Class](../vs140/cmfccolormenubutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449)