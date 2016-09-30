---
title: "CMFCToolBarsCustomizeDialog::GetCountInCategory"
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
  - "GetCountInCategory"
  - "CMFCToolBarsCustomizeDialog.GetCountInCategory"
  - "CMFCToolBarsCustomizeDialog::GetCountInCategory"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetCountInCategory method"
ms.assetid: b055c2fc-4427-4bd0-9023-f96f060c6ee9
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarsCustomizeDialog::GetCountInCategory
Retrieves the number of items in the provided list that have a given text label.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The text label to match.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A reference to a list that contains <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> objects.  
  
## Return Value  
 The number of items in the provided list whose text label equals <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Remarks  
 Each element in the provided object list must be of type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. This method compares <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> with the [CMFCToolBarButton::m_strText](../vs140/cmfctoolbarbutton--m_strtext.md) data member.  
  
## Requirements  
 **Header:** afxtoolbarscustomizedialog.h  
  
## See Also  
 [CMFCToolBarsCustomizeDialog Class](../vs140/cmfctoolbarscustomizedialog-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md)   
 [CMFCToolBarButton::m_strText](../vs140/cmfctoolbarbutton--m_strtext.md)