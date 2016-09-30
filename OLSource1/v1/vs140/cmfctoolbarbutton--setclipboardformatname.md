---
title: "CMFCToolBarButton::SetClipboardFormatName"
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
  - "CMFCToolBarButton.SetClipboardFormatName"
  - "SetClipboardFormatName"
  - "CMFCToolBarButton::SetClipboardFormatName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetClipboardFormatName method"
ms.assetid: cb2db3a6-0f55-4742-8c2b-fecfdddca867
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarButton::SetClipboardFormatName
Renames the global clipboard format.  
  
## Syntax  
  
```  
static void __stdcall SetClipboardFormatName(  
   LPCTSTR lpszName  
);  
```  
  
#### Parameters  
 [in] `lpszName`  
 The new name of the global clipboard format. Cannot be `NULL`.  
  
## Remarks  
 This method makes it possible for drag-and-drop operations to occur among multiple applications. Each application must supply the same clipboard format name.  
  
 You must call this method before the framework calls [CMFCToolBarButton::GetClipboardFormat](../vs140/cmfctoolbarbutton--getclipboardformat.md).  
  
## Requirements  
 **Header:** afxtoolbarbutton.h  
  
## See Also  
 [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCToolBarButton::GetClipboardFormat](../vs140/cmfctoolbarbutton--getclipboardformat.md)