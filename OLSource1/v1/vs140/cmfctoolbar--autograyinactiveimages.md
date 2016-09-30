---
title: "CMFCToolBar::AutoGrayInactiveImages"
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
  - "CMFCToolBar::AutoGrayInactiveImages"
  - "CMFCToolBar.AutoGrayInactiveImages"
  - "AutoGrayInactiveImages"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AutoGrayInactiveImages method"
ms.assetid: 6ef05d1d-2dc1-48d9-bf15-2ebe92477952
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::AutoGrayInactiveImages
Enable or disables the automatic generation of inactive button images.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A Boolean value that specifies whether to dim inactive images. If this parameter is <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, inactive images are dimmed. Otherwise, inactive images are not dimmed.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the luminance percentage for inactive images. If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, this value is ignored.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A Boolean value that specifies whether to redraw all toolbars in the application. If this parameter is <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, this method redraws all toolbars.  
  
## Remarks  
 If <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, the framework uses <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to generate inactive images from the regular images. Otherwise, you must provide the set of inactive images by using the [CMFCToolBar::GetColdImages](../vs140/cmfctoolbar--getcoldimages.md) method. By default, this option is disabled.  
  
 For more information about the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> parameter, see [CMFCToolBarImages::GrayImages](../vs140/cmfctoolbarimages--grayimages.md).  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBar::GetColdImages](../vs140/cmfctoolbar--getcoldimages.md)   
 [CMFCToolBarImages::GrayImages](../vs140/cmfctoolbarimages--grayimages.md)