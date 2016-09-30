---
title: "CMFCMaskedEdit::EnableGetMaskedCharsOnly"
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
  - "CMFCMaskedEdit.EnableGetMaskedCharsOnly"
  - "EnableGetMaskedCharsOnly"
  - "CMFCMaskedEdit::EnableGetMaskedCharsOnly"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableGetMaskedCharsOnly method"
ms.assetid: 9e72c126-3dca-47ea-a410-8a8c71e1912a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCMaskedEdit::EnableGetMaskedCharsOnly
Specifies whether the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> method retrieves only masked characters.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to specify that the [CMFCMaskedEdit::GetWindowText](../vs140/cmfcmaskededit--getwindowtext.md) method retrieve only masked characters; <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to specify that the method retrieve the whole text. The default value is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Remarks  
 Use this method to enable retrieving masked characters. Then create a masked edit control that corresponds to the telephone number, such as (425) 555-0187. If you call the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> method, it returns "4255550187". If you disable retrieving masked characters, the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> method returns the text that is displayed in the edit control, for example "(425) 555-0187".  
  
## Requirements  
 **Header:** afxmaskededit.h  
  
## See Also  
 [CMFCMaskedEdit Class](../vs140/cmfcmaskededit-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)