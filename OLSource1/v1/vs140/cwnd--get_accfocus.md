---
title: "CWnd::get_accFocus"
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
  - "CWnd::get_accFocus"
  - "CWnd.get_accFocus"
  - "get_accFocus"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_accFocus method"
ms.assetid: a518f847-3f75-440a-bc0f-11972516394d
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::get_accFocus
Called by the framework to retrieve the object that has the keyboard focus.  
  
## Syntax  
  
```  
  
      virtual HRESULT get_accFocus(  
   VARIANT *pvarChild  
);  
```  
  
#### Parameters  
 `pvarChild`  
 Receives information about the object that has the focus. See *pvarID* in[IAccessible::get_accFocus](http://msdn.microsoft.com/library/windows/desktop/dd318479) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 Returns S_OK on success, a COM error code on failure. See **Return Values** in **IAccessible::get_accFocus** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Remarks  
 This function is part of MFC's [Active Accessibility](http://msdn.microsoft.com/library/windows/desktop/dd373592) support.  
  
 Override this function in your `CWnd`-derived class if you have nonwindowed user interface elements (other than windowless ActiveX controls, which MFC handles).  
  
 For more information, see [IAccessible::get_accFocus](http://msdn.microsoft.com/library/windows/desktop/dd318479) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::get_accSelection](../vs140/cwnd--get_accselection.md)   
 [CWnd::accSelect](../vs140/cwnd--accselect.md)