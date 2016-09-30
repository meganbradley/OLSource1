---
title: "CMFCAutoHideButton::Create"
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
  - "Create"
  - "CMFCAutoHideButton::Create"
  - "CMFCAutoHideButton.Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method"
ms.assetid: bde758f0-a846-4858-8c7e-7ea79c68dc03
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCAutoHideButton::Create
Creates and initializes an auto-hide button.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the parent toolbar.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a [CDockablePane](../vs140/cdockablepane-class.md) object. This auto-hide button hides and shows that <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A value that specifies the alignment of the button with the main frame window.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 When you create a [CMFCAutoHideButton](../vs140/cmfcautohidebutton-class.md) object, you must associate the auto-hide button with a specific <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. The user can use the auto-hide button to hide and show the associated <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameter indicates where the auto-hide button resides in the application. The parameter can be any one of the following values:  
  
-   <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxautohidebutton.h  
  
## See Also  
 [CMFCAutoHideButton Class](../vs140/cmfcautohidebutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)