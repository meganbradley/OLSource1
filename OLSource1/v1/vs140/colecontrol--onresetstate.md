---
title: "COleControl::OnResetState"
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
  - "COleControl::OnResetState"
  - "COleControl.OnResetState"
  - "OnResetState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnResetState method"
ms.assetid: 8f5df748-2deb-4419-820b-d7e8e02d73a3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::OnResetState
Called by the framework when the control's properties should be set to their default values.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The default implementation calls [DoPropExchange](../vs140/colecontrol--dopropexchange.md), passing a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object that causes properties to be set to their default values.  
  
 The control writer can insert initialization code for the OLE control in this overridable. This function is called when [IPersistStream::Load](http://msdn.microsoft.com/library/windows/desktop/ms680568) or [IPersistStorage::Load](http://msdn.microsoft.com/library/windows/desktop/ms680557) fails, or [IPersistStreamInit::InitNew](http://msdn.microsoft.com/library/windows/desktop/ms690234) or [IPersistStorage::InitNew](http://msdn.microsoft.com/library/windows/desktop/ms687194) is called, without first calling either **IPersistStream::Load** or **IPersistStorage::Load**.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::OnSetClientSite](../vs140/colecontrol--onsetclientsite.md)