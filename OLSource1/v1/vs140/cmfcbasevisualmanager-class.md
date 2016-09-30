---
title: "CMFCBaseVisualManager Class"
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
  - "CMFCBaseVisualManager"
  - "CMFCBaseVisualManager.~CMFCBaseVisualManager"
  - "~CMFCBaseVisualManager"
  - "CMFCBaseVisualManager::~CMFCBaseVisualManager"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "~CMFCBaseVisualManager destructor"
  - "CMFCBaseVisualManager class, destructor"
  - "CMFCBaseVisualManager class"
ms.assetid: d56f3afc-cdea-4de1-825a-a08999c571e0
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCBaseVisualManager Class
A layer between derived visual managers and the Windows Theme API.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> loads UxTheme.dll, if available, and manages access to Windows Theme API methods.  
  
 This class is for internal use only.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|||  
|-|-|  
|Name|Description|  
|[CMFCBaseVisualManager::CMFCBaseVisualManager](#cmfcbasevisualmanager__cmfcbasevisualmanager)|Constructs and initializes a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object.|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Destructor.|  
  
### Public Methods  
  
|||  
|-|-|  
|Name|Description|  
|[CMFCBaseVisualManager::DrawCheckBox](#cmfcbasevisualmanager__drawcheckbox)|Draws a check box control by using the current Windows theme.|  
|[CMFCBaseVisualManager::DrawComboBorder](#cmfcbasevisualmanager__drawcomboborder)|Draws a combo box border using the current Windows theme.|  
|[CMFCBaseVisualManager::DrawComboDropButton](#cmfcbasevisualmanager__drawcombodropbutton)|Draws a combo box drop-down button using the current Windows theme.|  
|[CMFCBaseVisualManager::DrawPushButton](#cmfcbasevisualmanager__drawpushbutton)|Draws a push button using the current Windows theme.|  
|[CMFCBaseVisualManager::DrawRadioButton](#cmfcbasevisualmanager__drawradiobutton)|Draws a radio button control by using the current Windows theme.|  
|[CMFCBaseVisualManager::DrawStatusBarProgress](#cmfcbasevisualmanager__drawstatusbarprogress)|Draws a progress bar on a status bar control ( [CMFCStatusBar Class](../vs140/cmfcstatusbar-class.md)) using the current Windows theme.|  
|[CMFCBaseVisualManager::FillReBarPane](#cmfcbasevisualmanager__fillrebarpane)|Fills the background of the rebar control by using the current Windows theme.|  
|[CMFCBaseVisualManager::GetStandardWindowsTheme](#cmfcbasevisualmanager__getstandardwindowstheme)|Gets the current Windows theme.|  
  
### Protected Methods  
  
|||  
|-|-|  
|Name|Description|  
|[CMFCBaseVisualManager::CleanUpThemes](#cmfcbasevisualmanager__cleanupthemes)|Calls <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> for all handles obtained in <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.|  
|[CMFCBaseVisualManager::UpdateSystemColors](#cmfcbasevisualmanager__updatesystemcolors)|Calls <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to obtain handles for drawing various controls: windows, toolbars, buttons, and so on.|  
  
## Remarks  
 You do not have to instantiate objects of this class directly.  
  
 Because it is a base class for all visual managers, you can just call [CMFCVisualManager::GetInstance](../vs140/cmfcvisualmanager-class.md#cmfcvisualmanager__getinstance), obtain a pointer to the current Visual Manager, and access the methods for <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> using that pointer. However, if you have to display a control by using the current Windows theme, it is better to use the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> interface.  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CMFCBaseVisualManager](../vs140/cmfcbasevisualmanager-class.md)  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
##  \<a name="cmfcbasevisualmanager__cleanupthemes">\</a>  CMFCBaseVisualManager::CleanUpThemes  
 Calls <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> for all handles obtained in <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 For internal use only.  
  
##  \<a name="cmfcbasevisualmanager__cmfcbasevisualmanager">\</a>  CMFCBaseVisualManager::CMFCBaseVisualManager  
 Constructs and initializes a <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
##  \<a name="cmfcbasevisualmanager__drawcheckbox">\</a>  CMFCBaseVisualManager::DrawCheckBox  
 Draws a check box control by using the current Windows theme.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 A pointer to a device context  
  
 [in] <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 The bounding rectangle of the check box.  
  
 [in] <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 Specifies whether the check box is highlighted.  
  
 [in] <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 0 for unchecked, 1 for checked normal,  
  
 2 for mixed normal.  
  
 [in] <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 Specifies whether the check box is enabled.  
  
 [in] <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 Specifies whether the check box is pressed.  
  
### Return Value  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> if Theme API is enabled; otherwise <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
### Remarks  
 The values of <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> correspond to the following check box styles.  
  
|nState|Check box style|  
|------------|---------------------|  
|0|CBS_UNCHECKEDNORMAL|  
|1|CBS_CHECKEDNORMAL|  
|2|CBS_MIXEDNORMAL|  
  
##  \<a name="cmfcbasevisualmanager__drawcomboborder">\</a>  CMFCBaseVisualManager::DrawComboBorder  
 Draws the combo box border using the current Windows theme.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 Bounding rectangle of the combo box border.  
  
 [in] <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 Specifies whether the combo box border is disabled.  
  
 [in] <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 Specifies whether the combo box border is dropped down.  
  
 [in] <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 Specifies whether the combo box border is highlighted.  
  
### Return Value  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> if Theme API is enabled; otherwise <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcbasevisualmanager__drawcombodropbutton">\</a>  CMFCBaseVisualManager::DrawComboDropButton  
 Draws a combo box drop-down button using the current Windows theme.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|A pointer to a device context.|  
|[in] <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|The bounding rectangle of the combo box drop-down button.|  
|[in] <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|Specifies whether the combo box drop-down button is disabled.|  
|[in] <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|Specifies whether the combo box drop-down button is dropped down.|  
|[in] <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|Specifies whether the combo box drop-down button is highlighted.|  
  
### Return Value  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> if Theme API is enabled; otherwise <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcbasevisualmanager__drawpushbutton">\</a>  CMFCBaseVisualManager::DrawPushButton  
 Draws a push button using the current Windows theme.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 The bounding rectangle of the push button.  
  
 [in] <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 A pointer to the [CMFCButton Class](../vs140/cmfcbutton-class.md) object to draw.  
  
 [in] <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 Ignored. The state is taken from <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>.  
  
### Return Value  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> if Theme API is enabled; otherwise <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcbasevisualmanager__drawradiobutton">\</a>  CMFCBaseVisualManager::DrawRadioButton  
 Draws a radio button control by using the current Windows theme.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 The bounding rectangle of the radio button.  
  
 [in] <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 Specifies whether the radio button is highlighted.  
  
 [in] <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 Specifies whether the radio button is checked.  
  
 [in] <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 Specifies whether the radio button is enabled.  
  
 [in] <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 Specifies whether the radio button is pressed.  
  
### Return Value  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> if Theme API is enabled; otherwise <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcbasevisualmanager__drawstatusbarprogress">\</a>  CMFCBaseVisualManager::DrawStatusBarProgress  
 Draws progress bar on status bar control ( [CMFCStatusBar Class](../vs140/cmfcstatusbar-class.md)) using the current Windows theme.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 A pointer to status bar. This value is ignored.  
  
 [in] <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 The bounding rectangle of the progress bar in <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> coordinates.  
  
 [in] <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 The total progress value.  
  
 [in] <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 The current progress value.  
  
 [in] <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 The start color. <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> ignores this. Derived classes can use it for color gradients.  
  
 [in] <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 The end color. <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> ignores this. Derived classes can use it for color gradients.  
  
 [in] <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 Progress text color. <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> ignores this. The text color is defined by <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 Specifies whether to display progress text.  
  
### Return Value  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> if Theme API is enabled; otherwise <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcbasevisualmanager__fillrebarpane">\</a>  CMFCBaseVisualManager::FillReBarPane  
 Fills the background of the rebar control by using the current Windows theme.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 A pointer to a pane whose background should be drawn.  
  
 [in] <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
 The bounding rectangle of the area to be filled.  
  
### Return Value  
 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> if Theme API is enabled; otherwise <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcbasevisualmanager__getstandardwindowstheme">\</a>  CMFCBaseVisualManager::GetStandardWindowsTheme  
 Gets the current Windows theme.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 The currently selected Windows Theme color. Can be one of the following enumerated values:  
  
-   <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> - there is no theme enabled.  
  
-   <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> - non standard theme is selected (meaning a theme is selected, but none from the list below).  
  
-   <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> - blue theme (Luna).  
  
-   <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> - olive theme.  
  
-   <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> - silver theme.  
  
##  \<a name="cmfcbasevisualmanager__updatesystemcolors">\</a>  CMFCBaseVisualManager::UpdateSystemColors  
 Calls <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> to obtain handles for drawing various controls: windows, toolbars, buttons, and so on.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Remarks  
 For internal use only.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)