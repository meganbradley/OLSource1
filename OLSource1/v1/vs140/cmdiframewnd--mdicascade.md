---
title: "CMDIFrameWnd::MDICascade"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - MDICascade
  - CMDIFrameWnd.MDICascade
  - CMDIFrameWnd::MDICascade
dev_langs: 
  - C++
helpviewer_keywords: 
  - MDICascade method
ms.assetid: 668784ed-34bd-49c8-8f3f-0e5c11ddad15
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMDIFrameWnd::MDICascade
Arranges all the MDI child windows in a cascade format.  
  
## Syntax  
  
```  
  
      void MDICascade( );  
void MDICascade(  
   int nType   
);  
```  
  
#### Parameters  
 `nType`  
 Specifies a cascade flag. Only the following flag can be specified: `MDITILE_SKIPDISABLED`, which prevents disabled MDI child windows from being cascaded.  
  
## Remarks  
 The first version of `MDICascade`, with no parameters, cascades all MDI child windows, including disabled ones. The second version optionally does not cascade disabled MDI child windows if you specify `MDITILE_SKIPDISABLED` for the `nType` parameter.  
  
## Example  
 [!code[NVC_MFCWindowing#17](../vs140/codesnippet/CPP/cmdiframewnd--mdicascade_1.cpp)]
  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CMDIFrameWnd Class](../vs140/cmdiframewnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMDIFrameWnd::MDIIconArrange](../vs140/cmdiframewnd--mdiiconarrange.md)   
 [CMDIFrameWnd::MDITile](../vs140/cmdiframewnd--mditile.md)   
 [WM_MDICASCADE](http://msdn.microsoft.com/library/windows/desktop/ms644912)