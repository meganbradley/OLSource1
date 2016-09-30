---
title: "CMFCRibbonBar::OnSysKeyUp"
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
  - "CMFCRibbonBar::OnSysKeyUp"
  - "OnSysKeyUp"
  - "CMFCRibbonBar.OnSysKeyUp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnSysKeyUp method"
ms.assetid: da76ed47-c372-4ffd-8aa5-951a5df9c138
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonBar::OnSysKeyUp
Called by the framework when the user releases the F10 key, the ALT key, or a key that was pressed when the ALT key was held down.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to the parent main frame window of the ribbon bar.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Virtual key code of the key being released.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 This parameter is not used.  
  
## Return Value  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if the keystroke event was processed; otherwise <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Remarks  
  
## Requirements  
 **Header:** afxribbonbar.h  
  
## See Also  
 [CMFCRibbonBar Class](../vs140/cmfcribbonbar-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)