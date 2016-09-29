---
title: "Allocating GDI Resources"
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
  - "resources [MFC], printing"
  - "GDI objects, allocating during printing"
  - "printing [MFC], allocating GDI resources"
ms.assetid: cef7e94d-5a27-4aea-a9ee-8369fc895d3a
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Allocating GDI Resources
This article explains how to allocate and deallocate the Windows graphics device interface (GDI) objects needed for printing.  
  
> [!NOTE]
>  GDI+ is included with Windows XP and is available as a redistributable for Windows NT 4.0  SP6, Windows 2000, Windows 98, and Windows Me. To download the latest redistributable, see  [http://www.microsoft.com/msdownload/platformsdk/sdkupdate/psdkredist.htm](http://www.microsoft.com/msdownload/platformsdk/sdkupdate/psdkredist.htm). For more information, see the GDI+ SDK documentation in MSDN: [http://msdn.microsoft.com/library/default.asp?url=/library/gdicpp/GDIPlus/GDIPlus.asp](http://msdn.microsoft.com/library/default.asp?url=/library/gdicpp/GDIPlus/GDIPlus.asp).  
  
 Suppose you need to use certain fonts, pens, or other GDI objects for printing, but not for screen display. Because of the memory they require, it's inefficient to allocate these objects when the application starts up. When the application isn't printing a document, that memory might be needed for other purposes. It's better to allocate them when printing begins, and then delete them when printing ends.  
  
 To allocate these GDI objects, override the [OnBeginPrinting](../vs140/cview--onbeginprinting.md) member function. This function is well suited to this purpose for two reasons: the framework calls this function once at the beginning of each print job and, unlike [OnPreparePrinting](../vs140/cview--onprepareprinting.md), this function has access to the [CDC](../vs140/cdc-class.md) object representing the printer device driver. You can store these objects for use during the print job by defining member variables in your view class that point to GDI objects (for example, **CFont \*** members, and so on).  
  
 To use the GDI objects you've created, select them into the printer device context in the [OnPrint](../vs140/cview--onprint.md) member function. If you need different GDI objects for different pages of the document, you can examine the `m_nCurPage` member of the [CPrintInfo](../vs140/cprintinfo-structure.md) structure and select the GDI object accordingly. If you need a GDI object for several consecutive pages, Windows requires that you select it into the device context each time `OnPrint` is called.  
  
 To deallocate these GDI objects, override the [OnEndPrinting](../vs140/cview--onendprinting.md) member function. The framework calls this function at the end of each print job, giving you the opportunity to deallocate printing-specific GDI objects before the application returns to other tasks.  
  
## See Also  
 [Printing](../vs140/printing.md)   
 [How Default Printing Is Done](../vs140/how-default-printing-is-done.md)