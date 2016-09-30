---
title: "CToolBarCtrl::GetPadding"
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
  - "CToolBarCtrl::GetPadding"
  - "CToolBarCtrl.GetPadding"
  - "GetPadding method"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetPadding method"
ms.assetid: ab049e48-fb6b-463c-b976-ebafc29af842
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::GetPadding
Retrieves the horizontal and vertical padding of the current toolbar control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[out] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|An integer that receives the horizontal padding of the toolbar control, in pixels.|  
|[out] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|An integer that receives the vertical padding of the toolbar control, in pixels.|  
  
## Return Value  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if this method is successful; otherwise, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Remarks  
 This method sends the [TB_GETPADDING](http://msdn.microsoft.com/library/windows/desktop/bb787344) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [TB_GETPADDING](http://msdn.microsoft.com/library/windows/desktop/bb787344)   
 [CToolBarCtrl::SetPadding](../vs140/ctoolbarctrl--setpadding.md)