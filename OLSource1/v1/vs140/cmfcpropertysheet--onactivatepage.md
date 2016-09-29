---
title: "CMFCPropertySheet::OnActivatePage"
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
  - "CMFCPropertySheet.OnActivatePage"
  - "CMFCPropertySheet::OnActivatePage"
  - "OnActivatePage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnActivatePage method"
ms.assetid: 1029d6d6-38eb-4a2b-9460-c3943a1ce779
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertySheet::OnActivatePage
Called by the framework when a property page is enabled.  
  
## Syntax  
  
```  
virtual void OnActivatePage(  
   CPropertyPage* pPage   
);  
```  
  
#### Parameters  
 [in] `pPage`  
 Pointer to a property page object that represents the enabled property page.  
  
## Remarks  
 By default, this method ensures that the enabled property page is scrolled into view. If the style of the current property sheet contains a Microsoft Outlook pane, this method sets the corresponding Outlook button to the checked state.  
  
## Requirements  
 **Header:** afxpropertysheet.h  
  
## See Also  
 [CMFCPropertySheet Class](../vs140/cmfcpropertysheet-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCPropertySheet::SetLook](../vs140/cmfcpropertysheet--setlook.md)