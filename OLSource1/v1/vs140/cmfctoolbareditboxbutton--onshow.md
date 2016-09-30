---
title: "CMFCToolBarEditBoxButton::OnShow"
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
  - "OnShow"
  - "CMFCToolBarEditBoxButton::OnShow"
  - "CMFCToolBarEditBoxButton.OnShow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnShow method"
ms.assetid: 329b6d76-3f89-4474-bda6-6ea774cae4c9
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarEditBoxButton::OnShow
Called by the framework when the button becomes visible or invisible.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies whether the button is visible. If this parameter is <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, the button is visible. Otherwise, the button is not visible.  
  
## Remarks  
 This method extends the base class implementation ([CMFCToolBarButton::OnShow](../vs140/cmfctoolbarbutton--onshow.md)) by displaying the button if <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. Otherwise, this method hides the button.  
  
## Requirements  
 **Header:** afxtoolbareditboxbutton.h  
  
## See Also  
 [CMFCToolBarEditBoxButton Class](../vs140/cmfctoolbareditboxbutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCToolBarButton::OnShow](../vs140/cmfctoolbarbutton--onshow.md)