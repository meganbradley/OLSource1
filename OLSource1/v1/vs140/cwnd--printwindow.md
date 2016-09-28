---
title: "CWnd::PrintWindow"
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
  - "CWnd.PrintWindow"
  - "PrintWindow"
  - "CWnd::PrintWindow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PrintWindow method"
ms.assetid: 04e61fb8-5557-4697-8124-e6cf1803623e
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::PrintWindow
Copies a visual window into the specified device context, typically a printer DC.  
  
## Syntax  
  
```  
  
      BOOL PrintWindow(  
   CDC* pDC,  
   UINT nFlags  
) const;  
```  
  
#### Parameters  
 `pDC`  
 A pointer to the device context to be printed to.  
  
 `nFlags`  
 Specifies the drawing options. For a list of possible values, see [PrintWindow](http://msdn.microsoft.com/library/windows/desktop/dd162869).  
  
## Return Value  
 Nonzero if the function succeeds; otherwise 0.  
  
## Remarks  
 This member function emulates the functionality of the function [PrintWindow](http://msdn.microsoft.com/library/windows/desktop/dd162869), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)