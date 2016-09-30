---
title: "CMFCVisualManager::OnDrawSpinButtons"
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
  - "CMFCVisualManager.OnDrawSpinButtons"
  - "CMFCVisualManager::OnDrawSpinButtons"
  - "OnDrawSpinButtons"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawSpinButtons method"
ms.assetid: aaf8274c-4d47-44fd-ab73-f7f2bf0f6fe8
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnDrawSpinButtons
The framework calls this method when it draws an instance of the [CMFCSpinButtonCtrl Class](../vs140/cmfcspinbuttonctrl-class.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the spin control.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A flag that indicates the state of the spin control. See the Remarks section for more information.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A Boolean parameter that specifies the orientation of the spin control. A value of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> indicates the spin control is horizontal. Otherwise, it is vertical.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A pointer to a spin control. The framework draws the buttons for this control.  
  
## Remarks  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameter indicates the state of the spin control. The parameter is one of the following values:  
  
-   AFX_SPIN_PRESSEDUP  
  
-   AFX_SPIN_PRESSEDDOWN  
  
-   AFX_SPIN_HIGHLIGHTEDUP  
  
-   AFX_SPIN_HIGHLIGHTEDDOWN  
  
-   AFX_SPIN_DISABLED  
  
 Override this method in a derived visual manager to customize the appearance of a spin control.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCSpinButtonCtrl Class](../vs140/cmfcspinbuttonctrl-class.md)