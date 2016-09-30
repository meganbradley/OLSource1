---
title: "CRichEditCtrl::SetOLECallback"
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
  - "SetOLECallback"
  - "CRichEditCtrl::SetOLECallback"
  - "CRichEditCtrl.SetOLECallback"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetOLECallback method"
ms.assetid: 56e9c467-2d12-4dc3-84a7-15827c735ea4
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCtrl::SetOLECallback
Gives this <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object an **IRichEditOleCallback** object to use to access OLE-related resources and information.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to an [IRichEditOleCallback](http://msdn.microsoft.com/library/windows/desktop/bb774308) object that this <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object will use to get OLE-related resources and information.  
  
## Return Value  
 Nonzero if successful; otherwise, 0.  
  
## Remarks  
 This <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object will call [IUnknown::AddRef](http://msdn.microsoft.com/library/windows/desktop/ms691379) to increment the usage count for the COM object specified by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 For more information, see [EM_SETOLECALLBACK](http://msdn.microsoft.com/library/windows/desktop/bb774252) message and [IRichEditOleCallback](http://msdn.microsoft.com/library/windows/desktop/bb774308) interface in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::GetIRichEditOle](../vs140/cricheditctrl--getiricheditole.md)