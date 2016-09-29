---
title: "CRichEditCtrl::SetAutoURLDetect"
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
  - "CRichEditCtrl::SetAutoURLDetect"
  - "SetAutoURLDetect"
  - "CRichEditCtrl.SetAutoURLDetect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetAutoURLDetect method"
ms.assetid: a6a613b1-6969-46da-a644-76464aeabf4b
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCtrl::SetAutoURLDetect
Sets the rich edit control to automatically detect a URL.  
  
## Syntax  
  
```  
  
      BOOL SetAutoURLDetect(  
   BOOL bEnable = TRUE   
);  
```  
  
#### Parameters  
 `bEnable`  
 Specifies whether the control is set to automatically detect a URL. If **TRUE**, it is enabled. If **FALSE**, it is disabled.  
  
## Return Value  
 Zero if successful, otherwise nonzero. For example, the message may fail due to insufficient memory.  
  
## Remarks  
 If enabled, the rich edit control will scan the text to determine if it matches a standard URL format. For a list of these URL formats, see [EM_AUTOURLDETECT](http://msdn.microsoft.com/library/windows/desktop/bb787991) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
> [!NOTE]
>  Do not set `SetAutoURLDetect` to **TRUE** if your edit control uses the **CFE_LINK** effect for text other than URLs. `SetAutoURLDetect` enables this effect for URLs and disables it for all other text. See [EN_LINK](http://msdn.microsoft.com/library/windows/desktop/bb787970) for more information about the **CFE_LINK** effect.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)