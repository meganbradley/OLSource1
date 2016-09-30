---
title: "Creating a Rebar Control"
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
  - "rebar controls, creating"
  - "CReBarCtrl class, creating"
ms.assetid: 0a012e08-772b-4f6a-af86-7cb651d11d3e
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Creating a Rebar Control
[CReBarCtrl](../vs140/crebarctrl-class.md) objects should be created before the parent object is visible. This minimizes the possibilities of painting problems.  
  
 For instance, rebar controls (used in frame window objects) are commonly used as parent windows for toolbar controls. Therefore, the parent of the rebar control is the frame window object. Because the frame window object is the parent, the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> member function (of the parent) is an excellent place to create the rebar control.  
  
 To use a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object, you will typically follow these steps:  
  
### To use a CReBarCtrl object  
  
1.  Construct the [CReBarCtrl](../vs140/crebarctrl-class.md) object.  
  
2.  Call [Create](../vs140/crebarctrl--create.md) to create the Windows rebar common control and attach it to the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object, specifying any desired styles.  
  
3.  Load a bitmap, with a call to [CBitmap::LoadBitmap](../vs140/cbitmap--loadbitmap.md), to be used as the background of the rebar control object.  
  
4.  Create and initialize any child window objects (toolbars, dialog controls, and so on) that will be contained by the rebar control object.  
  
5.  Initialize a **REBARBANDINFO** structure with the necessary information for the band about to be inserted.  
  
6.  Call [InsertBand](../vs140/crebarctrl--insertband.md) to insert existing child windows (such as <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>) into the new rebar control. For more information on inserting bands into an existing rebar control, see [Rebar Controls and Bands](../vs140/rebar-controls-and-bands.md).  
  
## See Also  
 [Using CReBarCtrl](../vs140/using-crebarctrl.md)   
 [Controls (MFC)](../vs140/controls--mfc-.md)