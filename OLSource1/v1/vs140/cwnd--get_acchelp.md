---
title: "CWnd::get_accHelp"
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
  - CWnd::get_accHelp
  - get_accHelp
  - CWnd.get_accHelp
dev_langs: 
  - C++
helpviewer_keywords: 
  - get_accHelp method
ms.assetid: 0c7641a5-35e0-48f7-bc18-915c0102e724
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWnd::get_accHelp
Called by the framework to retrieve an object's **Help** property string.  
  
## Syntax  
  
```  
  
      virtual HRESULT get_accHelp(  
   VARIANT varChild,  
   BSTR *pszHelp  
);  
```  
  
#### Parameters  
 `varChild`  
 Specifies whether the help information to be retrieved is that of the object or one of the object's child elements. This parameter can be either CHILDID_SELF (to obtain information about the object) or a child ID (to obtain information about the object's child element).  
  
 *pszHelp*  
 Address of a `BSTR` that receives the localized string containing the help information for the specified object, or NULL if no help information is available.  
  
## Return Value  
 Returns S_OK on success, a COM error code on failure. See **Return Values** in [IAccessible::get_accHelp](http://msdn.microsoft.com/library/windows/desktop/dd318480) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Remarks  
 This function is part of MFC's [Active Accessibility](http://msdn.microsoft.com/library/windows/desktop/dd373592) support.  
  
 Override this function in your `CWnd`-derived class to provide help text for your object.  
  
 For more information, see [IAccessible::get_accHelp](http://msdn.microsoft.com/library/windows/desktop/dd318480) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::get_accDescription](../vs140/cwnd--get_accdescription.md)   
 [CWnd::get_accHelpTopic](../vs140/cwnd--get_acchelptopic.md)