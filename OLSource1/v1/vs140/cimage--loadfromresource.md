---
title: "CImage::LoadFromResource"
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
  - "ATL.CImage.LoadFromResource"
  - "CImage.LoadFromResource"
  - "ATL::CImage::LoadFromResource"
  - "CImage::LoadFromResource"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LoadFromResource method"
ms.assetid: c5de2e82-ef62-4a4d-b085-b017326bc8d0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CImage::LoadFromResource
Loads an image from a `BITMAP` resource.  
  
## Syntax  
  
```  
  
      void LoadFromResource(  
   HINSTANCE hInstance,  
   LPCTSTR pszResourceName   
) throw();  
void LoadFromResource(  
   HINSTANCE hInstance,  
   UINT nIDResource   
) throw();  
```  
  
#### Parameters  
 `hInstance`  
 Handle to an instance of the module that contains the image to be loaded.  
  
 `pszResourceName`  
 A pointer to the string containing the name of the resource containing the image to load.  
  
 `nIDResource`  
 The ID of the resource to load.  
  
## Remarks  
 The resource must be of type `BITMAP`.  
  
## Requirements  
 **Header:** atlimage.h  
  
## See Also  
 [CImage Class](../vs140/cimage-class.md)   
 [CImage::Load](../vs140/cimage--load.md)