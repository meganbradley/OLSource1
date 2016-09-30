---
title: "CMFCCaptionBar::Create"
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
  - "Create"
  - "CMFCCaptionBar.Create"
  - "CMFCCaptionBar::Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method"
ms.assetid: 212ea3db-85e5-4b59-b41c-7cfb76136fd2
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCCaptionBar::Create
Creates the caption bar control and attaches it to the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The logical OR combination of the caption bar styles.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The parent window of the caption bar control.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The ID of caption bar control.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The height, in pixels, of the caption bar control. If it is -1, the height is calculated according to the height of the icon, the text and the button that the caption bar control displays.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if the caption bar is in the message bar mode; <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> otherwise.  
  
## Return Value  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> if the caption bar control is created successfully; <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> otherwise.  
  
## Remarks  
 You construct a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object in two steps. First you call the constructor, and then you call the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> method, which creates the Windows control and attaches it to the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object.  
  
## Requirements  
 **Header:** afxcaptionbar.h  
  
## See Also  
 [CMFCCaptionBar Class](../vs140/cmfccaptionbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)