---
title: "CToolBarCtrl::ReplaceBitmap"
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
  - "ReplaceBitmap method"
  - "CToolBarCtrl::ReplaceBitmap"
  - "CToolBarCtrl.ReplaceBitmap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ReplaceBitmap method"
ms.assetid: 2ee7fe52-3745-4b00-a618-81aa0d2b6e74
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::ReplaceBitmap
Replaces the existing bitmap in the current toolbar control with a new bitmap.  
  
## Syntax  
  
```  
BOOL ReplaceBitmap(  
     LPTBREPLACEBITMAP pReplaceBitmap  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `pReplaceBitmap`|Pointer to a [TBREPLACEBITMAP](http://msdn.microsoft.com/library/windows/desktop/bb760484) structure that describes the bitmap to be replaced and the new bitmap.|  
  
## Return Value  
 `true` if this method is successful; otherwise, `false`.  
  
## Remarks  
 This method sends the [TB_REPLACEBITMAP](http://msdn.microsoft.com/library/windows/desktop/bb787391) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## Example  
 The following code example replaces the bitmap for the standard toolbar with a different bitmap.  
  
 [!code[NVC_MFC_CToolBarCtrl_s1#2](../vs140/codesnippet/CPP/ctoolbarctrl--replacebitmap_1.cpp)]  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [TB_REPLACEBITMAP](http://msdn.microsoft.com/library/windows/desktop/bb787391)   
 [TBREPLACEBITMAP](http://msdn.microsoft.com/library/windows/desktop/bb760484)   
 [CToolBarCtrl::ChangeBitmap](../vs140/ctoolbarctrl--changebitmap.md)