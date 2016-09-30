---
title: "CReBarCtrl::SetPalette"
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
  - "CReBarCtrl.SetPalette"
  - "SetPalette"
  - "CReBarCtrl::SetPalette"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetPalette method"
  - "CReBarCtrl class, attributes"
ms.assetid: e62e8348-3cfc-4c2e-a288-fca442286d9d
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CReBarCtrl::SetPalette
Implements the behavior of the Win32 message [RB_SETPALETTE](http://msdn.microsoft.com/library/windows/desktop/bb774520), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *hPal*  
 An <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> that specifies the new palette that the rebar control will use.  
  
## Return Value  
 A pointer to a [CPalette](../vs140/cpalette-class.md) object specifying the rebar control's previous palette.  
  
## Remarks  
 Note that this member function uses a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object as its return value, rather than an <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CReBarCtrl Class](../vs140/crebarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CReBarCtrl::GetPalette](../vs140/crebarctrl--getpalette.md)