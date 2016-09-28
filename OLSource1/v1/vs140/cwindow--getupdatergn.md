---
title: "CWindow::GetUpdateRgn"
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
  - "GetUpdateRgn"
  - "CWindow::GetUpdateRgn"
  - "ATL::CWindow::GetUpdateRgn"
  - "ATL.CWindow.GetUpdateRgn"
  - "CWindow.GetUpdateRgn"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetUpdateRgn method"
ms.assetid: 91fd278c-d3b8-4164-ada3-9b4f0135e3c5
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWindow::GetUpdateRgn
Retrieves the update region and copies it into a specified region.  
  
## Syntax  
  
```  
  
      int GetUpdateRgn(  
   HRGN hRgn,  
   BOOL bErase = FALSE   
) throw();  
```  
  
## Remarks  
 See [GetUpdateRgn](http://msdn.microsoft.com/library/windows/desktop/dd144944) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)   
 [CWindow::GetUpdateRect](../vs140/cwindow--getupdaterect.md)