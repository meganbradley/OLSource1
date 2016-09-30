---
title: "CReBarCtrl::SizeToRect"
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
  - "CReBarCtrl::SizeToRect"
  - "SizeToRect"
  - "CReBarCtrl.SizeToRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CReBarCtrl class, operations"
  - "SizeToRect method"
ms.assetid: f0400e75-9dab-47e1-8de3-e88cf6d9077e
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CReBarCtrl::SizeToRect
Implements the behavior of the Win32 message [RB_SIZETORECT](http://msdn.microsoft.com/library/windows/desktop/bb774534), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A reference to a [CRect](../vs140/crect-class.md) object that specifies the rectangle that the rebar control should be sized to.  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Remarks  
 Note that this member function uses a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object as a parameter, rather than a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> structure.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CReBarCtrl Class](../vs140/crebarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CReBarCtrl::GetRect](../vs140/crebarctrl--getrect.md)