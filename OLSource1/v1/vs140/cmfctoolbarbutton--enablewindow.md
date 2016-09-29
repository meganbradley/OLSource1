---
title: "CMFCToolBarButton::EnableWindow"
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
  - "CMFCToolBarButton::EnableWindow"
  - "EnableWindow"
  - "CMFCToolBarButton.EnableWindow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableWindow method"
ms.assetid: c59de29e-7463-484f-8b06-c256a44f7073
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarButton::EnableWindow
Enables or disables mouse and keyboard input.  
  
## Syntax  
  
```  
virtual void EnableWindow(  
   BOOL bEnable = TRUE  
);  
```  
  
#### Parameters  
 [in] `bEnable`  
 Set this parameter to `TRUE` to enable input, or to `FALSE` to disable input.  
  
## Remarks  
 This method calls the `EnableWindow` function to enable or disable input. For more information, see [EnableWindow](http://msdn.microsoft.com/library/windows/desktop/ms646291) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxtoolbarbutton.h  
  
## See Also  
 [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [EnableWindow](http://msdn.microsoft.com/library/windows/desktop/ms646291)