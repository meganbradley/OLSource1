---
title: "MFC ActiveX Controls: Using Stock Property Pages"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - CLSID_CPicturePropPage
  - CLSID_CColorPropPage
  - CLSID_CFontPropPage
dev_langs: 
  - C++
helpviewer_keywords: 
  - picture stock property pages
  - CLSID_CFontPropPage
  - color stock property pages
  - CLSID_CColorPropPage
  - fonts, ActiveX controls
  - stock properties, stock property pages
  - CLSID_CPicturePropPage
  - MFC ActiveX controls, property pages
ms.assetid: 22638d86-ff3e-4124-933e-54b7c2a25968
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# MFC ActiveX Controls: Using Stock Property Pages
This article discusses the stock property pages available for ActiveX controls and how to use them.  
  
 For more information on using property pages in an ActiveX control, see the following articles:  
  
-   [MFC ActiveX Controls: Property Pages](../vs140/mfc-activex-controls--property-pages.md)  
  
-   [MFC ActiveX Controls: Adding Another Custom Property Page](../vs140/mfc-activex-controls--adding-another-custom-property-page.md)  
  
 MFC provides three stock property pages for use with ActiveX controls: **CLSID_CColorPropPage**, **CLSID_CFontPropPage**, and **CLSID_CPicturePropPage**. These pages display a user interface for stock color, font, and picture properties, respectively.  
  
 To incorporate these property pages into a control, add their IDs to the code that initializes the control's array of property page IDs. In the following example, this code, located in the control implementation file (.CPP), initializes the array to contain all three stock property pages and the default property page (named `CMyPropPage` in this example):  
  
 [!code[NVC_MFC_AxOpt#21](../vs140/codesnippet/CPP/mfc-activex-controls--using-stock-property-pages_1.cpp)]
  
  
 Note that the count of property pages, in the `BEGIN_PROPPAGEIDS` macro, is 4. This represents the number of property pages supported by the ActiveX control.  
  
 After these modifications have been made, rebuild your project. Your control now has property pages for the font, picture, and color properties.  
  
> [!NOTE]
>  If the control stock property pages cannot be accessed, it may be because the MFC DLL (MFCxx.DLL) has not been properly registered with the current operating system. This usually results from installing Visual C++ under an operating system different from the one currently running.  
  
> [!TIP]
>  If your stock property pages are not visible (see previous Note), register the DLL by running RegSvr32.exe from the command line with the full path name to the DLL.  
  
## See Also  
 [MFC ActiveX Controls](../vs140/mfc-activex-controls.md)   
 [MFC ActiveX Controls: Adding Stock Properties](../vs140/mfc-activex-controls--adding-stock-properties.md)