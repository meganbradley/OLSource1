---
title: "CMFCToolBar::GetDefaultImage"
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
  - "CMFCToolBar::GetDefaultImage"
  - "GetDefaultImage"
  - "CMFCToolBar.GetDefaultImage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDefaultImage method"
ms.assetid: b44f27ec-9cee-4c83-aed9-18c2bbf81b95
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::GetDefaultImage
Returns the index of the default image for a toolbar button with a specified command ID.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the command ID of the button.  
  
## Return Value  
 The index of the toolbar image in the shared list of images.  
  
## Remarks  
 Use this shared method to retrieve the index of the default image for a toolbar button with the specified command ID. The return value is an index into the shared collection of toolbar button images for all toolbars in the application. Call the [CMFCToolBar::GetImages](../vs140/cmfctoolbar--getimages.md) method to obtain a pointer to this collection.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBar::GetImages](../vs140/cmfctoolbar--getimages.md)