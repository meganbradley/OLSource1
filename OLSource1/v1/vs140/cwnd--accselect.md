---
title: "CWnd::accSelect"
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
  - "accSelect"
  - "CWnd::accSelect"
  - "CWnd.accSelect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "accSelect method"
ms.assetid: 4c99ce69-4c19-4ead-a92a-33d37fe95611
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::accSelect
Called by the framework to modify the selection or move the keyboard focus of the specified object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies how to change the current selection or focus. See <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> in [IAccessible::accSelect](http://msdn.microsoft.com/library/windows/desktop/dd318474) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the object to be selected. This parameter can be either CHILDID_SELF (to select the object itself) or a child ID (to select one of the object's children).  
  
## Return Value  
 Returns S_OK on success, a COM error code on failure. See **Return Values** in **IAccessible::accSelect** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Remarks  
 This function is part of MFC's [Active Accessibility](http://msdn.microsoft.com/library/windows/desktop/dd373592) support.  
  
 Override this function in your <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>-derived class if you have nonwindowed user interface elements (other than windowless ActiveX controls, which MFC handles).  
  
 For more information, see [IAccessible::accSelect](http://msdn.microsoft.com/library/windows/desktop/dd318474) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::get_accFocus](../vs140/cwnd--get_accfocus.md)   
 [CWnd::get_accSelection](../vs140/cwnd--get_accselection.md)