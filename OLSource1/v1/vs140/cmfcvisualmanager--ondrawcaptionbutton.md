---
title: "CMFCVisualManager::OnDrawCaptionButton"
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
  - "OnDrawCaptionButton"
  - "CMFCVisualManager::OnDrawCaptionButton"
  - "CMFCVisualManager.OnDrawCaptionButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawCaptionButton method"
ms.assetid: 5853657c-9968-4556-8b46-a9a508b66366
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnDrawCaptionButton
The framework calls this method when it draws a [CMFCCaptionButton](../vs140/cmfccaptionbutton-class.md) object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object. The framework draws this caption button.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A Boolean parameter that specifies whether the button is active.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A Boolean parameter that specifies whether the caption is horizontal.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A Boolean parameter that specifies whether the parent pane is maximized.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A Boolean parameter that specifies whether the caption button is disabled.  
  
 [in] <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The image index for the icon to use for the button. If <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is -1, this method uses the image index recorded in <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Remarks  
 The default implementation of this method displays a small button from the global instance of the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> class. The buttons are listed in the header file for <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. Some examples include <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
 Override this method in a derived class to customize the appearance of caption buttons.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCCaptionButton Class](../vs140/cmfccaptionbutton-class.md)