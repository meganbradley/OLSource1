---
title: "CRichEditCtrl::GetIRichEditOle"
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
  - "GetIRichEditOle"
  - "CRichEditCtrl.GetIRichEditOle"
  - "CRichEditCtrl::GetIRichEditOle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetIRichEditOle method"
ms.assetid: 5e3015f0-ff73-4abf-91b8-38f64225fe9c
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRichEditCtrl::GetIRichEditOle
Accesses the **IRichEditOle** interface for this <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Pointer to the [IRichEditOle](http://msdn.microsoft.com/library/windows/desktop/bb774306) interface that can be used to access this <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object's OLE functionality; **NULL** if the interface is not accessible.  
  
## Remarks  
 Use this interface to access this <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object's OLE functionality.  
  
 For more information, see [EM_GETOLEINTERFACE](http://msdn.microsoft.com/library/windows/desktop/bb788041) message and [IRichEditOle](http://msdn.microsoft.com/library/windows/desktop/bb774306) interface in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CRichEditCtrl Class](../vs140/cricheditctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRichEditCtrl::SetOLECallback](../vs140/cricheditctrl--setolecallback.md)