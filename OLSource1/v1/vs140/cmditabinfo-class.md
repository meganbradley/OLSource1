---
title: "CMDITabInfo Class"
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
  - "CMDITabInfo"
  - "CMDITabInfo.CMDITabInfo"
  - "CMDITabInfo::CMDITabInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMDITabInfo class"
  - "CMDITabInfo class, constructor"
ms.assetid: 988ae1b7-4f7f-4239-b88f-7e28b3291c5e
caps.latest.revision: 36
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDITabInfo Class
The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> class is used to pass parameters to [CMDIFrameWndEx::EnableMDITabbedGroups](../vs140/cmdiframewndex-class.md#cmdiframewndex__enablemditabbedgroups) method. Set members of this class to control the behavior of MDI tabbed groups.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Default constructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMDITabInfo::Serialize](#cmditabinfo__serialize)|Reads or writes this object from or to an archive.|  
  
### Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CMDITabInfo::m_bActiveTabCloseButton](#cmditabinfo__m_bactivetabclosebutton_)|Specifies whether a **Close** button is displayed on the label of the active tab.|  
|[CMDITabInfo::m_bAutoColor](#cmditabinfo__m_bautocolor)|Specifies whether to color the MDI tabs.|  
|[CMDITabInfo::m_bDocumentMenu](#cmditabinfo__m_bdocumentmenu)|Specifies whether the tab group displays a popup menu that shows a list of opened documents or displays scroll buttons.|  
|[CMDITabInfo::m_bEnableTabSwap](#cmditabinfo__m_benabletabswap)|Specifies whether the user can swap the positions of tabs by dragging.|  
|[CMDITabInfo::m_bFlatFrame;](#cmditabinfo__m_bflatframe)|Specifies whether tabs have a flat frame.|  
|[CMDITabInfo::m_bTabCloseButton](#cmditabinfo__m_btabclosebutton)|Specifies whether each tab label displays a **Close** button.|  
|[CMDITabInfo::m_bTabCustomTooltips](#cmditabinfo__m_btabcustomtooltips)|Specifies whether custom tooltips are enabled.|  
|[CMDITabInfo::m_bTabIcons](#cmditabinfo__m_btabicons)|Specifies whether to display icons on MDI tabs.|  
|[CMDITabInfo::m_nTabBorderSize](#cmditabinfo__m_ntabbordersize)|Specifies the border size of each tab window.|  
|[CMDITabInfo::m_style](#cmditabinfo__m_style)|Specifies the style of the tab labels.|  
|[CMDITabInfo::m_tabLocation](#cmditabinfo__m_tablocation)|Specifies whether the tabs labels are located at the top or the bottom of the page.|  
  
## Remarks  
 This class specifies the parameters of the MDI tab groups that the framework creates.  
  
## Example  
 The following example demonstrates how to set the values of the various member variables in <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> class.  
  
 [!code[NVC_MFC_MDITab#1](../vs140/codesnippet/CPP/cmditabinfo-class_1.cpp)]  
  
## Inheritance Hierarchy  
 [CMDITabInfo](../vs140/cmditabinfo-class.md)  
  
## Requirements  
 **Header:** afxmdiclientareawnd.h  
  
##  \<a name="cmditabinfo__m_bactivetabclosebutton_">\</a>  CMDITabInfo::m_bActiveTabCloseButton;  
 Specifies whether a **Close** button is displayed on the label of the active tab.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 If <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, the label of the active tab will display a **Close** button. The **Close** button will be removed from the right top corner of the tab area. Otherwise, the label of the active tab will not display a **Close** button. The **Close** button will appear in the right top corner of the tab area.  
  
##  \<a name="cmditabinfo__m_bautocolor">\</a>  CMDITabInfo::m_bAutoColor  
 Specifies whether each MDI tab has its own color.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 If <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, each tab will have its own color. The set of colors is managed by the MFC library. Otherwise, the tabs are displayed in white. The default value is <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
##  \<a name="cmditabinfo__m_bdocumentmenu">\</a>  CMDITabInfo::m_bDocumentMenu  
 Specifies whether each tab displays a popup menu that shows a list of  opened documents at the right edge of the tab area.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 If <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, each tab windows displays a popup menu that shows a list of opened documents at the right edge of the tab area; Otherwise, the tab window displays scroll buttons at the right edge of the tab area. The default value is <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
##  \<a name="cmditabinfo__m_benabletabswap">\</a>  CMDITabInfo::m_bEnableTabSwap  
 Specifies whether the user can swap the positions of tabs by dragging.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 If <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, the user can change the tabs positions by dragging the tabs. Otherwise, the user cannot change the tabs positions. The default value is <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
##  \<a name="cmditabinfo__m_bflatframe">\</a>  CMDITabInfo::m_bFlatFrame  
 Specifies whether each tab window has a flat frame.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="cmditabinfo__m_btabclosebutton">\</a>  CMDITabInfo::m_bTabCloseButton  
 Specifies whether each tab window displays a **Close** button.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Remarks  
 If <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, each tab window displays the **Close** button on the right edge of the tab. Otherwise, the **Close** button is not displayed. The default value is <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
##  \<a name="cmditabinfo__m_btabcustomtooltips">\</a>  CMDITabInfo::m_bTabCustomTooltips  
 Specifies whether the tabs display tooltips.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Remarks  
 If <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, the application sends an <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> message to the main frame. You can handle this message by using the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> macro.  
  
##  \<a name="cmditabinfo__m_btabicons">\</a>  CMDITabInfo::m_bTabIcons  
 Specifies whether to display icons on MDI tabs.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Remarks  
 If <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, icons are displayed on each MDI tab. Otherwise, icons are not displayed on tabs. The default value is <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
##  \<a name="cmditabinfo__m_ntabbordersize">\</a>  CMDITabInfo::m_nTabBorderSize  
 Specifies the border size, in pixels, of each tab window.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Remarks  
 [CMFCVisualManager::GetMDITabsBordersSize](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__getmditabsborderssize) returns the default value.  
  
##  \<a name="cmditabinfo__m_style">\</a>  CMDITabInfo::m_style  
 Specifies the style of the tab labels.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Remarks  
 Specify one of the following styles for the tab labels:  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 3D style.  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 Microsoft OneNote style.  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 Microsoft Visual Studio 2005 style.  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 3D style with rectangle tab labels.  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 Flat style with shared horizontal scroll bar.  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 3D style with round tab labels.  
  
##  \<a name="cmditabinfo__m_tablocation">\</a>  CMDITabInfo::m_tabLocation  
 Specifies whether the tabs labels are located at the top or the bottom of the page.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Remarks  
 Apply to the tabs one of the following location flags:  
  
-   LOCATION_BOTTOM: the tabs labels are located at the bottom of the page.  
  
-   LOCATION_TOP: the tabs labels are located at the top of the page  
  
##  \<a name="cmditabinfo__serialize">\</a>  CMDITabInfo::Serialize  
 Reads or writes this object from an archive or to an archive.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 A [CArchive Class](../vs140/carchive-class.md) object to serialize.  
  
## See Also  
 [CMDIFrameWndEx](../vs140/cmdiframewndex-class.md)   
 [MDI Tabbed Groups](../vs140/mdi-tabbed-groups.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)