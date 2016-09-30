---
title: "CMFCToolBarButton::GetImage"
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
  - "CMFCToolBarButton.GetImage"
  - "GetImage"
  - "CMFCToolBarButton::GetImage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetImage method"
ms.assetid: 2fc70de0-4a7c-429a-8c27-5db81af1c394
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarButton::GetImage
Retrieves the image index of the button.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The index of the image associated with this button.  
  
## Remarks  
 If the button has a user-defined image (that is, if <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> was <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> in the constructor), the returned index specifies an image in the collection of user-defined images (see [CMFCToolBar::GetUserImages](../vs140/cmfctoolbar--getuserimages.md)). Otherwise, the index specifies an image in the collection of images that are loaded from a resource file (see [CMFCToolBar::GetImages](../vs140/cmfctoolbar--getimages.md)). For more information about resource files, see [Working with Resource Files](../vs140/working-with-resource-files.md).  
  
## Requirements  
 **Header:** afxtoolbarbutton.h  
  
## See Also  
 [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBar::GetUserImages](../vs140/cmfctoolbar--getuserimages.md)   
 [CMFCToolBar::GetImages](../vs140/cmfctoolbar--getimages.md)   
 [Working with Resource Files](../vs140/working-with-resource-files.md)