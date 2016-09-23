---
title: "CStatic::SetIcon"
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
  - CStatic.SetIcon
  - CStatic::SetIcon
dev_langs: 
  - C++
helpviewer_keywords: 
  - CStatic class, operations
  - SetIcon method
ms.assetid: d0a103b3-abdc-4efe-927e-b85c94640ced
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CStatic::SetIcon
Associates a new icon image with the static control.  
  
## Syntax  
  
```  
  
      HICON SetIcon(  
   HICON hIcon   
);  
```  
  
#### Parameters  
 `hIcon`  
 Handle of the icon to be drawn in the static control.  
  
## Return Value  
 The handle of the icon previously associated with the static control, or **NULL** if no icon was associated with the static control.  
  
## Remarks  
 The icon will be automatically drawn in the static control. By default, it will be drawn in the upper-left corner and the static control will be resized to the size of the icon.  
  
 You can use various window and static control styles, including the following:  
  
-   **SS_ICON** Use this style always for cursors and icons.  
  
-   **SS_CENTERIMAGE** Use to center in the static control. If the image is larger than the static control, it will be clipped. If it is smaller than the static control, the empty space around the image will be filled with the background color of the static control.  
  
## Example  
 [!code[NVC_MFC_CStatic#6](../vs140/codesnippet/CPP/cstatic--seticon_1.cpp)]
  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CStatic Class](../vs140/cstatic-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CStatic::GetIcon](../vs140/cstatic--geticon.md)   
 [STM_SETICON](http://msdn.microsoft.com/library/windows/desktop/bb760780)   
 [Icons](http://msdn.microsoft.com/library/windows/desktop/ms646973)