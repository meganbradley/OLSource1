---
title: "CCommonDialog Class"
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
  - "CCommonDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "dialog boxes [C++], Windows common dialogs"
  - "common dialog boxes [C++], common dialog classes"
  - "common dialog classes [C++]"
  - "MFC dialog boxes, Windows common dialogs"
  - "Windows common dialogs [C++]"
  - "CCommonDialog class"
  - "dialog classes [C++], common"
ms.assetid: 1f68d65f-a0fd-4778-be22-ebbe51a95f95
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCommonDialog Class
The base class for classes that encapsulate functionality of the Windows common dialogs.  
  
## Syntax  
  
```  
class CCommonDialog : public CDialog  
```  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CCommonDialog::CCommonDialog](#ccommondialog__ccommondialog)|Constructs a `CCommonDialog` object.|  
  
## Remarks  
 The following classes encapsulate the functionality of the Windows common dialogs:  
  
-   [CFileDialog](../VS_csharp/cfiledialog-class.md)  
  
-   [CFontDialog](../VS_csharp/cfontdialog-class.md)  
  
-   [CColorDialog](../VS_csharp/ccolordialog-class.md)  
  
-   [CPageSetupDialog](../VS_csharp/cpagesetupdialog-class.md)  
  
-   [CPrintDialog](../VS_csharp/cprintdialog-class.md)  
  
-   [CPrintDialogEx](../VS_csharp/cprintdialogex-class.md)  
  
-   [CFindReplaceDialog](../VS_csharp/cfindreplacedialog-class.md)  
  
-   [COleDialog](../VS_csharp/coledialog-class.md)  
  
## Inheritance Hierarchy  
 [CObject](../VS_csharp/cobject-class.md)  
  
 [CCmdTarget](../VS_csharp/ccmdtarget-class.md)  
  
 [CWnd](../VS_csharp/cwnd-class.md)  
  
 [CDialog](../VS_csharp/cdialog-class.md)  
  
 `CCommonDialog`  
  
## Requirements  
 **Header:** afxdlgs.h  
  
##  <a name="ccommondialog__ccommondialog"></a>  CCommonDialog::CCommonDialog  
 Constructs a `CCommonDialog` object.  
  
```  
explicit CCommonDialog(    CWnd*  pParentWnd );  
  
```  
  
### Parameters  
 `pParentWnd`  
 Points to the parent or owner window object (of type [CWnd](../VS_csharp/cwnd-class.md)) to which the dialog object belongs. If it is **NULL**, the dialog object's parent window is set to the main application window.  
  
### Remarks  
 See [CDialog::CDialog](../VS_csharp/cdialog-class.md#cdialog__cdialog) for complete information.  
  
## See Also  
 [Base Class](../VS_csharp/cdialog-class.md)   
 [Hierarchy Chart](../VS_csharp/hierarchy-chart.md)   
 [CFileDialog](../VS_csharp/cfiledialog-class.md)   
 [CFontDialog](../VS_csharp/cfontdialog-class.md)   
 [CColorDialog](../VS_csharp/ccolordialog-class.md)   
 [CPageSetupDialog](../VS_csharp/cpagesetupdialog-class.md)   
 [CPrintDialog](../VS_csharp/cprintdialog-class.md)   
 [CFindReplaceDialog](../VS_csharp/cfindreplacedialog-class.md)   
 [COleDialog](../VS_csharp/coledialog-class.md)