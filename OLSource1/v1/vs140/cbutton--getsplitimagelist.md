---
title: "CButton::GetSplitImageList"
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
  - CButton::GetSplitImageList
  - CButto.:GetSplitImageList
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetSplitImageList method
ms.assetid: eb3c6c54-f810-4359-89a3-6d04c2854f96
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CButton::GetSplitImageList
Retrieves the [image list](../vs140/cimagelist-class.md) for the current split button control.  
  
## Syntax  
  
```  
CImageList* GetSplitImageList() const;  
```  
  
## Return Value  
 A pointer to a [CImageList](../vs140/cimagelist-class.md) object.  
  
## Remarks  
 Use this method only with controls whose button style is `BS_SPLITBUTTON` or `BS_DEFSPLITBUTTON`.  
  
 This method initializes the `mask` member of a [BUTTON_SPLITINFO](http://msdn.microsoft.com/library/windows/desktop/bb775955) structure with the `BCSIF_IMAGE` flag, and then sends that structure in the [BCM_GETSPLITINFO](http://msdn.microsoft.com/library/windows/desktop/bb775969) message that is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. When the message function returns, this method retrieves the image list from the `himlGlyph` member of the structure.  
  
## Requirements  
 **Header:** afxwin.h  
  
 This method is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CButton Class](../vs140/cbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CButton::SetSplitImageList](../vs140/cbutton--setsplitimagelist.md)   
 [BCM_GETSPLITINFO](http://msdn.microsoft.com/library/windows/desktop/bb775969)   
 [BUTTON_SPLITINFO](http://msdn.microsoft.com/library/windows/desktop/bb775955)   
 [CImageList Class](../vs140/cimagelist-class.md)