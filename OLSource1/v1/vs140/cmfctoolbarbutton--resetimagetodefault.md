---
title: "CMFCToolBarButton::ResetImageToDefault"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CMFCToolBarButton.ResetImageToDefault
  - ResetImageToDefault
  - CMFCToolBarButton::ResetImageToDefault
dev_langs: 
  - C++
helpviewer_keywords: 
  - ResetImageToDefault method
ms.assetid: 75ab7df4-8e0c-4ca0-b4dd-19cf9040fc37
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCToolBarButton::ResetImageToDefault
Sets to the default value the image that is associated with the button.  
  
## Syntax  
  
```  
virtual void ResetImageToDefault();  
```  
  
## Remarks  
 This method retrieves the default image from its parent toolbar by using the [CMFCToolBar::GetDefaultImage](../vs140/cmfctoolbar--getdefaultimage.md) method. If the button has no associated default image, this method sets the text label of the button according to its string resource by using the [CStringT::LoadString](../vs140/cstringt--loadstring.md) method. For more information about string resources, see [Working with Resource Files](../vs140/working-with-resource-files.md).  
  
 This method does nothing if the button has a user-defined image.  
  
## Requirements  
 **Header:** afxtoolbarbutton.h  
  
## See Also  
 [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCToolBar::GetDefaultImage](../vs140/cmfctoolbar--getdefaultimage.md)   
 [CStringT::LoadString](../vs140/cstringt--loadstring.md)   
 [Working with Resource Files](../vs140/working-with-resource-files.md)