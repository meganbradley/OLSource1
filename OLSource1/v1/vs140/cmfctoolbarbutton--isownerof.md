---
title: "CMFCToolBarButton::IsOwnerOf"
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
  - "CMFCToolBarButton.IsOwnerOf"
  - "IsOwnerOf"
  - "CMFCToolBarButton::IsOwnerOf"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsOwnerOf method"
ms.assetid: 08164f59-d9b3-4ed5-85b8-6cf42f8d4059
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarButton::IsOwnerOf
Determines whether the button is the owner of the provided window handle.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A window handle.  
  
## Return Value  
 Nonzero if the button is the owner of the provided window handle; otherwise 0.  
  
## Remarks  
 This method returns nonzero if <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> either refers to the direct window handle or is a child of the window handle that is associated with the button. This method returns 0 if <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxtoolbarbutton.h  
  
## See Also  
 [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)