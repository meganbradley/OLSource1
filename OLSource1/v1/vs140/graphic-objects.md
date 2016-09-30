---
title: "Graphic Objects"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "HRGN"
  - "HFONT"
  - "HBITMAP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CRgn class, HRGN handle type"
  - "HPEN"
  - "objects [C++], graphic"
  - "palettes, creating in device context"
  - "pens, creating in device context"
  - "bitmaps [C++], creating in device contexts"
  - "palette objects"
  - "memory [C++], display contexts"
  - "MFC, graphic objects"
  - "regions, creating in device context"
  - "CPen class, HPEN handle type"
  - "GDI objects [C++]"
  - "HRGN"
  - "graphic objects"
  - "GDI objects [C++], graphic-object classes"
  - "CFont class, HFONT handle type"
  - "HFONT and class CFont"
  - "HBITMAP and class CBitmap"
  - "fonts [C++], creating in device context"
  - "images [C++], graphic objects"
  - "CBitmap class, HBITMAP handle type"
  - "HPALETTE and class CPalette"
  - "CBrush class, HBRUSH handle type"
  - "objects [C++], graphic objects"
  - "drawing, in device contexts"
  - "device contexts, graphic objects"
  - "brushes, creating in device context"
  - "region objects"
  - "pen objects"
  - "GDI [C++], graphic-object classes"
  - "graphic objects, creating in device context"
  - "HBRUSH and class CBrush"
  - "painting and device context"
  - "CPalette class, HPALETTE handle type"
ms.assetid: 41963b25-34b7-4343-8446-34ba516b83ca
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Graphic Objects
Windows provides a variety of drawing tools to use in device contexts. It provides pens to draw lines, brushes to fill interiors, and fonts to draw text. MFC provides graphic-object classes equivalent to the drawing tools in Windows. The table below shows the available classes and the equivalent Windows graphics device interface (GDI) handle types.  
  
> [!NOTE]
>  GDI+ is included with Windows XP and is available as a redistributable for Windows NT 4.0  SP6, Windows 2000, Windows 98, and Windows Me. To download the latest redistributable, see  [http://www.microsoft.com/msdownload/platformsdk/sdkupdate/psdkredist.htm](http://www.microsoft.com/msdownload/platformsdk/sdkupdate/psdkredist.htm). For more information, see the GDI+ SDK documentation in MSDN: [http://msdn.microsoft.com/library/default.asp?url=/library/gdicpp/GDIPlus/GDIPlus.asp](http://msdn.microsoft.com/library/default.asp?url=/library/gdicpp/GDIPlus/GDIPlus.asp).  
  
 This article explains the use of these graphic-object classes:  
  
### Classes for Windows GDI Objects  
  
|Class|Windows handle type|  
|-----------|-------------------------|  
|[CPen](../vs140/cpen-class.md)|<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>|  
|[CBrush](../vs140/cbrush-class.md)|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|  
|[CFont](../vs140/cfont-class.md)|**HFONT**|  
|[CBitmap](../vs140/cbitmap-class.md)|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|  
|[CPalette](../vs140/cpalette-class.md)|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|  
|[CRgn](../vs140/crgn-class.md)|**HRGN**|  
  
> [!NOTE]
>  The class [CImage](../vs140/cimage-class.md) provides enhanced bitmap support.  
  
 Each graphic-object class in the class library has a constructor that allows you to create graphic objects of that class, which you must then initialize with the appropriate create function, such as <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 Each graphic-object class in the class library has a cast operator that will cast an MFC object to the associated Windows handle. The resulting handle is valid until the associated object detaches it. Use the object's **Detach** member function to detach the handle.  
  
 The following code casts a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object to a Windows handle:  
  
 [!code[NVC_MFCDocViewSDI#5](../vs140/codesnippet/CPP/graphic-objects_1.cpp)]  
  
#### To create a graphic object in a device context  
  
1.  Define a graphic object on the stack frame. Initialize the object with the type-specific create function, such as <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. Alternatively, initialize the object in the constructor. See the discussion of [one-stage and two-stage creation](../vs140/one-stage-and-two-stage-construction-of-objects.md), which provides example code.  
  
2.  [Select the object into the current device context](../vs140/selecting-a-graphic-object-into-a-device-context.md), saving the old graphic object that was selected before.  
  
3.  When done with the current graphic object, select the old graphic object back into the device context to restore its state.  
  
4.  Allow the frame-allocated graphic object to be deleted automatically when the scope is exited.  
  
> [!NOTE]
>  If you will be using a graphic object repeatedly, you can allocate it once and select it into a device context each time it is needed. Be sure to delete such an object when you no longer need it.  
  
### What do you want to know more about?  
  
-   [One-stage and two-stage construction of graphic objects](../vs140/one-stage-and-two-stage-construction-of-objects.md)  
  
-   [Example of constructing a pen in one and two stages](../vs140/one-stage-and-two-stage-construction-of-objects.md)  
  
-   [Selecting a Graphic Object into a Device Context](../vs140/selecting-a-graphic-object-into-a-device-context.md)  
  
-   [Device contexts](../vs140/device-contexts.md)  
  
-   [CImage limitations with earlier operating systems](../vs140/cimage-limitations-with-earlier-operating-systems.md)  
  
## See Also  
 [Window Objects](../vs140/window-objects.md)