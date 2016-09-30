---
title: "CMFCColorButton::SetDocumentColors"
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
  - "CMFCColorButton::SetDocumentColors"
  - "SetDocumentColors"
  - "CMFCColorButton.SetDocumentColors"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetDocumentColors method"
ms.assetid: 5cfc870d-e04e-4552-ae3f-60f1e60cad9f
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCColorButton::SetDocumentColors
Specifies a set of colors and the set's name. The set of colors is displayed using a [CMFCColorBar Class](../vs140/cmfccolorbar-class.md) object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the label to be displayed with the set of document colors.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A reference to a list of RGB values.  
  
## Remarks  
 A <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object maintains a list of RGB values that are transferred to a [CMFCColorBar Class](../vs140/cmfccolorbar-class.md) object. When the color bar is displayed, these colors are shown in a special section whose label is specified by the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter.  
  
## Requirements  
 **Header:** afxcolorbutton.h  
  
## See Also  
 [CMFCColorButton Class](../vs140/cmfccolorbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)