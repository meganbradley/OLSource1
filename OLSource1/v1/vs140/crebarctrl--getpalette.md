---
title: "CReBarCtrl::GetPalette"
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
  - "CReBarCtrl::GetPalette"
  - "GetPalette"
  - "CReBarCtrl.GetPalette"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rebar controls, retrieving palettes"
  - "GetPalette method"
  - "CReBarCtrl class, attributes"
ms.assetid: d97afabf-79fb-4cfb-ae26-2c5c63c47fc8
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CReBarCtrl::GetPalette
Retrieves the rebar control's current palette.  
  
## Syntax  
  
```  
  
CPalette* GetPalette( ) const;  
  
```  
  
## Return Value  
 A pointer to a [CPalette](../vs140/cpalette-class.md) object specifying the rebar control's current palette.  
  
## Remarks  
 Note that this member function uses a `CPalette` object as its return value, rather than an `HPALETTE`.  
  
## Example  
 [!code[NVC_MFC_CReBarCtrl#5](../vs140/codesnippet/CPP/crebarctrl--getpalette_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CReBarCtrl Class](../vs140/crebarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CReBarCtrl::SetPalette](../vs140/crebarctrl--setpalette.md)