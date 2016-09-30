---
title: "CMFCToolBarImages::Save"
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
  - "CMFCToolBarImages.Save"
  - "CMFCToolBarImages::Save"
  - "Save"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Save method"
ms.assetid: 2a603999-37f8-4173-bc29-585fc7e4b10e
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarImages::Save
Stores the toolbar images in a file if this set of toolbar images contains user-defined images.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A path to a disk file.  
  
## Return Value  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if the toolbar images were saved successfully; otherwise <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Remarks  
 Call this method to store the user-defined images into a disk file. If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, the method stores the bitmap into the file from which the bitmap was loaded by the [CMFCToolBarImages::Load](../vs140/cmfctoolbarimages--load.md) method.  
  
## Requirements  
 **Header:** afxtoolbarimages.h  
  
## See Also  
 [CMFCToolBarImages Class](../vs140/cmfctoolbarimages-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)