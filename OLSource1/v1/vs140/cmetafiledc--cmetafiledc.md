---
title: "CMetaFileDC::CMetaFileDC"
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
  - "CMetaFileDC::CMetaFileDC"
  - "CMetaFileDC.CMetaFileDC"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMetaFileDC class, constructor"
ms.assetid: fa5879ac-e6ee-4522-8b09-6d92f50eee26
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMetaFileDC::CMetaFileDC
Construct a `CMetaFileDC` object in two steps.  
  
## Syntax  
  
```  
  
CMetaFileDC( );  
```  
  
## Remarks  
 First, call `CMetaFileDC`, then call **Create**, which creates the Windows metafile device context and attaches it to the `CMetaFileDC` object.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CMetaFileDC Class](../vs140/cmetafiledc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMetaFileDC::Create](../vs140/cmetafiledc--create.md)