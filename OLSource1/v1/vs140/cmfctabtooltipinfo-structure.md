---
title: "CMFCTabToolTipInfo Structure"
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
  - "CMFCTabToolTipInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCTabToolTipInfo struct"
ms.assetid: 9c3b3fb9-1497-4d59-932b-0da9348dd5e2
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCTabToolTipInfo Structure
This structure provides information about the MDI tab that the user is hovering over.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCTabToolTipInfo::m_nTabIndex;](#cmfctabtooltipinfo__m_ntabindex)|Specifies the index of the tab control.|  
|[CMFCTabToolTipInfo::m_pTabWnd](#cmfctabtooltipinfo__m_ptabwnd)|A pointer to the tab control.|  
|[CMFCTabToolTipInfo::m_strText](#cmfctabtooltipinfo__m_strtext)|The tooltip text.|  
  
## Remarks  
 A pointer to a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> structure is passed as a parameter of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> message. This message is generated when MDI tabs are enabled and the user hovers over a tab control.  
  
## Example  
 The following example shows how <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is used in the [MDITabsDemo Sample: MFC Tabbed MDI Application](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_MDITabsDemo#2](../vs140/codesnippet/CPP/cmfctabtooltipinfo-structure_1.cpp)]  
  
## Inheritance Hierarchy  
 [CMFCTabToolTipInfo](../vs140/cmfctabtooltipinfo-structure.md)  
  
## Requirements  
 **Header:** afxbasetabctrl.h  
  
##  \<a name="cmfctabtooltipinfo__m_ntabindex">\</a>  CMFCTabToolTipInfo::m_nTabIndex  
 Specifies the index of the tab control.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 Index of the tab over which the user is hovering.  
  
### Example  
 The following example shows how <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is used in the [MDITabsDemo Sample: MFC Tabbed MDI Application](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_MDITabsDemo#2](../vs140/codesnippet/CPP/cmfctabtooltipinfo-structure_1.cpp)]  
  
##  \<a name="cmfctabtooltipinfo__m_ptabwnd">\</a>  CMFCTabToolTipInfo::m_pTabWnd  
 A pointer to the tab control.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Example  
 The following example shows how <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is used in the [MDITabsDemo Sample: MFC Tabbed MDI Application](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_MDITabsDemo#2](../vs140/codesnippet/CPP/cmfctabtooltipinfo-structure_1.cpp)]  
  
##  \<a name="cmfctabtooltipinfo__m_strtext">\</a>  CMFCTabToolTipInfo::m_strText  
 The tooltip text.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 If the string is empty, the tooltip is not displayed.  
  
### Example  
 The following example shows how <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is used in the [MDITabsDemo Sample: MFC Tabbed MDI Application](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_MDITabsDemo#2](../vs140/codesnippet/CPP/cmfctabtooltipinfo-structure_1.cpp)]  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMDIFrameWndEx::EnableMDITabs](../vs140/cmdiframewndex-class.md#cmdiframewndex__enablemditabs)   
 [CMDITabInfo::m_bTabCustomTooltips](../vs140/cmditabinfo-class.md#cmditabinfo__m_btabcustomtooltips)