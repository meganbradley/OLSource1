---
title: "CWnd::get_accRole"
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
  - "CWnd::get_accRole"
  - "CWnd.get_accRole"
  - "get_accRole"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_accRole method"
ms.assetid: cfea46d7-aafa-4a82-ab45-a40f1291d69c
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::get_accRole
Called by the framework to retrieve information that describes the role of the specified object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies whether the role information to be retrieved is that of the object or one of the object's child elements. This parameter can be either CHILDID_SELF (to obtain information about the object) or a child ID (to obtain information about the object's child element).  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Receives the role information. See <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> in [IAccessible::get_accRole](http://msdn.microsoft.com/library/windows/desktop/dd318485) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 Returns S_OK on success, a COM error code on failure. See **Return Values** in **IAccessible::get_accRole** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Remarks  
 This function is part of MFC's [Active Accessibility](http://msdn.microsoft.com/library/windows/desktop/dd373592) support.  
  
 Override this function in your <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>-derived class if you have nonwindowed user interface elements (other than windowless ActiveX controls, which MFC handles).  
  
 For more information, see [IAccessible::get_accRole](http://msdn.microsoft.com/library/windows/desktop/dd318485) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [GetRoleText](http://msdn.microsoft.com/library/windows/desktop/dd318089)   
 [CWnd::get_accDescription](../vs140/cwnd--get_accdescription.md)