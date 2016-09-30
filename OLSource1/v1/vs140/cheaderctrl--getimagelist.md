---
title: "CHeaderCtrl::GetImageList"
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
  - "CHeaderCtrl::GetImageList"
  - "CHeaderCtrl.GetImageList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetImageList method"
ms.assetid: 0b523368-ab46-4aaf-9f31-e40922b53be8
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHeaderCtrl::GetImageList
Retrieves the handle of an image list used for drawing header items in a header control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A pointer to a [CImageList](../vs140/cimagelist-class.md) object.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [HDM_GETIMAGELIST](http://msdn.microsoft.com/library/windows/desktop/bb775332), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object to which the returned pointer points is a temporary object and is deleted in the next idle-time processing.  
  
## Example  
 [!code[NVC_MFC_CHeaderCtrl#9](../vs140/codesnippet/CPP/cheaderctrl--getimagelist_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CHeaderCtrl Class](../vs140/cheaderctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHeaderCtrl::SetImageList](../vs140/cheaderctrl--setimagelist.md)   
 [CHeaderCtrl::CreateDragImage](../vs140/cheaderctrl--createdragimage.md)