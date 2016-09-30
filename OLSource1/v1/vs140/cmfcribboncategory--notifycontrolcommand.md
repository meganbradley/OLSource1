---
title: "CMFCRibbonCategory::NotifyControlCommand"
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
  - "NotifyControlCommand"
  - "CMFCRibbonCategory::NotifyControlCommand"
  - "CMFCRibbonCategory.NotifyControlCommand"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "NotifyControlCommand method"
ms.assetid: 418a0b04-a29f-456c-ad62-d2522f31a165
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonCategory::NotifyControlCommand
Delivers a WM_NOTIFY command message to all <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> elements in the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> until the message is handled.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if this command originated from an accelerator, or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> otherwise.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The notification code.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The WPARAM field of the message.  
  
 [in] <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The LPARAM field of the message.  
  
## Return Value  
 Returns <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> if the message was handled, or <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> if not.  
  
## Remarks  
  
## Requirements  
 **Header:** afxribboncategory.h  
  
## See Also  
 [CMFCRibbonCategory Class](../vs140/cmfcribboncategory-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)