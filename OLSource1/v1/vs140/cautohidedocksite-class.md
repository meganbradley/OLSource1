---
title: "CAutoHideDockSite Class"
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
  - "CAutoHideDockSite"
  - "AllowShowOnPaneMenu"
  - "CAutoHideDockSite::AllowShowOnPaneMenu"
  - "CAutoHideDockSite.AllowShowOnPaneMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AllowShowOnPaneMenu method"
  - "CAutoHideDockSite class"
ms.assetid: 2a0f6bec-c369-4ab7-977d-564e7946ebad
caps.latest.revision: 32
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAutoHideDockSite Class
The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> extends the [CDockSite Class](../vs140/cdocksite-class.md) to implement auto-hide dock panes.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|||  
|-|-|  
|Name|Description|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Constructs a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Destructor.|  
  
### Public Methods  
  
|||  
|-|-|  
|Name|Description|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Indicates whether the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is shown on the pane menu.|  
|[CAutoHideDockSite::CanAcceptPane](#cautohidedocksite__canacceptpane)|Determines whether a base pane object is derived from the [CMFCAutoHideBar Class](../vs140/cmfcautohidebar-class.md).|  
|[CAutoHideDockSite::DockPane](#cautohidedocksite__dockpane)|Docks a pane to this <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object.|  
|[CAutoHideDockSite::GetAlignRect](#cautohidedocksite__getalignrect)|Retrieves the size of the dock site in screen coordinates.|  
|[CAutoHideDockSite::RepositionPanes](#cautohidedocksite__repositionpanes)|Redraws the pane on the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> with the global margins and button spacing.|  
|[CAutoHideDockSite::SetOffsetLeft](#cautohidedocksite__setoffsetleft)|Sets the margin on the left side of the docking bar.|  
|[CAutoHideDockSite::SetOffsetRight](#cautohidedocksite__setoffsetright)|Sets the margin on the right side of the docking bar.|  
|[CAutoHideDockSite::UnSetAutoHideMode](#cautohidedocksite__unsetautohidemode)|Calls [CMFCAutoHideBar::UnSetAutoHideMode](../vs140/cmfcautohidebar-class.md#cmfcautohidebar__unsetautohidemode) for objects on the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.|  
  
### Data Members  
  
|||  
|-|-|  
|Name|Description|  
|[CAutoHideDockSite::m_nExtraSpace](#cautohidedocksite__m_nextraspace)|Defines the size of the space between the toolbars and the edge of the docking bar. This space is measured from either the left edge or the top edge, depending on the alignment for the dock space.|  
  
## Remarks  
 When you call [CFrameWndEx::EnableAutoHidePanes](../vs140/cframewndex-class.md#cframewndex__enableautohidepanes), the framework automatically creates a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object. In most cases, you should not have to instantiate or use this class directly.  
  
 The docking bar is the gap between the left side of the dock pane and the left side of the [CMFCAutoHideButton Class](../vs140/cmfcautohidebutton-class.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CBasePane](../vs140/cbasepane-class.md)  
  
 [CDockSite](../vs140/cdocksite-class.md)  
  
## Example  
 The following example demonstrates how to retrieve a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object from a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object, and how to set the left and right margins of the docking bar.  
  
 [!code[NVC_MFC_RibbonApp#29](../vs140/codesnippet/CPP/cautohidedocksite-class_1.cpp)]  
  
## Requirements  
 **Header:** afxautohidedocksite.h  
  
##  \<a name="cautohidedocksite__canacceptpane">\</a>  CAutoHideDockSite::CanAcceptPane  
 Determines whether a base pane is a [CMFCAutoHideBar](../vs140/cmfcautohidebar-class.md) object or derived from <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|The base pane that the framework tests.|  
  
### Return Value  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is derived from <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>; <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
 If a base pane object is derived from <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, it can contain a [CAutoHideDockSite](../vs140/cautohidedocksite-class.md).  
  
##  \<a name="cautohidedocksite__dockpane">\</a>  CAutoHideDockSite::DockPane  
 Docks a pane to this [CAutoHideDockSite](../vs140/cautohidedocksite-class.md) object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|The pane that the framework docks.|  
|[in] <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|Docking options for the pane.|  
|[in] <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|A rectangle that specifies the boundaries for the docked pane.|  
  
### Remarks  
 The default implementation does not use the parameter <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, which is provided for future use.  
  
 If <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, the framework puts the pane in the default location on the dock site. If the dock site is horizontal, the default location is at the far left of the dock site. Otherwise, the default location is at the top of the dock site.  
  
##  \<a name="cautohidedocksite__getalignrect">\</a>  CAutoHideDockSite::GetAlignRect  
 Retrieves the size of the dock site in screen coordinates.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|A reference to a rectangle. The method stores the size of the dock site in this rectangle.|  
  
### Remarks  
 The rectangle is adjusted for the offset margins so that they are not included.  
  
##  \<a name="cautohidedocksite__m_nextraspace">\</a>  CAutoHideDockSite::m_nExtraSpace  
 The size of the space between the edges of the [CAutoHideDockSite Class](../vs140/cautohidedocksite-class.md) and the [CMFCAutoHideBar Class](../vs140/cmfcautohidebar-class.md) objects.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 When a <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> is docked at a <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, it should not occupy the whole dock site. This global variable controls the extra space between the left or top border of the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> and the corresponding <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> edge. Whether the top or left edge is used depends on the current alignment.  
  
##  \<a name="cautohidedocksite__setoffsetleft">\</a>  CAutoHideDockSite::SetOffsetLeft  
 Sets the margin on the left side of the docking bar.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 The new offset.  
  
### Remarks  
 [CMFCAutoHideBar](../vs140/cmfcautohidebar-class.md) objects are positioned statically on the [CAutoHideDockSite](../vs140/cautohidedocksite-class.md) object. This means that the user cannot manually change the location of <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> objects. The <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> method controls the spacing between the left side of the left-most <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> and the left side of the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>.  
  
##  \<a name="cautohidedocksite__setoffsetright">\</a>  CAutoHideDockSite::SetOffsetRight  
 Sets the margin on the right side of the docking bar.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 The new offset.  
  
### Remarks  
 [CMFCAutoHideBar](../vs140/cmfcautohidebar-class.md) objects are positioned statically on the [CAutoHideDockSite](../vs140/cautohidedocksite-class.md) object. This means that the user cannot manually change the location of the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> objects. The <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> method controls the spacing between the right side of the right-most <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> and the right side of the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>.  
  
##  \<a name="cautohidedocksite__repositionpanes">\</a>  CAutoHideDockSite::RepositionPanes  
 Redraws the panes on the [CAutoHideDockSite](../vs140/cautohidedocksite-class.md).  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|A reserved value.|  
  
### Remarks  
 The default implementation does not use <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>. It redraws the panes with the global toolbar margins and button spacing.  
  
##  \<a name="cautohidedocksite__unsetautohidemode">\</a>  CAutoHideDockSite::UnSetAutoHideMode  
 Calls [CMFCAutoHideBar::UnSetAutoHideMode](../vs140/cmfcautohidebar-class.md#cmfcautohidebar__unsetautohidemode) for objects on the dock site.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|A pointer to a [CMFCAutoHideBar](../vs140/cmfcautohidebar-class.md) object pane located on the [CAutoHideDockSite](../vs140/cautohidedocksite-class.md).|  
  
### Remarks  
 This method searches for the row that contains <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>. It calls <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> for all the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> objects on that row. If <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> is not found or it is <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>, this method calls <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> for all the <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> objects on the <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CDockSite Class](../vs140/cdocksite-class.md)