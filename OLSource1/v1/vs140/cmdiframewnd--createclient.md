---
title: "CMDIFrameWnd::CreateClient"
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
  - CreateClient
  - CMDIFrameWnd::CreateClient
  - CMDIFrameWnd.CreateClient
dev_langs: 
  - C++
helpviewer_keywords: 
  - CreateClient method
  - CMDIFrameWnd class, overridables
ms.assetid: 960f1946-5dd2-426f-82e6-e741a4601769
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMDIFrameWnd::CreateClient
Creates the MDI client window that manages the `CMDIChildWnd` objects.  
  
## Syntax  
  
```  
  
      virtual BOOL CreateClient(  
   LPCREATESTRUCT lpCreateStruct,  
   CMenu* pWindowMenu   
);  
```  
  
#### Parameters  
 `lpCreateStruct`  
 A long pointer to a [CREATESTRUCT](../vs140/createstruct-structure.md) structure.  
  
 `pWindowMenu`  
 A pointer to the Window pop-up menu.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 This member function should be called if you override the `OnCreate` member function directly.  
  
## Example  
 [!code[NVC_MFCWindowing#14](../vs140/codesnippet/CPP/cmdiframewnd--createclient_1.cpp)]
  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CMDIFrameWnd Class](../vs140/cmdiframewnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMDIFrameWnd::CMDIFrameWnd](../vs140/cmdiframewnd--cmdiframewnd.md)