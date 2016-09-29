---
title: "CFontDialog::CFontDialog"
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
  - "CFontDialog.CFontDialog"
  - "CFontDialog::CFontDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CFontDialog class, construction/destruction"
  - "CFontDialog class, constructor"
ms.assetid: c1aa08da-519c-4bcd-aec9-91bbc90494a1
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFontDialog::CFontDialog
Constructs a `CFontDialog` object.  
  
## Syntax  
  
```  
CFontDialog(  
   LPLOGFONT lplfInitial = NULL,  
   DWORD dwFlags = CF_EFFECTS | CF_SCREENFONTS,  
   CDC* pdcPrinter = NULL,  
   CWnd* pParentWnd = NULL   
);  
CFontDialog(   
   const CHARFORMAT& charformat,   
   DWORD dwFlags = CF_SCREENFONTS,   
   CDC* pdcPrinter = NULL,   
   CWnd* pParentWnd = NULL   
);  
```  
  
#### Parameters  
 l`plfInitial`  
 A pointer to a [LOGFONT](http://msdn.microsoft.com/library/windows/desktop/dd145037) data structure that allows you to set some of the font's characteristics.  
  
 `charFormat`  
 A pointer to a [CHARFORMAT](http://msdn.microsoft.com/library/windows/desktop/bb787881) data structure that allows you to set some of the font's characteristics in a rich edit control.  
  
 `dwFlags`  
 Specifies one or more choose-font flags. One or more preset values can be combined using the bitwise OR operator. If you modify the `m_cf.Flag`s structure member, be sure to use a bitwise OR operator in your changes to keep the default behavior intact. For details on each of these flags, see the description of the [CHOOSEFONT](http://msdn.microsoft.com/library/windows/desktop/ms646832) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 pdcPrinter  
 A pointer to a printer-device context. If supplied, this parameter points to a printer-device context for the printer on which the fonts are to be selected.  
  
 `pParentWnd`  
 A pointer to the font dialog box's parent or owner window.  
  
## Remarks  
 Note that the constructor automatically fills in the members of the `CHOOSEFONT` structure. You should only change these if you want a font dialog different than the default.  
  
> [!NOTE]
>  The first version of this function only exists when there is no rich edit control support.  
  
## Example  
 [!code[NVC_MFCDocView#78](../vs140/codesnippet/CPP/cfontdialog--cfontdialog_1.cpp)]  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CFontDialog Class](../vs140/cfontdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFontDialog::DoModal](../vs140/cfontdialog--domodal.md)