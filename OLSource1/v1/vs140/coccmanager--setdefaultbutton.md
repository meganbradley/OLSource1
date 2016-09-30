---
title: "COccManager::SetDefaultButton"
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
  - "SetDefaultButton"
  - "COccManager.SetDefaultButton"
  - "COccManager::SetDefaultButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COccManager class, operations"
  - "SetDefaultButton method"
ms.assetid: 63b26245-a474-4bc2-baec-9a89fe7942aa
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COccManager::SetDefaultButton
Call this function to set the control as the default button.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the window containing the control.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Nonzero if the control should become the default button; otherwise zero.  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Remarks  
  
> [!NOTE]
>  The control must have the **OLEMISC_ACTSLIKEBUTTON** status bit set. For more information on **OLEMISC** flags, see the [OLEMISC](http://msdn.microsoft.com/library/windows/desktop/ms678497) topic in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxocc.h  
  
## See Also  
 [COccManager Class](../vs140/coccmanager-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControlSite::SetDefaultButton](../vs140/colecontrolsite--setdefaultbutton.md)