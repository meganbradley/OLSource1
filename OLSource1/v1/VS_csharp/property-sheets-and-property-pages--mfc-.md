---
title: "Property Sheets and Property Pages (MFC)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MFC dialog boxes, tabs"
  - "property pages, property sheets"
  - "CPropertyPage class, property sheets and pages"
  - "CPropertySheet class, property sheets and pages"
  - "property sheets, propert pages"
ms.assetid: de8fea12-6c35-4cef-8625-b8073a379446
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Property Sheets and Property Pages (MFC)
An MFC [dialog box](../VS_csharp/dialog-boxes.md) can take on a "tab dialog" look by incorporating property sheets and property pages. Called a "property sheet" in MFC, this kind of dialog box, similar to many dialog boxes in Microsoft Word, Excel, and Visual C++, appears to contain a stack of tabbed sheets, much like a stack of file folders seen from front to back, or a group of cascaded windows. Controls on the front tab are visible; only the labeled tab is visible on the rear tabs. Property sheets are particularly useful for managing large numbers of properties or settings that fall fairly neatly into several groups. Typically, one property sheet can simplify a user interface by replacing several separate dialog boxes.  
  
 As of MFC version 4.0, property sheets and property pages are implemented using the common controls that come with Windows 95 and Windows NT version 3.51 and later.  
  
 Property sheets are implemented with classes [CPropertySheet](../VS_csharp/cpropertysheet-class.md) and [CPropertyPage](../VS_csharp/cpropertypage-class.md) (described in the *MFC Reference*). `CPropertySheet` defines the overall dialog box, which can contain multiple "pages" based on `CPropertyPage`.  
  
 For information on creating and working with property sheets, see the topic [Property Sheets](../VS_csharp/property-sheets--mfc-.md).  
  
## See Also  
 [Dialog Boxes](../VS_csharp/dialog-boxes.md)   
 [Life Cycle of a Dialog Box](../VS_csharp/life-cycle-of-a-dialog-box.md)   
 [Property Sheets and Property Pages in MFC](../VS_csharp/property-sheets-and-property-pages-in-mfc.md)   
 [Exchanging Data](../VS_csharp/exchanging-data.md)   
 [Creating a Modeless Property Sheet](../VS_csharp/creating-a-modeless-property-sheet.md)   
 [Handling the Apply Button](../VS_csharp/handling-the-apply-button.md)