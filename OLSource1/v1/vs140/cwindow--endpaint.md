---
title: "CWindow::EndPaint"
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
  - "CWindow::EndPaint"
  - "EndPaint"
  - "ATL::CWindow::EndPaint"
  - "CWindow.EndPaint"
  - "ATL.CWindow.EndPaint"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EndPaint method"
ms.assetid: be3efc16-5854-48ff-89d6-11f63eaaa4dc
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWindow::EndPaint
Marks the end of painting.  
  
## Syntax  
  
```  
  
      void EndPaint(  
   LPPAINTSTRUCT lpPaint   
) throw();  
```  
  
## Remarks  
 See [EndPaint](http://msdn.microsoft.com/library/windows/desktop/dd162598) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_ATL_Windowing#2](../vs140/codesnippet/CPP/cwindow--endpaint_1.cpp)]  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)   
 [CWindow::BeginPaint](../vs140/cwindow--beginpaint.md)