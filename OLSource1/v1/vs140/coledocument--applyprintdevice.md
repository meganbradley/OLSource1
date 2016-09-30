---
title: "COleDocument::ApplyPrintDevice"
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
  - "COleDocument.ApplyPrintDevice"
  - "ApplyPrintDevice"
  - "COleDocument::ApplyPrintDevice"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ApplyPrintDevice method"
  - "COleDocument class, operations"
ms.assetid: 22ebf4f1-4757-46d3-a555-16a98f6117b7
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDocument::ApplyPrintDevice
Call this function to change the print-target device for all embedded [COleClientItem](../vs140/coleclientitem-class.md) items in your application's container document.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to a **DVTARGETDEVICE** data structure, which contains information about the new print-target device. Can be **NULL**.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to a **PRINTDLG** data structure, which contains information about the new print-target device. Can be **NULL**.  
  
## Return Value  
 Nonzero if the function was successful; otherwise 0.  
  
## Remarks  
 This function updates the print-target device for all items but does not refresh the presentation cache for those items. To update the presentation cache for an item, call [COleClientItem::UpdateLink](../vs140/coleclientitem--updatelink.md).  
  
 The arguments to this function contain information that OLE uses to identify the target device. The [PRINTDLG](http://msdn.microsoft.com/library/windows/desktop/ms646843) structure contains information that Windows uses to initialize the common Print dialog box. After the user closes the dialog box, Windows returns information about the user's selections in this structure. The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> member of a [CPrintDialog](../vs140/cprintdialog-class.md) object is a **PRINTDLG** structure.  
  
 For more information, see the [PRINTDLG](http://msdn.microsoft.com/library/windows/desktop/ms646843) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 For more information, see the [DVTARGETDEVICE](http://msdn.microsoft.com/library/windows/desktop/ms686613) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleDocument Class](../vs140/coledocument-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPrintDialog Class](../vs140/cprintdialog-class.md)