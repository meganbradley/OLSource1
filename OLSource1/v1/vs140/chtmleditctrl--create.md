---
title: "CHtmlEditCtrl::Create"
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
  - "CHtmlEditCtrl.Create"
  - "CHtmlEditCtrl::Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method [C++]"
ms.assetid: 282fa927-48ca-4ded-b2a7-dcf8a8e874c1
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlEditCtrl::Create
Creates a WebBrowser ActiveX control and attaches it to the `CHtmlEditCtrl` object. The WebBrowser ActiveX control automatically navigates to a default document and then is placed in edit mode by this function.  
  
## Syntax  
  
```  
  
      virtual BOOL Create(  
   LPCTSTR lpszWindowName,  
   DWORD dwStyle,  
   const RECT& rect,  
   CWnd* pParentWnd,  
   int nID,  
   CCreateContext *pContext = NULL  
);  
```  
  
#### Parameters  
 `lpszWindowName`  
 This parameter is unused.  
  
 `dwStyle`  
 This parameter is unused.  
  
 `rect`  
 Specifies the control's size and position.  
  
 `pParentWnd`  
 Specifies the control's parent window. It must not be **NULL**.  
  
 `nID`  
 Specifies the control's ID.  
  
 `pContext`  
 This parameter is unused.  
  
## Return Value  
 Returns **TRUE** on success, **FALSE** on failure.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlEditCtrl Class](../vs140/chtmleditctrl-class.md)   
 [CHtmlEditCtrl::CHtmlEditCtrl](../vs140/chtmleditctrl--chtmleditctrl.md)