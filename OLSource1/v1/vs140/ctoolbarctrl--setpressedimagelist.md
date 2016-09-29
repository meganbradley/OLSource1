---
title: "CToolBarCtrl::SetPressedImageList"
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
  - "SetPressedImageList method"
  - "CToolBarCtrl.SetPressedImageList"
  - "CToolBarCtrl::SetPressedImageList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetPressedImageList method"
ms.assetid: 5155084d-3ffe-48b3-be25-395b27c0de76
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::SetPressedImageList
Sets the image list that the current toolbar control uses to represent buttons in the pressed state.  
  
## Syntax  
  
```  
CImagelist* SetPressedImageList(  
            int iImageID,   
            CImageList* pImageList  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `iImageID`|The zero-based index of the image list. Set this parameter to zero if you use only one image list.|  
|[in] `pImageList`|Pointer to a [CImageList](../vs140/cimagelist-class.md) that contains the new image list.|  
  
## Return Value  
 Pointer to a [CImageList](../vs140/cimagelist-class.md) that contains the previous image list for the current control, or `NULL` if no such image list was set.  
  
## Remarks  
 This method sends the [TB_SETPRESSEDIMAGELIST](http://msdn.microsoft.com/library/windows/desktop/bb787453) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
 This control is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## Example  
 The following code example sets the pressed image list to be the same as the default image list.  
  
 [!code[NVC_MFC_CToolBarCtrl_s1#5](../vs140/codesnippet/CPP/ctoolbarctrl--setpressedimagelist_1.cpp)]  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [TB_SETPRESSEDIMAGELIST](http://msdn.microsoft.com/library/windows/desktop/bb787453)   
 [CImageList](../vs140/cimagelist-class.md)   
 [CToolBarCtrl::GetPressedImageList](../vs140/ctoolbarctrl--getpressedimagelist.md)