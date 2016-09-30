---
title: "CButton::SetSplitImageList"
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
  - "CButton::SetSplitImageList"
  - "CButton.SetSplitImageList"
  - "SetSplitImageList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetSplitImageList method"
ms.assetid: 6dc5af83-5609-439b-8d4a-e28b3b99753e
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CButton::SetSplitImageList
Associates an [image list](../vs140/cimagelist-class.md) with the current split button control.  
  
## Syntax  
  
```  
BOOL SetSplitImageList(  
     CImageList* pSplitImageList  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `pSplitImageList`|Pointer to a [CImageList](../vs140/cimagelist-class.md) object to assign to the current split button control.|  
  
## Return Value  
 `true` if this method is successful; otherwise, `false`.  
  
## Remarks  
 Use this method only with controls whose button style is `BS_SPLITBUTTON` or `BS_DEFSPLITBUTTON`.  
  
 This method initializes the `mask` member of a [BUTTON_SPLITINFO](http://msdn.microsoft.com/library/windows/desktop/bb775955) structure with the `BCSIF_IMAGE` flag and the `himlGlyph` member with the `pSplitImageList` parameter, and then sends that structure in the [BCM_GETSPLITINFO](http://msdn.microsoft.com/library/windows/desktop/bb775969) message that is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
 This method is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CButton Class](../vs140/cbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CButton::GetSplitImageList](../vs140/cbutton--getsplitimagelist.md)   
 [BCM_SETSPLITINFO](http://msdn.microsoft.com/library/windows/desktop/bb775981)   
 [BUTTON_SPLITINFO](http://msdn.microsoft.com/library/windows/desktop/bb775955)   
 [CImageList Class](../vs140/cimagelist-class.md)