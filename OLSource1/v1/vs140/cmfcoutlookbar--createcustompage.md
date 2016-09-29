---
title: "CMFCOutlookBar::CreateCustomPage"
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
  - "CMFCOutlookBar.CreateCustomPage"
  - "CMFCOutlookBar::CreateCustomPage"
  - "CreateCustomPage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateCustomPage method"
ms.assetid: b9ab3576-ba10-4d05-8572-114ed7e27e27
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCOutlookBar::CreateCustomPage
Creates a custom Outlook bar tab.  
  
## Syntax  
  
```  
CMFCOutlookBarPane* CreateCustomPage(  
   LPCTSTR lpszPageName,  
   BOOL bActivatePage=TRUE,  
   DWORD dwEnabledDocking=CBRS_ALIGN_ANY,  
   BOOL bEnableTextLabels=TRUE   
);  
```  
  
#### Parameters  
 [in] `lpszPageName`  
 The page label.  
  
 [in] `bActivatePage`  
 If `TRUE`, the page becomes active upon creation.  
  
 [in] `dwEnabledDocking`  
 A combination of CBRS_ALIGN_ flags that specifies the enabled docking sides when the page is detached.  
  
 [in] `bEnableTextLabels`  
 If `TRUE`, the text labels are enabled for the buttons that reside on the page.  
  
## Return Value  
 A pointer to the newly created page, or `NULL` if the creation failed.  
  
## Remarks  
 Use this method to enable the users to create custom Outlook bar pages. You can create up to 100 pages per application. The page control IDs start from 0xF000. The creation fails if the total number of custom Outlook bar pages exceeds 100.  
  
 Use [CMFCOutlookBar::RemoveCustomPage](../vs140/cmfcoutlookbar--removecustompage.md) to delete custom pages.  
  
## Requirements  
 **Header:** afxoutlookbar.h  
  
## See Also  
 [CMFCOutlookBar Class](../vs140/cmfcoutlookbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)