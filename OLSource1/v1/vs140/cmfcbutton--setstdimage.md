---
title: "CMFCButton::SetStdImage"
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
  - "CMFCButton.SetStdImage"
  - "CMFCButton::SetStdImage"
  - "SetStdImage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetStdImage method"
ms.assetid: 61c117e6-1bc1-4ff0-9288-887c19593814
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCButton::SetStdImage
Uses a `CMenuImages` object to set the button image.  
  
## Syntax  
  
```  
void SetStdImage(  
   CMenuImages::IMAGES_IDS id,  
   CMenuImages::IMAGE_STATE state=CMenuImages::ImageBlack,  
   CMenuImages::IMAGES_IDS idDisabled=(CMenuImages::IMAGES_IDS)0   
);  
```  
  
#### Parameters  
 [in] `id`  
 One of the button image identifiers that is defined in the `CMenuImage::IMAGES_IDS` enumeration. The image values specify images such as arrows, pins, and radio buttons.  
  
 [in] `state`  
 One of the button image state identifiers that is defined in the `CMenuImages::IMAGE_STATE` enumeration. The image states specify button colors such as black, gray, light gray, white, and dark gray. The default value is `CMenuImages::ImageBlack`.  
  
 [in] `idDisabled`  
 One of the button image identifiers that is defined in the `CMenuImage::IMAGES_IDS` enumeration. The image indicates that the button is disabled. The default value is the first button image (`CMenuImages::IdArrowDown`).  
  
## Remarks  
  
## Requirements  
 **Header:** afxbutton.h  
  
## See Also  
 [CMFCButton Class](../vs140/cmfcbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)