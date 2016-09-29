---
title: "CWnd::get_accHelpTopic"
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
  - "CWnd::get_accHelpTopic"
  - "CWnd.get_accHelpTopic"
  - "get_accHelpTopic"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_accHelpTopic method"
ms.assetid: acc48804-b1b9-4565-a46d-cbc4e245a9b2
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::get_accHelpTopic
Called by the framework to retrieve the full path of the **WinHelp** file associated with the specified object and the identifier of the appropriate topic within that file.  
  
## Syntax  
  
```  
  
      virtual HRESULT get_accHelpTopic(  
   BSTR *pszHelpFile,  
   VARIANT varChild,  
   long *pidTopic  
);  
```  
  
#### Parameters  
 `pszHelpFile`  
 Address of a `BSTR` that receives the full path of the `WinHelp` file associated with the specified object, if any.  
  
 `varChild`  
 Specifies whether the Help topic to be retrieved is that of the object or one of the object's child elements. This parameter can be either CHILDID_SELF (to obtain a Help topic for the object) or a child ID (to obtain a Help topic for one of the object's child elements).  
  
 `pidTopic`  
 Identifies the Help file topic associated with the specified object. See `pidTopic` in [IAccessible::get_accHelpTopic](http://msdn.microsoft.com/library/windows/desktop/dd318481) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 Returns S_OK on success, a COM error code on failure. See **Return Values** in **IAccessible::get_accHelpTopic** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Remarks  
 This function is part of MFC's [Active Accessibility](http://msdn.microsoft.com/library/windows/desktop/dd373592) support.  
  
 Override this function in your `CWnd`-derived class to provide help information about your object.  
  
 For more information, see[IAccessible::get_accHelpTopic](http://msdn.microsoft.com/library/windows/desktop/dd318481) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::get_accDescription](../vs140/cwnd--get_accdescription.md)   
 [CWnd::get_accHelp](../vs140/cwnd--get_acchelp.md)