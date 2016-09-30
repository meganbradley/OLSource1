---
title: "CMFCRibbonCustomizeDialog::CMFCRibbonCustomizeDialog"
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
  - "CMFCRibbonCustomizeDialog::CMFCRibbonCustomizeDialog"
  - "CMFCRibbonCustomizeDialog"
  - "CMFCRibbonCustomizeDialog.CMFCRibbonCustomizeDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCRibbonCustomizeDialog class, constructor"
ms.assetid: 1308a9ed-d13f-4ee9-9e19-5199322aeb35
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonCustomizeDialog::CMFCRibbonCustomizeDialog
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to the parent window (usually the main frame).  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> that is to be customized.  
  
## Example  
 The following example demonstrates how to construct a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.  
  
 [!code[NVC_MFC_RibbonApp#18](../vs140/codesnippet/CPP/cmfcribboncustomizedialog--cmfcribboncustomizedialog_1.cpp)]  
  
## Remarks  
 The constructor instantiates a [CMFCRibbonCustomizePropertyPage Class](../vs140/cmfcribboncustomizepropertypage-class.md) object and adds it to the collection of property sheet pages.  
  
## Requirements  
 **Header:** afxribboncustomizedialog.h  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCRibbonCustomizeDialog Class](../vs140/cmfcribboncustomizedialog-class.md)