---
title: "CRichEditCtrl::SetTargetDevice"
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
  - "SetTargetDevice"
  - "CRichEditCtrl::SetTargetDevice"
  - "CRichEditCtrl.SetTargetDevice"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetTargetDevice method"
ms.assetid: a9c2aa43-c21c-45bd-b64d-704fd2a74067
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCtrl::SetTargetDevice
Sets the target device and line width used for WYSIWYG (what you see is what you get) formatting in this `CRichEditCtrl` object.  
  
## Syntax  
  
```  
  
      BOOL SetTargetDevice(  
   HDC hDC,  
   long lLineWidth   
);  
BOOL SetTargetDevice(  
   CDC& dc,  
   long lLineWidth   
);  
```  
  
#### Parameters  
 `hDC`  
 Handle to the device context for the new target device.  
  
 *lLineWidth*  
 Line width to use for formatting.  
  
 `dc`  
 [CDC](../vs140/cdc-class.md) for the new target device.  
  
## Return Value  
 Nonzero if successful; otherwise, 0.  
  
## Remarks  
 If this function is successful, the rich edit control owns the device context passed as a parameter. In that case, the calling function should not destroy the device context.  
  
 For more information, see [EM_SETTARGETDEVICE](http://msdn.microsoft.com/library/windows/desktop/bb774282) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CRichEditCtrl#32](../vs140/codesnippet/CPP/cricheditctrl--settargetdevice_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::FormatRange](../vs140/cricheditctrl--formatrange.md)   
 [CRichEditCtrl::DisplayBand](../vs140/cricheditctrl--displayband.md)