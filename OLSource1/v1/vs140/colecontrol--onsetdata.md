---
title: "COleControl::OnSetData"
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
  - "COleControl::OnSetData"
  - "OnSetData"
  - "COleControl.OnSetData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnSetData method"
ms.assetid: 8abb9911-24b5-40b3-b74b-03cd51c2e8dc
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::OnSetData
Called by the framework to replace the control's data with the specified data.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to a [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure specifying the format of the data.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to a [STGMEDIUM](http://msdn.microsoft.com/library/windows/desktop/ms683812) structure in which the data resides.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 **TRUE** if the control should free the storage medium; **FALSE** if the control should not free the storage medium.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 If the data is in the persistent property set format, the default implementation modifies the control's state accordingly. Otherwise, the default implementation does nothing. If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is **TRUE**, then a call to **ReleaseStgMedium** is made; otherwise not.  
  
 Override this function to replace the control's data with the specified data.  
  
 For more information, see the **FORMATETC** and **STGMEDIUM** structures in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::DoPropExchange](../vs140/colecontrol--dopropexchange.md)