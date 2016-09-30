---
title: "CReBarCtrl::SetExtendedStyle"
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
  - "CReBarCtrl::SetExtendedStyle"
  - "CReBarCtrl.SetExtendedStyle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetExtendedStyle method"
ms.assetid: 64d74966-2556-48ac-b2a3-408559f8d413
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CReBarCtrl::SetExtendedStyle
Sets the extended styles for the current rebar control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|A bitwise combination (OR) of flags that specify which flags in the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter apply. Use one or more of the following values:\<br />\<br /> RBS_EX_SPLITTER: By default, show the splitter on the bottom in horizontal mode, and to the right in vertical mode.\<br />\<br /> RBS_EX_TRANSPARENT: Forward the [WM_ERASEBKGND](http://msdn.microsoft.com/library/windows/desktop/ms648055) message to the parent window.|  
|[in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|A bitwise combination (OR) of flags that specify the styles to apply. To set a style, specify the same flag that is used in the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter. To reset a style, specify binary zero.|  
  
## Return Value  
 The previous extended style.  
  
## Remarks  
 This method sends the [RB_SETEXTENDEDSTYLE](http://msdn.microsoft.com/library/windows/desktop/bb774519) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
 This method is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CDateTimeCtrl Class](../vs140/cdatetimectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)