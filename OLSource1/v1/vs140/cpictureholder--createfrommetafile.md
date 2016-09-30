---
title: "CPictureHolder::CreateFromMetafile"
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
  - "CPictureHolder::CreateFromMetafile"
  - "CreateFromMetafile"
  - "CPictureHolder.CreateFromMetafile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateFromMetafile method"
ms.assetid: 7252ec30-ddfd-4108-8be1-1238108731be
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPictureHolder::CreateFromMetafile
Uses a metafile to initialize the picture object in a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Handle to the metafile used to create the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object.  
  
 *xExt*  
 X extent of the picture.  
  
 *yExt*  
 Y extent of the picture.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Indicates whether the picture object will take ownership of the metafile object.  
  
## Return Value  
 Nonzero if the object is successfully created; otherwise 0.  
  
## Remarks  
 If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is **TRUE**, the caller should not use the metafile object in any way after this call returns. If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is **FALSE**, the caller is responsible for ensuring that the metafile object remains valid for the lifetime of the picture object.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CPictureHolder Class](../vs140/cpictureholder-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPictureHolder::CreateEmpty](../vs140/cpictureholder--createempty.md)   
 [CPictureHolder::CreateFromBitmap](../vs140/cpictureholder--createfrombitmap.md)   
 [CPictureHolder::CreateFromIcon](../vs140/cpictureholder--createfromicon.md)