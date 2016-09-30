---
title: "CMFCToolBarImages::Load"
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
  - "Load"
  - "CMFCToolBarImages::Load"
  - "CMFCToolBarImages.Load"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Load method"
ms.assetid: e2a51953-d6da-4aeb-a2a8-0d2c704ccdc6
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarImages::Load
Loads toolbar images from system resources or from a file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The ID of a bitmap resource.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An instance of the resource DLL.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to add the loaded bitmap to the existing bitmap, or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to replace the existing bitmap.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A path to a disk file from which to load the bitmap.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Maximum number of bytes in the bitmap file; or 0 to load the bitmap regardless of file size. If the size of the file exceeds this maximum size, the method returns <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and does not load the bitmap.  
  
## Return Value  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> if the bitmap was loaded successfully; otherwise <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Remarks  
 If the file has the read-only attribute, the image list is marked as read-only.  
  
## Requirements  
 **Header:** afxtoolbarimages.h  
  
## See Also  
 [CMFCToolBarImages Class](../vs140/cmfctoolbarimages-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)