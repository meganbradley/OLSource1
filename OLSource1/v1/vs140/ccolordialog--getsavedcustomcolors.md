---
title: "CColorDialog::GetSavedCustomColors"
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
  - "GetSavedCustomColors"
  - "CColorDialog.GetSavedCustomColors"
  - "CColorDialog::GetSavedCustomColors"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CColorDialog class, operations"
  - "GetSavedCustomColors method"
ms.assetid: 18467303-9aef-45f0-b21e-bcda8936deb9
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CColorDialog::GetSavedCustomColors
`CColorDialog` objects permit the user, in addition to choosing colors, to define up to 16 custom colors.  
  
## Syntax  
  
```  
  
static COLORREF * PASCAL GetSavedCustomColors( );  
```  
  
## Return Value  
 A pointer to an array of 16 RGB color values that stores custom colors created by the user.  
  
## Remarks  
 The `GetSavedCustomColors` member function provides access to these colors. These colors can be retrieved after [DoModal](../vs140/ccolordialog--domodal.md) returns **IDOK**.  
  
 Each of the 16 RGB values in the returned array is initialized to RGB(255,255,255) (white). The custom colors chosen by the user are saved only between dialog box invocations within the application. If you wish to save these colors between invocations of the application, you must save them in some other manner, such as in an initialization (.INI) file.  
  
## Example  
 [!code[NVC_MFCDocView#51](../vs140/codesnippet/CPP/ccolordialog--getsavedcustomcolors_1.cpp)]  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CColorDialog Class](../vs140/ccolordialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CColorDialog::GetColor](../vs140/ccolordialog--getcolor.md)