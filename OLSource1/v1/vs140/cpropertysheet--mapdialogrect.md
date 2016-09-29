---
title: "CPropertySheet::MapDialogRect"
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
  - "CPropertySheet::MapDialogRect"
  - "CPropertySheet.MapDialogRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MapDialogRect method"
ms.assetid: 1068fbcd-838b-4db0-b20e-6d48516bdcba
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPropertySheet::MapDialogRect
Converts the dialog-box units of a rectangle to screen units.  
  
## Syntax  
  
```  
  
      void MapDialogRect(   
   LPRECT lpRect   
) const;  
```  
  
#### Parameters  
 `lpRect`  
 Points to a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure or [CRect](../vs140/crect-class.md) object that contains the dialog-box coordinates to be converted.  
  
## Remarks  
 Dialog-box units are stated in terms of the current dialog-box base unit derived from the average width and height of characters in the font used for dialog-box text. One horizontal unit is one-fourth of the dialog-box base-width unit, and one vertical unit is one-eighth of the dialog-box base height unit.  
  
 The [GetDialogBaseUnits](http://msdn.microsoft.com/library/windows/desktop/ms645475) Windows function returns size information for the system font, but you can specify a different font for each property sheet if you use the **DS_SETFONT** style in the resource-definition file. The [MapDialogRect](http://msdn.microsoft.com/library/windows/desktop/ms645502) Windows function, described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)], uses the appropriate font for this dialog box.  
  
 The `MapDialogRect` member function replaces the dialog-box units in `lpRect` with screen units (pixels) so that the rectangle can be used to create a dialog box or position a control within a box.  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPropertySheet Class](../vs140/cpropertysheet-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [WM_SETFONT](http://msdn.microsoft.com/library/windows/desktop/ms632642)