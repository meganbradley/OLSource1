---
title: "CEditView::OnReplaceSel"
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
  - "OnReplaceSel"
  - "CEditView.OnReplaceSel"
  - "CEditView::OnReplaceSel"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Replace button"
  - "OnReplaceSel method"
  - "CEditView class, overridables"
ms.assetid: ed425db7-c941-409b-8a21-6b0029f1b72e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CEditView::OnReplaceSel
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder> calls <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> when the user selects the Replace button in the standard Replace dialog box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The text to be found.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the direction of the search. If **TRUE**, the search direction is toward the end of the buffer. If **FALSE**, the search direction is toward the beginning of the buffer.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Specifies whether the search is case sensitive. If **TRUE**, the search is case sensitive. If **FALSE**, the search is not case sensitive.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The text to replace the found text.  
  
## Remarks  
 After replacing the selection, this function searches the text in the buffer for the next occurrence of the text specified by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, in the direction specified by <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, with case sensitivity specified by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. The search is accomplished through a call to [FindText](../vs140/ceditview--findtext.md). If the text is not found, [OnTextNotFound](../vs140/ceditview--ontextnotfound.md) is called.  
  
 Override <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to change the way a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>-derived object replaces the selected text.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CEditView Class](../vs140/ceditview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CEditView::OnFindNext](../vs140/ceditview--onfindnext.md)   
 [CEditView::OnTextNotFound](../vs140/ceditview--ontextnotfound.md)   
 [CEditView::FindText](../vs140/ceditview--findtext.md)   
 [CEditView::OnReplaceAll](../vs140/ceditview--onreplaceall.md)