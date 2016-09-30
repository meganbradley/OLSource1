---
title: "CImageList::Copy"
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
  - "ILCF_MOVE"
  - "CImageList.Copy"
  - "ILCF_SWAP"
  - "CImageList::Copy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ILCF_MOVE"
  - "ILCF_SWAP"
  - "Copy method"
ms.assetid: 56929e17-d4de-4ece-940b-39826f438a54
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CImageList::Copy
This member function implements the behavior of the Win32 function [ImageList_Copy](http://msdn.microsoft.com/library/windows/desktop/bb761520), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *iDst*  
 The zero-based index of the image to be used as the destination of the copy operation.  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The zero-based index of the image to be used as the source of the copy operation.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The bit flag value that specifies the type of copy operation to be made. This parameter can be one of the following values:  
  
|Value|Meaning|  
|-----------|-------------|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The source image is copied to the destination image's index. This operation results in multiple instances of a given image. <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is the default.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|The source and destination images exchange positions within the image list.|  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object that is the target of the copy operation.  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Example  
 [!code[NVC_MFC_CImageList#6](../vs140/codesnippet/CPP/cimagelist--copy_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CImageList Class](../vs140/cimagelist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)