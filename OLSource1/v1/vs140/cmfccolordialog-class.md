---
title: "CMFCColorDialog Class"
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
  - "CMFCColorDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCColorDialog::m_CurrentColor data member"
  - "CMFCColorDialog::m_pPropSheet data member"
  - "CMFCColorDialog::m_btnColorSelect data member"
  - "CMFCColorDialog class"
  - "CMFCColorDialog::m_wndColors data member"
  - "CMFCColorDialog::m_bIsMyPalette data member"
  - "CMFCColorDialog::m_pColourSheetTwo data member"
  - "CMFCColorDialog::m_NewColor data member"
  - "CMFCColorDialog::m_pPalette data member"
  - "CMFCColorDialog::m_wndStaticPlaceHolder data member"
  - "CMFCColorDialog::m_pColourSheetOne data member"
  - "CMFCColorDialog::m_hcurPicker data member"
  - "CMFCColorDialog::PreTranslateMessage method"
  - "CMFCColorDialog::m_bPickerMode data member"
ms.assetid: 235bbbbc-a3b1-46e0-801b-fb55093ec579
caps.latest.revision: 29
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCColorDialog Class
The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> class represents a color selection dialog box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCColorDialog::CMFCColorDialog](#cmfccolordialog__cmfccolordialog)|Constructs a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCColorDialog::GetColor](#cmfccolordialog__getcolor)|Returns the current selected color.|  
|[CMFCColorDialog::GetPalette](#cmfccolordialog__getpalette)|Returns the color's palette.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Translates window messages before they are dispatched to the                                         [TranslateMessage](http://msdn.microsoft.com/library/windows/desktop/ms644955) and                                         [DispatchMessage](http://msdn.microsoft.com/library/windows/desktop/ms644934) Windows functions. For syntax and more information, see [CWnd::PreTranslateMessage](../vs140/cwnd-class.md#cwnd__pretranslatemessage). (Overrides <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.)|  
|[CMFCColorDialog::RebuildPalette](#cmfccolordialog__rebuildpalette)|Derives a palette from the system palette.|  
|[CMFCColorDialog::SetCurrentColor](#cmfccolordialog__setcurrentcolor)|Sets the current selected color.|  
|[CMFCColorDialog::SetNewColor](#cmfccolordialog__setnewcolor)|Sets the color most equivalent to a specified RGB value.|  
|[CMFCColorDialog::SetPageOne](#cmfccolordialog__setpageone)|Selects an RGB value for the first property page.|  
|[CMFCColorDialog::SetPageTwo](#cmfccolordialog__setpagetwo)|Selects an RGB value for the second property page.|  
  
### Protected Data Members  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder> if the color selection dialog box uses its own color palette, or <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> if the dialog box uses a palette that is specified in the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> constructor.|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder> while the user is selecting a color from the selection dialog box; otherwise, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|The color button that the user has selected.|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|The currently selected color.|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|The cursor that is used to pick a color.|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|The prospective selected color, which can be permanently selected or reverted to the original color.|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|A pointer to the first property page of the color selection property sheet.|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|A pointer to the second property page of the color selection property sheet.|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|The current logical palette.|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|A pointer to the property sheet for the color selection dialog box.|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|A color picker control object.|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|A static control that is a placeholder for the color picker property sheet.|  
  
## Remarks  
 The color selection dialog box is displayed as a property sheet with two pages. On the first page, you select a standard color from the system palette; on the second page, you select a custom color.  
  
 You can construct a <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object on the stack and then call <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, passing the initial color as a parameter to the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> constructor. The color selection dialog box then creates several [CMFCColorPickerCtrl](../vs140/cmfccolorpickerctrl-class.md) objects to handle each color palette.  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CDialog](../vs140/cdialog-class.md)  
  
 [CDialogEx](../vs140/cdialogex-class.md)  
  
 [CMFCColorDialog](../vs140/cmfccolordialog-class.md)  
  
## Example  
 The following example demonstrates how to configure a color dialog by using various methods in the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> class. The example shows how to set the current and the new colors of the dialog, and how to set the red, green, and blue components of a selected color on the two property pages of the color dialog. This example is part of the [New Controls sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_NewControls#3](../vs140/codesnippet/CPP/cmfccolordialog-class_1.cpp)]  
  
## Requirements  
 **Header:** afxcolordialog.h  
  
##  \<a name="cmfccolordialog__cmfccolordialog">\</a>  CMFCColorDialog::CMFCColorDialog  
 Constructs a <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 The default color selection. If no value is specified, the default is RGB(0,0,0) (black).  
  
 [in] <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 (Reserved.)  
  
 [in] <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 A pointer to the dialog box's parent or owner window.  
  
 [in] <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 A handle to a color palette.  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfccolordialog__getcolor">\</a>  CMFCColorDialog::GetColor  
 Retrieves the color that the user selects from the color dialog.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 A                         [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) value that contains the RGB information for the color selected in the color dialog box.  
  
### Remarks  
 Call this function after you call the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> method.  
  
##  \<a name="cmfccolordialog__getpalette">\</a>  CMFCColorDialog::GetPalette  
 Retrieves the color palette that is available in the current color dialog.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> object that was specified in the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> constructor.  
  
### Remarks  
 The color palette specifies the colors that the user can choose.  
  
##  \<a name="cmfccolordialog__rebuildpalette">\</a>  CMFCColorDialog::RebuildPalette  
 Derives a palette from the system palette.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
##  \<a name="cmfccolordialog__setcurrentcolor">\</a>  CMFCColorDialog::SetCurrentColor  
 Sets the current color of the dialog box.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 An RGB color value  
  
### Remarks  
  
##  \<a name="cmfccolordialog__setnewcolor">\</a>  CMFCColorDialog::SetNewColor  
 Sets the current color to the color in the current palette that is most similar.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 A                                 [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) that specifies an RGB color.  
  
### Remarks  
  
##  \<a name="cmfccolordialog__setpageone">\</a>  CMFCColorDialog::SetPageOne  
 Explicitly specifies the red, green, and blue components of a selected color on the first property page of a color dialog.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 Specifies the red component of the RGB value.  
  
 [in] <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 Specifies the green component of the RGB value.  
  
 [in] <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 Specifies the blue component of the RGB value.  
  
### Remarks  
  
##  \<a name="cmfccolordialog__setpagetwo">\</a>  CMFCColorDialog::SetPageTwo  
 Explicitly specifies the red, green, and blue components of a selected color on the second property page of a color dialog.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 Specifies a red component of the RGB value  
  
 [in] <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 Specifies a green component of an RGB value  
  
 [in] <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 Specifies a blue component of an RGB value  
  
### Remarks  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCColorPickerCtrl](../vs140/cmfccolorpickerctrl-class.md)