---
title: "CToolBarCtrl::SetExtendedStyle"
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
  - CToolBarCtrl::SetExtendedStyle
  - CToolBarCtrl.SetExtendedStyle
dev_langs: 
  - C++
helpviewer_keywords: 
  - CToolBarCtrl class, attributes
  - SetExtendedStyle method
ms.assetid: fa0dd69b-b51a-452f-8191-bfcb29047f77
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CToolBarCtrl::SetExtendedStyle
Sets the extended styles for a toolbar control.  
  
## Syntax  
  
```  
  
      DWORD SetExtendedStyle(  
   DWORD dwExStyle   
);  
```  
  
#### Parameters  
 `dwExStyle`  
 A value specifying the new extended styles. This parameter can be a combination of the toolbar extended styles.  
  
## Return Value  
 A `DWORD` that represents the previous extended styles. For a list of styles, see [Toolbar Extended Styles](http://msdn.microsoft.com/library/windows/desktop/bb760430), in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Remarks  
 This member function implements the behavior of the Win32 message [TB_SETEXTENDEDSTYLE](http://msdn.microsoft.com/library/windows/desktop/bb787427), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBarCtrl::GetExtendedStyle](../vs140/ctoolbarctrl--getextendedstyle.md)