---
title: "CMFCMaskedEdit::EnableSelectByGroup"
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
  - "EnableSelectByGroup"
  - "CMFCMaskedEdit::EnableSelectByGroup"
  - "CMFCMaskedEdit.EnableSelectByGroup"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableSelectByGroup method"
ms.assetid: 85466263-144d-494b-bc6a-f5d3c96ab8af
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCMaskedEdit::EnableSelectByGroup
Specifies whether the masked edit control allows the user to select particular groups input, or all input.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to select only groups; <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to select the whole text. The default value is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Remarks  
 Use this function to specify whether the masked edit control allows a user to select by group or the whole text.  
  
 By default, selection by group is enabled. In this case the user can select only continuous groups of valid characters.  
  
 For example, you might use the following masked edit control to validate a telephone number:  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
 If selection by group is enabled, the user can retrieve only the "425", "555", or "0187" string groups. If group selection is disabled the user can retrieve the whole text of the telephone number: "(425) 555-0187".  
  
## Requirements  
 **Header:** afxmaskededit.h  
  
## See Also  
 [CMFCMaskedEdit Class](../vs140/cmfcmaskededit-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)