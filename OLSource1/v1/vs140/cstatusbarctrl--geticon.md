---
title: "CStatusBarCtrl::GetIcon"
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
  - "GetIcon method"
  - "CStatusBarCtrl.GetIcon"
  - "CStatusBarCtrl::GetIcon"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetIcon method"
ms.assetid: 35f651c0-ebc9-4a40-8d27-23d5c6e324f1
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStatusBarCtrl::GetIcon
Retrieves the icon for a part (also known as a pane) in the current status bar control.  
  
## Syntax  
  
```  
HICON GetIcon(  
      int iPart  
) const;  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `iPart`|The zero-based index of the part that contains the icon to be retrieved. If this parameter is -1, the status bar is assumed to be a simple mode status bar.|  
  
## Return Value  
 The handle to the icon if the method successful; otherwise, `NULL`.  
  
## Remarks  
 This method sends the [SB_GETICON](http://msdn.microsoft.com/library/windows/desktop/bb760744) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 A status bar control consists of a row of text output panes, which are also known as parts. For more information about the status bar, see [Status Bar Implementation in MFC](../vs140/status-bar-implementation-in-mfc.md) and [Setting the Mode of a CStatusBarCtrl Object](../vs140/setting-the-mode-of-a-cstatusbarctrl-object.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## Example  
 The following code example defines a variable, `m_statusBar`, that is used to access the current status bar control. This variable is used in the next example.  
  
 [!code[NVC_MFC_CStatusBarCtrl_s1#1](../vs140/codesnippet/CPP/cstatusbarctrl--geticon_1.h)]  
  
## Example  
 The following code example copies an icon to two panes of the current status bar control. In an earlier section of the code example we created a status bar control with three panes and then added an icon to the first pane. This example retrieves the icon from the first pane and then adds it to the second and third pane.  
  
 [!code[NVC_MFC_CStatusBarCtrl_s1#2](../vs140/codesnippet/CPP/cstatusbarctrl--geticon_2.cpp)]  
  
## See Also  
 [CStatusBarCtrl Class](../vs140/cstatusbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Using CStatusBarCtrl](../vs140/using-cstatusbarctrl.md)   
 [SB_GETICON](http://msdn.microsoft.com/library/windows/desktop/bb760744)   
 [CStatusBarCtrl::SetParts](../vs140/cstatusbarctrl--setparts.md)