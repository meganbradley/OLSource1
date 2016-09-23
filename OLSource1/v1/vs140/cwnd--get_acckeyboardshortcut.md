---
title: "CWnd::get_accKeyboardShortcut"
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
  - get_accKeyboardShortcut
  - CWnd.get_accKeyboardShortcut
  - CWnd::get_accKeyboardShortcut
dev_langs: 
  - C++
helpviewer_keywords: 
  - get_accKeyboardShortcut method
ms.assetid: e4a0d4e6-624b-4b8c-8f13-8b8f581364ca
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWnd::get_accKeyboardShortcut
Called by the framework to retrieve the specified object's shortcut key or access key.  
  
## Syntax  
  
```  
  
      virtual HRESULT get_accKeyboardShortcut(  
   VARIANT varChild,  
   BSTR *pszKeyboardShortcut  
);  
```  
  
#### Parameters  
 `varChild`  
 Specifies whether the keyboard shortcut to be retrieved is that of the object or one of the object's child elements. This parameter can be either CHILDID_SELF (to obtain information about the object) or a child ID (to obtain information about the object's child element).  
  
 *pszKeyboardShortcut*  
 Address of a `BSTR` that receives a localized string identifying the keyboard shortcut, or NULL if no keyboard shortcut is associated with the specified object.  
  
## Return Value  
 Returns S_OK on success, a COM error code on failure. See **Return Values** in [IAccessible::get_accKeyboardShortcut](http://msdn.microsoft.com/library/windows/desktop/dd318482) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Remarks  
 This function is part of MFC's [Active Accessibility](http://msdn.microsoft.com/library/windows/desktop/dd373592) support.  
  
 Override this function in your `CWnd`-derived class to identify the keyboard shortcut for your object.  
  
 For more information, see [IAccessible::get_accKeyboardShortcut](http://msdn.microsoft.com/library/windows/desktop/dd318482) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)