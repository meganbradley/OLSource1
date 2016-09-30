---
title: "COleControlSite::SetWindowPos"
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
  - "COleControlSite.SetWindowPos"
  - "COleControlSite::SetWindowPos"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetWindowPos method"
  - "COleControlSite class, overridables"
ms.assetid: 8ce6c296-613f-4d23-aee7-e3316ed97f58
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControlSite::SetWindowPos
Sets the size, position, and Z order of the control site.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the window.  
  
 *x*  
 The new position of the left side of the window.  
  
 *y*  
 The new position of the top of the window.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The new width of the window  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The new height of the window.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the window sizing and positioning flags. For possible values, see the Remarks section for [SetWindowPos](http://msdn.microsoft.com/library/windows/desktop/ms633545) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 Nonzero if successful, otherwise zero.  
  
## Requirements  
 **Header:** afxocc.h  
  
## See Also  
 [COleControlSite Class](../vs140/colecontrolsite-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)