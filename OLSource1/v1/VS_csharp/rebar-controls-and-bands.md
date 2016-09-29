---
title: "Rebar Controls and Bands"
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
  - "rebar controls, working with bands in"
  - "bands, in rebar controls"
ms.assetid: b647e7a5-9ea7-48b1-8e5f-096d104748f0
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Rebar Controls and Bands
The main purpose of a rebar control is to act as a container for child windows, common dialog controls, menus, toolbars, and so on. This containment is supported by the concept of a "band." Each rebar band can contain any combination of a gripper bar, a bitmap, a text label, and a child window.  
  
 Class `CReBarCtrl` has many member functions that you can use to retrieve, and manipulate, information for a specific rebar band:  
  
-   [GetBandCount](../Topic/CReBarCtrl::GetBandCount.md) Retrieves the number of current bands in the rebar control.  
  
-   [GetBandInfo](../Topic/CReBarCtrl::GetBandInfo.md) Initializes a **REBARBANDINFO** structure with information from the specified band. There is a corresponding [SetBandInfo](../Topic/CReBarCtrl::SetBandInfo.md) member function.  
  
-   [GetRect](../Topic/CReBarCtrl::GetRect.md) Retrieves the bounding rectangle of a specified band.  
  
-   [GetRowCount](../Topic/CReBarCtrl::GetRowCount.md) Retrieves the number of band rows in a rebar control.  
  
-   [IDToIndex](../Topic/CReBarCtrl::IDToIndex.md) Retrieves the index of a specified band.  
  
-   [GetBandBorders](../Topic/CReBarCtrl::GetBandBorders.md) Retrieves the borders of a band.  
  
 In addition to manipulation, several member functions are provided that allow you to operate on specific rebar bands.  
  
 [InsertBand](../Topic/CReBarCtrl::InsertBand.md) and [DeleteBand](../Topic/CReBarCtrl::DeleteBand.md) add and remove rebar bands. [MinimizeBand](../Topic/CReBarCtrl::MinimizeBand.md) and [MaximizeBand](../Topic/CReBarCtrl::MaximizeBand.md) affect the current size of a specific rebar band. [MoveBand](../Topic/CReBarCtrl::MoveBand.md) changes the index of a specific rebar band. [ShowBand](../Topic/CReBarCtrl::ShowBand.md) shows or hides a rebar band from the user.  
  
 The following example demonstrates adding a toolbar band (`m_wndToolBar`) to an existing rebar control (`m_wndReBar`). The band is described by initializing the `rbi` structure and then calling the `InsertBand` member function:  
  
 [!code[NVC_MFCControlLadenDialog#27](../VS_csharp/codesnippet/CPP/rebar-controls-and-bands_1.cpp)]  
  
## See Also  
 [Using CReBarCtrl](../VS_csharp/using-crebarctrl.md)   
 [Controls (MFC)](../VS_csharp/controls--mfc-.md)