---
title: "CMFCVisualManagerWindows7 Class"
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
  - "afxvisualmanagerwindows7/CMFCVisualManagerWindows7"
  - "CMFCVisualManagerWindows7"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCVisualManagerWindows7 class"
ms.assetid: e8d87df1-0c09-4b58-8ade-4e911f796e42
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManagerWindows7 Class
The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> gives an application the appearance of a [!INCLUDE[win7](../vs140/includes/win7_md.md)] application.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCVisualManagerWindows7::CMFCVisualManagerWindows7](#cmfcvisualmanagerwindows7__cmfcvisualmanagerwindows7)|Default constructor.|  
|[CMFCVisualManagerWindows7::~CMFCVisualManagerWindows7](#cmfcvisualmanagerwindows7__~cmfcvisualmanagerwindows7)|Default destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Clears the current visual style and resets the default visual style.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Clears all of the objects in the user interface and resets the menus.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Draws a button in the non-client area on the frame. The framework uses this method to draw minimize, maximize, close and restore buttons in the upper right corner of the window frame. This method is not called when the program uses a non-Aero theme.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Draws text in the non-client area on the frame. The framework uses this method to draw the application title in the title bar at the top of the frame window.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Draws a separator on the [CMFCToolBar Class](../vs140/cmfctoolbar-class.md).|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Retrieves the [CMFCRibbonBar Class](../vs140/cmfcribbonbar-class.md) associated with the user interface.|  
|[CMFCVisualManagerWindows7::GetRibbonEditBackgroundColor](#cmfcvisualmanagerwindows7__getribboneditbackgroundcolor)|Obtains a Ribbon edit box background color.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Overrides [CMFCVisualManager::GetRibbonPopupBorderSize](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__getribbonpopupbordersize)|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Overrides [CMFCVisualManager::GetRibbonQuickAccessToolBarChevronOffset](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__getribbonquickaccesstoolbarchevronoffset)|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Overrides [CMFCVisualManager::GetRibbonQuickAccessToolBarRightMargin](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__getribbonquickaccesstoolbarrightmargin)|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Overrides [CMFCVisualManagerWindows::IsHighlightWholeMenuItem](../vs140/cmfcvisualmanagerwindows-class.md#cmfcvisualmanagerwindows__ishighlightwholemenuitem)|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|Overrides [CMFCVisualManager::IsOwnerDrawMenuCheck](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__isownerdrawmenucheck)|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|Determines whether a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is present and visible.|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|Overrides [CMFCVisualManagerWindows::OnDrawButtonBorder](../vs140/cmfcvisualmanagerwindows-class.md#cmfcvisualmanagerwindows__ondrawbuttonborder)|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|Overrides [CMFCVisualManagerWindows::OnDrawCheckBoxEx](../vs140/cmfcvisualmanagerwindows-class.md#cmfcvisualmanagerwindows__ondrawcheckboxex)|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|Overrides [CMFCVisualManagerWindows::OnDrawComboDropButton](../vs140/cmfcvisualmanagerwindows-class.md#cmfcvisualmanagerwindows__ondrawcombodropbutton)|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|Overrides [CMFCVisualManager::OnDrawDefaultRibbonImage](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__ondrawdefaultribbonimage)|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|Overrides [CMFCVisualManagerWindows::OnDrawMenuBorder](../vs140/cmfcvisualmanagerwindows-class.md#cmfcvisualmanagerwindows__ondrawmenuborder)|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|Overrides [CMFCVisualManager::OnDrawMenuCheck](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__ondrawmenucheck)|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|Overrides [CMFCVisualManager::OnDrawMenuLabel](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__ondrawmenulabel)|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|Overrides <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|Overrides [CMFCVisualManager::OnDrawRibbonApplicationButton](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__ondrawribbonapplicationbutton)|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|Overrides [CMFCVisualManager::OnDrawRibbonButtonBorder](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__ondrawribbonbuttonborder)|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|Overrides [CMFCVisualManager::OnDrawRibbonCaption](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__ondrawribboncaption)|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|Overrides [CMFCVisualManager::OnDrawRibbonCaptionButton](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__ondrawribboncaptionbutton)|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|Overrides [CMFCVisualManager::OnDrawRibbonCategory](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__ondrawribboncategory)|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|Overrides [CMFCVisualManager::OnDrawRibbonCategoryTab](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__ondrawribboncategorytab)|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|Overrides [CMFCVisualManager::OnDrawRibbonDefaultPaneButton](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__ondrawribbondefaultpanebutton)|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|Overrides [CMFCVisualManager::OnDrawRibbonGalleryButton](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__ondrawribbongallerybutton)|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|Overrides <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|Overrides [CMFCVisualManager::OnDrawRibbonMenuCheckFrame](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__ondrawribbonmenucheckframe)|  
|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|Overrides [CMFCVisualManager::OnDrawRibbonPanel](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__ondrawribbonpanel)|  
|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|Overrides [CMFCVisualManager::OnDrawRibbonPanelCaption](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__ondrawribbonpanelcaption)|  
|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|Overrides [CMFCVisualManager::OnDrawRibbonProgressBar](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__ondrawribbonprogressbar)|  
|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|Overrides [CMFCVisualManager::OnDrawRibbonRecentFilesFrame](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__ondrawribbonrecentfilesframe)|  
|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|Overrides [CMFCVisualManager::OnDrawRibbonSliderChannel](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__ondrawribbonsliderchannel)|  
|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|Overrides [CMFCVisualManager::OnDrawRibbonSliderThumb](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__ondrawribbonsliderthumb)|  
|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|Overrides [CMFCVisualManager::OnDrawRibbonSliderZoomButton](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__ondrawribbonsliderzoombutton)|  
|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|Overrides [CMFCVisualManager::OnDrawRibbonStatusBarPane](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__ondrawribbonstatusbarpane)|  
|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|Overrides [CMFCVisualManager::OnDrawRibbonTabsFrame](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__ondrawribbontabsframe)|  
|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|Overrides [CMFCVisualManagerWindows::OnDrawStatusBarSizeBox](../vs140/cmfcvisualmanagerwindows-class.md#cmfcvisualmanagerwindows__ondrawstatusbarsizebox)|  
|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|Overrides [CMFCVisualManagerWindows::OnFillBarBackground](../vs140/cmfcvisualmanagerwindows-class.md#cmfcvisualmanagerwindows__onfillbarbackground)|  
|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|Overrides [CMFCVisualManagerWindows::OnFillButtonInterior](../vs140/cmfcvisualmanagerwindows-class.md#cmfcvisualmanagerwindows__onfillbuttoninterior)|  
|[CMFCVisualManagerWindows7::OnFillMenuImageRect](#cmfcvisualmanagerwindows7__onfillmenuimagerect)|The framework calls this method when it fills area around menu item images.|  
|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|Overrides [CMFCVisualManager::OnFillRibbonButton](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__onfillribbonbutton)|  
|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|Overrides [CMFCVisualManager::OnFillRibbonQuickAccessToolBarPopup](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__onfillribbonquickaccesstoolbarpopup)|  
|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>|Overrides [CMFCVisualManagerWindows::OnHighlightMenuItem](../vs140/cmfcvisualmanagerwindows-class.md#cmfcvisualmanagerwindows__onhighlightmenuitem)|  
|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|Overrides [CMFCVisualManager::OnNcActivate](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__onncactivate)|  
|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|Overrides [CMFCVisualManager::OnNcPaint](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__onncpaint)|  
|<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>|Overrides [CMFCVisualManagerWindows::OnUpdateSystemColors](../vs140/cmfcvisualmanagerwindows-class.md#cmfcvisualmanagerwindows__onupdatesystemcolors)|  
|<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>|Sets the resource handle that describes the attributes of the visual manager.|  
|<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>|Sets the color scheme of the <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> GUI.|  
  
## Remarks  
 Use the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> class to change the appearance of your application to mimic a default [!INCLUDE[win7](../vs140/includes/win7_md.md)] application. This class might not be valid if your application is running on a version of Windows earlier than [!INCLUDE[win7](../vs140/includes/win7_md.md)]. In that scenario, the application uses the default visual manager defined in [CMFCVisualManager](../vs140/cmfcvisualmanager-class.md).  
  
 The CMFCVisualManagerWindows7 inherits multiple methods from both the [CMFCVisualManagerWindows Class](../vs140/cmfcvisualmanagerwindows-class.md) and the <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> class. The methods listed in the previous section are methods new to the <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> class.  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CMFCBaseVisualManager](../vs140/cmfcbasevisualmanager-class.md)  
  
 [CMFCVisualManager](../vs140/cmfcvisualmanager-class.md)  
  
 [CMFCVisualManagerOfficeXP](../vs140/cmfcvisualmanagerofficexp-class.md)  
  
 [CMFCVisualManagerWindows](../vs140/cmfcvisualmanagerwindows-class.md)  
  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxvisualmanagerwindows7.h  
  
##  \<a name="cmfcvisualmanagerwindows7___dtorcmfcvisualmanagerwindows7">\</a>  CMFCVisualManagerWindows7::~CMFCVisualManagerWindows7  
 Default destructor.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="cmfcvisualmanagerwindows7__cmfcvisualmanagerwindows7">\</a>  CMFCVisualManagerWindows7::CMFCVisualManagerWindows7  
 Default constructor.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
##  \<a name="cmfcvisualmanagerwindows7__getribboneditbackgroundcolor">\</a>  CMFCVisualManagerWindows7::GetRibbonEditBackgroundColor  
 Obtains the background color of a ribbon edit box.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 A pointer to the edit control. This value cannot be <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>.  
  
 [out] <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 Returns whether the ribbon box is highlighted.  
  
 [out] <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 Returns <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> if the ribbon panel that contains <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> is highlighted.  
  
 [out] <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
 Returns whether <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> is disabled.  
  
### Return Value  
 The background color of the edit box <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcvisualmanagerwindows7__onfillmenuimagerect">\</a>  CMFCVisualManagerWindows7::OnFillMenuImageRect  
 The framework calls this method when it fills area around a menu item image.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 A pointer to the device context of a menu button.  
  
 [in] <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>. The framework fills the background for this button.  
  
 [in] <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the menu button image area.  
  
 [in] <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
 The button state.  
  
### Remarks  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [CMFCVisualManagerWindows Class](../vs140/cmfcvisualmanagerwindows-class.md)   
 [CMFCVisualManager::SetDefaultManager](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__setdefaultmanager)