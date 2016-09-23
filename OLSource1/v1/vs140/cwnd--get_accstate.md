---
title: "CWnd::get_accState"
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
  - CWnd.get_accState
  - CWnd::get_accState
  - get_accState
dev_langs: 
  - C++
helpviewer_keywords: 
  - get_accState method
ms.assetid: fcb175d3-ef3f-4956-8581-ccbb5e10bf05
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWnd::get_accState
Called by the framework to retrieve the current state of the specified object.  
  
## Syntax  
  
```  
  
      virtual HRESULT get_accState(  
   VARIANT varChild,  
   VARIANT *pvarState  
);  
```  
  
#### Parameters  
 `varChild`  
 Specifies whether the state information to be retrieved is that of the object or one of the object's child elements. This parameter can be either CHILDID_SELF (to obtain information about the object) or a child ID (to obtain information about the object's child element).  
  
 `pvarState`  
 Receives information about the object's state. See `pvarState` in [IAccessible::get_accState](http://msdn.microsoft.com/library/windows/desktop/dd318487) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 Returns S_OK on success, a COM error code on failure. See **Return Values** in **IAccessible::get_accState** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Remarks  
 This function is part of MFC's [Active Accessibility](http://msdn.microsoft.com/library/windows/desktop/dd373592) support.  
  
 Override this function in your `CWnd`-derived class if you have nonwindowed user interface elements (other than windowless ActiveX controls, which MFC handles).  
  
 For more information, see [IAccessible::get_accState](http://msdn.microsoft.com/library/windows/desktop/dd318487) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::get_accDescription](../vs140/cwnd--get_accdescription.md)