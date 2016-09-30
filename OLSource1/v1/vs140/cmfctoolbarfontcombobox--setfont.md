---
title: "CMFCToolBarFontComboBox::SetFont"
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
  - "CMFCToolBarFontComboBox.SetFont"
  - "CMFCToolBarFontComboBox::SetFont"
  - "SetFont"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetFont method"
ms.assetid: aa5259ab-afee-4283-8694-d525b33ca18f
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarFontComboBox::SetFont
Selects the font in the font combo box according to the font name and character set that are specified in the parameters.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the font name or prefix.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the character set.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies whether <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> contains the font name or the font prefix.  
  
## Return Value  
 Nonzero if the font was selected successfully; otherwise 0.  
  
## Remarks  
 If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, this method selects a font that exactly matches the name that you specified as <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, this method selects a font that starts with the text specified as <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and that uses the character set that you specified as <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is set to DEFAULT_CHARSET, the character set will be ignored and only <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> will be used to select a font.  
  
## Requirements  
 **Header:** afxtoolbarfontcombobox.h  
  
## See Also  
 [CMFCToolBarFontComboBox Class](../vs140/cmfctoolbarfontcombobox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)