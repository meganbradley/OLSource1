---
title: "CMFCPropertySheet::GetTab"
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
  - "CMFCPropertySheet::GetTab"
  - "GetTab"
  - "CMFCPropertySheet.GetTab"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTab method"
ms.assetid: 4a1fe20b-07d9-4678-8f34-398e404e9a25
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertySheet::GetTab
Retrieves the internal tab control object that supports the current property sheet control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 An internal tab control object.  
  
## Remarks  
 You can set a property sheet so that it appears in different styles, such as a tree control, a list of navigation buttons, or a set of tabbed pages.  
  
 Before you call this method, call the [CMFCPropertySheet::SetLook](../vs140/cmfcpropertysheet--setlook.md) method to set the appearance of the property sheet control. Then call the [CMFCPropertySheet::InitNavigationControl](../vs140/cmfcpropertysheet--initnavigationcontrol.md) method to initialize the internal tab control object. Use this method to retrieve the tab control object and then use that object to work with the tabs on the property sheet.  
  
 This method asserts in debug mode if the property sheet control is not set to appear in the style of Microsoft OneNote.  
  
## Requirements  
 **Header:** afxpropertysheet.h  
  
## See Also  
 [CMFCPropertySheet Class](../vs140/cmfcpropertysheet-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCTabCtrl Class](../vs140/cmfctabctrl-class.md)   
 [CMFCPropertySheet::SetLook](../vs140/cmfcpropertysheet--setlook.md)   
 [CMFCPropertySheet::InitNavigationControl](../vs140/cmfcpropertysheet--initnavigationcontrol.md)