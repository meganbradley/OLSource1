---
title: "CWnd::get_accDescription"
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
  - "CWnd::get_accDescription"
  - "get_accDescription"
  - "CWnd.get_accDescription"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_accDescription method"
ms.assetid: 892f1c5a-38d1-4fe5-b3a3-ffbb5b864fed
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::get_accDescription
Called by framework to retrieve a string that describes the visual appearance of the specified object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies whether the description to be retrieved is that of the object or one of the object's child elements. This parameter can be either CHILDID_SELF (to obtain information about the object) or a child ID (to obtain information about the object's child element).  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Address of a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> that receives a localized string describing the specified object, or NULL if no description is available for this object.  
  
## Return Value  
 Returns S_OK on success, a COM error code on failure. See **Return Values** in [IAccessible::get_accDescription](http://msdn.microsoft.com/library/windows/desktop/dd318478) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Remarks  
 This function is part of MFC's [Active Accessibility](http://msdn.microsoft.com/library/windows/desktop/dd373592) support.  
  
 Override this function in your <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>-derived class to describe your object. Call the base class version and add your description.  
  
 For more information, see [IAccessible::get_accDescription](http://msdn.microsoft.com/library/windows/desktop/dd318478) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::get_accHelp](../vs140/cwnd--get_acchelp.md)   
 [CWnd::get_accName](../vs140/cwnd--get_accname.md)   
 [CWnd::get_accRole](../vs140/cwnd--get_accrole.md)   
 [CWnd::get_accState](../vs140/cwnd--get_accstate.md)   
 [CWnd::get_accValue](../vs140/cwnd--get_accvalue.md)