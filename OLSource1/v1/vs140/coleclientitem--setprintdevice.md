---
title: "COleClientItem::SetPrintDevice"
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
  - "COleClientItem::SetPrintDevice"
  - "SetPrintDevice"
  - "COleClientItem.SetPrintDevice"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetPrintDevice method"
  - "COleClientItem class, general operations"
ms.assetid: ca84dfc7-c53a-411e-9850-1e0faec4b2b1
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleClientItem::SetPrintDevice
Call this function to change the print-target device for this item.  
  
## Syntax  
  
```  
  
      BOOL SetPrintDevice(  
   const DVTARGETDEVICE* ptd   
);  
BOOL SetPrintDevice(  
   const PRINTDLG* ppd   
);  
```  
  
#### Parameters  
 `ptd`  
 Pointer to a [DVTARGETDEVICE](http://msdn.microsoft.com/library/windows/desktop/ms686613) data structure, which contains information about the new print-target device. Can be **NULL**.  
  
 `ppd`  
 Pointer to a [PRINTDLG](http://msdn.microsoft.com/library/windows/desktop/ms646940) data structure, which contains information about the new print-target device. Can be **NULL**.  
  
## Return Value  
 Nonzero if the function was successful; otherwise 0.  
  
## Remarks  
 This function updates the print-target device for the item but does not refresh the presentation cache. To update the presentation cache for an item, call [UpdateLink](../vs140/coleclientitem--updatelink.md).  
  
 The arguments to this function contain information that the OLE system uses to identify the target device. The **PRINTDLG** structure contains information that Windows uses to initialize the common Print dialog box. After the user closes the dialog box, Windows returns information about the user's selections in this structure. The `m_pd` member of a [CPrintDialog](../vs140/cprintdialog-class.md) object is a **PRINTDLG** structure.  
  
 For more information about this structure, see [PRINTDLG](http://msdn.microsoft.com/library/windows/desktop/ms646843) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 For more information, see [DVTARGETDEVICE](http://msdn.microsoft.com/library/windows/desktop/ms686613) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleClientItem::UpdateLink](../vs140/coleclientitem--updatelink.md)   
 [CPrintDialog Class](../vs140/cprintdialog-class.md)