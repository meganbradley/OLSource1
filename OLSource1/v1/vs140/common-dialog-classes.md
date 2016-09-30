---
title: "Common Dialog Classes"
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
  - "dialog classes [C++]"
  - "dialog boxes [C++], Windows common dialogs"
  - "common dialog boxes [C++], common dialog classes"
  - "common dialog classes [C++]"
  - "MFC dialog boxes, Windows common dialogs"
  - "Windows common dialogs [C++]"
  - "dialog classes [C++], common"
  - "common dialog boxes [C++]"
ms.assetid: 5c4f6443-896c-4b05-a7df-8169fdadc71d
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Common Dialog Classes
In addition to class [CDialog](../vs140/cdialog-class.md), MFC supplies several classes derived from <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> that encapsulate commonly used dialog boxes, as shown in the following table. The dialog boxes encapsulated are called the "common dialog boxes" and are part of the Windows common dialog library (COMMDLG.DLL). The dialog-template resources and code for these classes are provided in the Windows common dialog boxes that are part of Windows versions 3.1 and later.  
  
### Common Dialog Classes  
  
|Derived dialog class|Purpose|  
|--------------------------|-------------|  
|[CColorDialog](../vs140/ccolordialog-class.md)|Lets user select colors.|  
|[CFileDialog](../vs140/cfiledialog-class.md)|Lets user select a filename to open or to save.|  
|[CFindReplaceDialog](../vs140/cfindreplacedialog-class.md)|Lets user initiate a find or replace operation in a text file.|  
|[CFontDialog](../vs140/cfontdialog-class.md)|Lets user specify a font.|  
|[CPrintDialog](../vs140/cprintdialog-class.md)|Lets user specify information for a print job.|  
|[CPrintDialogEx](../vs140/cprintdialogex-class.md)|Windows 2000 print property sheet.|  
  
 For more information about the common dialog classes, see the individual class names in the *MFC Reference*. MFC also supplies a number of standard dialog classes used for OLE. For information about these classes, see the base class, [COleDialog](../vs140/coledialog-class.md), in the *MFC Reference*.  
  
 Three other classes in MFC have dialog-like characteristics. For information about classes [CFormView](../vs140/cformview-class.md), [CRecordView](../vs140/crecordview-class.md), and [CDaoRecordView](../vs140/cdaorecordview-class.md), see the classes in the *MFC Reference*. For information about class [CDialogBar](../vs140/cdialogbar-class.md), see [Dialog Bars](../vs140/dialog-bars.md).  
  
## See Also  
 [Dialog Boxes](../vs140/dialog-boxes.md)   
 [Life Cycle of a Dialog Box](../vs140/life-cycle-of-a-dialog-box.md)   
 [Dialog Boxes in OLE](../vs140/dialog-boxes-in-ole.md)