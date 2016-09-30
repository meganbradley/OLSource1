---
title: "CMFCToolBarsCustomizeDialog::PostNcDestroy"
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
  - "CMFCToolBarsCustomizeDialog::PostNcDestroy"
  - "PostNcDestroy"
  - "CMFCToolBarsCustomizeDialog.PostNcDestroy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PostNcDestroy method"
ms.assetid: a44c64cc-048a-4791-8fef-70224eeadd12
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarsCustomizeDialog::PostNcDestroy
Called by the framework after the window has been destroyed.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 This method extends the base class implementation, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, by restoring the application to the previous mode.  
  
 The [CMFCToolBarsCustomizeDialog::Create](../vs140/cmfctoolbarscustomizedialog--create.md) method puts the application in a special mode that limits the user to customization tasks.  
  
## Requirements  
 **Header:** afxtoolbarscustomizedialog.h  
  
## See Also  
 [CMFCToolBarsCustomizeDialog Class](../vs140/cmfctoolbarscustomizedialog-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCToolBarsCustomizeDialog::Create](../vs140/cmfctoolbarscustomizedialog--create.md)