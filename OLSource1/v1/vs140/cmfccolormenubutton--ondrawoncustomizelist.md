---
title: "CMFCColorMenuButton::OnDrawOnCustomizeList"
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
  - "OnDrawOnCustomizeList"
  - "CMFCColorMenuButton::OnDrawOnCustomizeList"
  - "CMFCColorMenuButton.OnDrawOnCustomizeList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawOnCustomizeList method"
ms.assetid: dce7594e-b363-4582-8202-d36eb5881edc
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCColorMenuButton::OnDrawOnCustomizeList
Called by the framework before a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object is displayed in the list of a toolbar customization dialog box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A rectangle that bounds the button to be drawn.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> specifies that the button is in selected state; otherwise, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Return Value  
 The width of the button.  
  
## Remarks  
 This method is called by the framework when a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object is displayed in the list box during the toolbar customization process.  
  
## Requirements  
 **Header:** afxcolormenubutton.h  
  
## See Also  
 [CMFCColorMenuButton Class](../vs140/cmfccolormenubutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)