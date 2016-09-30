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
  
 Class <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> has many member functions that you can use to retrieve, and manipulate, information for a specific rebar band:  
  
-   [GetBandCount](../vs140/crebarctrl--getbandcount.md) Retrieves the number of current bands in the rebar control.  
  
-   [GetBandInfo](../vs140/crebarctrl--getbandinfo.md) Initializes a **REBARBANDINFO** structure with information from the specified band. There is a corresponding [SetBandInfo](../vs140/crebarctrl--setbandinfo.md) member function.  
  
-   [GetRect](../vs140/crebarctrl--getrect.md) Retrieves the bounding rectangle of a specified band.  
  
-   [GetRowCount](../vs140/crebarctrl--getrowcount.md) Retrieves the number of band rows in a rebar control.  
  
-   [IDToIndex](../vs140/crebarctrl--idtoindex.md) Retrieves the index of a specified band.  
  
-   [GetBandBorders](../vs140/crebarctrl--getbandborders.md) Retrieves the borders of a band.  
  
 In addition to manipulation, several member functions are provided that allow you to operate on specific rebar bands.  
  
 [InsertBand](../vs140/crebarctrl--insertband.md) and [DeleteBand](../vs140/crebarctrl--deleteband.md) add and remove rebar bands. [MinimizeBand](../vs140/crebarctrl--minimizeband.md) and [MaximizeBand](../vs140/crebarctrl--maximizeband.md) affect the current size of a specific rebar band. [MoveBand](../vs140/crebarctrl--moveband.md) changes the index of a specific rebar band. [ShowBand](../vs140/crebarctrl--showband.md) shows or hides a rebar band from the user.  
  
 The following example demonstrates adding a toolbar band (<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>) to an existing rebar control (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>). The band is described by initializing the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> structure and then calling the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> member function:  
  
 [!code[NVC_MFCControlLadenDialog#27](../vs140/codesnippet/CPP/rebar-controls-and-bands_1.cpp)]  
  
## See Also  
 [Using CReBarCtrl](../vs140/using-crebarctrl.md)   
 [Controls (MFC)](../vs140/controls--mfc-.md)