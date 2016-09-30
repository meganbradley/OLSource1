---
title: "CMFCColorPopupMenu Class"
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
  - "CMFCColorPopupMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCColorPopupMenu class"
ms.assetid: 0bf9efe8-aed5-4ab7-b23b-eb284b4668be
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCColorPopupMenu Class
Represents a pop-up menu that users use to select colors in a document or application.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|||  
|-|-|  
|Name|Description|  
|[CMFCColorPopupMenu::CMFCColorPopupMenu](#cmfccolorpopupmenu__cmfccolorpopupmenu)|Constructs a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Destructor.|  
  
### Public Methods  
  
|||  
|-|-|  
|Name|Description|  
|[CMFCColorPopupMenu::CreateTearOffBar](#cmfccolorpopupmenu__createtearoffbar)|Creates a dockable tear-off color bar. (Overrides [CMFCPopupMenu::CreateTearOffBar](../vs140/cmfcpopupmenu-class.md#cmfcpopupmenu__createtearoffbar).)|  
|[CMFCColorPopupMenu::GetMenuBar](#cmfccolorpopupmenu__getmenubar)|Returns the [CMFCPopupMenuBar](../vs140/cmfcpopupmenubar-class.md) that is embedded inside the pop-up menu. (Overrides [CMFCPopupMenu::GetMenuBar](../vs140/cmfcpopupmenu-class.md#cmfcpopupmenu__getmenubar).)|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Used by the framework to obtain a pointer to the [CRuntimeClass](../vs140/cruntimeclass-structure.md) object that is associated with this class type.|  
|[CMFCColorPopupMenu::SetPropList](#cmfccolorpopupmenu__setproplist)|Sets the property grid control object of the embedded <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.|  
  
### Data Members  
  
|||  
|-|-|  
|Name|Description|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|A Boolean value that determines whether to show the color bar.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object that provides color selection.|  
  
### Remarks  
 This class inherits the pop-up menu functionality of the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> class and manages a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object that provides color selection. When the toolbar framework is in customization mode and the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> member is set to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, the color bar object is not shown. For more information about customization mode, see [CMFCToolBar::IsCustomizeMode](../vs140/cmfctoolbar-class.md#cmfctoolbar__iscustomizemode)  
  
 For more information about <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, see [CMFCColorBar Class](../vs140/cmfccolorbar-class.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CFrameWnd](../vs140/cframewnd-class.md)  
  
 [CMiniFrameWnd](../vs140/cminiframewnd-class.md)  
  
 [CMFCPopupMenu](../vs140/cmfcpopupmenu-class.md)  
  
 [CMFCColorPopupMenu](../vs140/cmfccolorpopupmenu-class.md)  
  
## Requirements  
 **Header:** afxcolorpopupmenu.h  
  
##  \<a name="cmfccolorpopupmenu__cmfccolorpopupmenu">\</a>  CMFCColorPopupMenu::CMFCColorPopupMenu  
 Constructs a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 An array of colors that the framework displays on the pop-up menu.  
  
 [in] <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 The default selected color.  
  
 [in] <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 The text label of the *automatic* (default) color button, or <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
 The standard label for the automatic button is **Automatic**.  
  
 [in] <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 The text label of the *other* button, which displays more color choices, or <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
 The standard label for the other button is **More Colors...**.  
  
 [in] <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 The text label of the document colors button. The document colors palette lists all the colors that the document currently uses.  
  
 [in] <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 A list of colors that the document currently uses.  
  
 [in] <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 The number of columns that the array of colors has.  
  
 [in] <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 The number of rows that the color bar has when it is docked horizontally.  
  
 [in] <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 The number of columns that the color bar has when it is docked vertically.  
  
 [in] <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 The default color that the framework applies when you click the automatic button.  
  
 [in] <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 The color bar control command ID.  
  
 [in] <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 A Boolean that indicates whether to show the standard system color dialog box or the [CMFCColorDialog](../vs140/cmfccolordialog-class.md) dialog box.  
  
 [in] <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 A pointer to a parent button.  
  
 [in] <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 The command ID.  
  
### Remarks  
 Each overloaded constructor sets the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> member to <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>.  
  
### Example  
 The following example demonstrates how to construct a <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object.  
  
 [!code[NVC_MFC_RibbonApp#34](../vs140/codesnippet/CPP/cmfccolorpopupmenu-class_1.cpp)]  
  
##  \<a name="cmfccolorpopupmenu__createtearoffbar">\</a>  CMFCColorPopupMenu::CreateTearOffBar  
 Creates a dockable tear-off color bar.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|Pointer to the parent window of the tear-off bar.|  
|[in] <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|The command ID of the tear-off bar.|  
|[in] <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|The window text of the tear-off bar.|  
  
### Return Value  
 A pointer to the new tear-off control bar object.  
  
### Remarks  
 This method creates a [CMFCColorBar](../vs140/cmfccolorbar-class.md) object and casts it to a [CPane](../vs140/cpane-class.md) pointer. You can cast this value back to a [CMFCColorBar](../vs140/cmfccolorbar-class.md) pointer by using one of the casting macros described in [Type Casting of MFC Class Objects](../vs140/type-casting-of-mfc-class-objects.md).  
  
##  \<a name="cmfccolorpopupmenu__getmenubar">\</a>  CMFCColorPopupMenu::GetMenuBar  
 Returns the [CMFCPopupMenuBar](../vs140/cmfcpopupmenubar-class.md) that is embedded inside the pop-up menu.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the embedded <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.  
  
### Remarks  
 The color pop-up menu has an embedded [CMFCPopupMenuBar Class](../vs140/cmfcpopupmenubar-class.md) object. Override this method in a derived class if your application uses a different embedded type.  
  
##  \<a name="cmfccolorpopupmenu__setproplist">\</a>  CMFCColorPopupMenu::SetPropList  
 Sets the property grid control object of the embedded <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 Pointer to a property grid control object.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)