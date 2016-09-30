---
title: "CMFCRibbonColorButton Class"
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
  - "CMFCRibbonColorButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCRibbonColorButton class"
ms.assetid: 6b4b4ee3-8cc0-41b4-a4eb-93e8847008e1
caps.latest.revision: 35
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonColorButton Class
The <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> class implements a color button that you can add to a ribbon bar. The ribbon color button displays a drop-down menu that contains one or more color palettes.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCRibbonColorButton::CMFCRibbonColorButton](#cmfcribboncolorbutton__cmfcribboncolorbutton)||  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCRibbonColorButton::AddColorsGroup](#cmfcribboncolorbutton__addcolorsgroup)|Adds a group of colors to the regular color area.|  
|[CMFCRibbonColorButton::EnableAutomaticButton](#cmfcribboncolorbutton__enableautomaticbutton)|Specifies whether the **Automatic** button is enabled.|  
|[CMFCRibbonColorButton::EnableOtherButton](#cmfcribboncolorbutton__enableotherbutton)|Enables the **Other** button.|  
|[CMFCRibbonColorButton::GetAutomaticColor](#cmfcribboncolorbutton__getautomaticcolor)||  
|[CMFCRibbonColorButton::GetColor](#cmfcribboncolorbutton__getcolor)|Returns the currently selected color.|  
|[CMFCRibbonColorButton::GetColorBoxSize](#cmfcribboncolorbutton__getcolorboxsize)|Returns the size of the color elements that appear on the color bar.|  
|[CMFCRibbonColorButton::GetColumns](#cmfcribboncolorbutton__getcolumns)||  
|[CMFCRibbonColorButton::GetHighlightedColor](#cmfcribboncolorbutton__gethighlightedcolor)|Returns the color of the currently selected element on the popup color palette.|  
|[CMFCRibbonColorButton::RemoveAllColorGroups](#cmfcribboncolorbutton__removeallcolorgroups)|Removes all color groups from the regular color area.|  
|[CMFCRibbonColorButton::SetColor](#cmfcribboncolorbutton__setcolor)|Selects a color from the regular color area.|  
|[CMFCRibbonColorButton::SetColorBoxSize](#cmfcribboncolorbutton__setcolorboxsize)|Sets the size of all the color elements that appear on the color bar.|  
|[CMFCRibbonColorButton::SetColorName](#cmfcribboncolorbutton__setcolorname)||  
|[CMFCRibbonColorButton::SetColumns](#cmfcribboncolorbutton__setcolumns)||  
|[CMFCRibbonColorButton::SetDocumentColors](#cmfcribboncolorbutton__setdocumentcolors)|Specifies a list of RGB values to display in the document color area.|  
|[CMFCRibbonColorButton::SetPalette](#cmfcribboncolorbutton__setpalette)||  
|[CMFCRibbonColorButton::UpdateColor](#cmfcribboncolorbutton__updatecolor)||  
  
## Remarks  
 The ribbon color button displays a color bar when a user presses it. By default, this color bar contains a color selection palette called the regular color area. Optionally, the color bar can display an **Automatic** button, which allows the user to select a default color, and an **Other** button, which displays a popup color palette that contains additional colors.  
  
## Example  
 The following example demonstrates how to use various methods in the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> class. The example shows how to construct a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object, set the large image, enable the **Automatic** button, enable the **Other** button, set the number of columns, set the size of all the color elements that appear on the color bar, add a group of colors to the regular color area, and specify a list of RGB values to display in the document color area. This code snippet is part of the [Draw Client sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_DrawClient#3](../vs140/codesnippet/CPP/cmfcribboncolorbutton-class_1.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CMFCRibbonBaseElement](../vs140/cmfcribbonbaseelement-class.md)  
  
 [CMFCRibbonButton](../vs140/cmfcribbonbutton-class.md)  
  
 [CMFCRibbonGallery](../vs140/cmfcribbongallery-class.md)  
  
 [CMFCRibbonColorButton](../vs140/cmfcribboncolorbutton-class.md)  
  
## Requirements  
 **Header:** afxribboncolorbutton.h  
  
##  \<a name="cmfcribboncolorbutton__addcolorsgroup">\</a>  CMFCRibbonColorButton::AddColorsGroup  
 Adds a group of colors to the regular color area.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 The group name.  
  
 [in] <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 The list of colors.  
  
 [in] <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 Controls how the color items are displayed in the group. If <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, the color items are drawn without a vertical spacing. If <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, the color items are drawn with a vertical spacing.  
  
### Remarks  
 Use this function to make the color pop-up display several groups of colors. You can control how the colors are displayed in group.  
  
##  \<a name="cmfcribboncolorbutton__cmfcribboncolorbutton">\</a>  CMFCRibbonColorButton::CMFCRibbonColorButton  
 Constructs a <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 Specifies the command ID of the command to execute when a user clicks the button.  
  
 [in] <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 Specifies the text to appear on the button.  
  
 [in] <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 The zero-based index of the small image to appear on the button.  
  
 [in] <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 The color of the button (defaults to black).  
  
 [in] <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 If                                 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, the button is drawn as a simple rectangle.  
  
 [in] <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 The zero-based index of the large image to appear on the button.  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribboncolorbutton__enableautomaticbutton">\</a>  CMFCRibbonColorButton::EnableAutomaticButton  
 Specifies whether the **Automatic** button is enabled.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 The label for the  **Automatic** button.  
  
 [in] <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 An RGB value that specifies the **Automatic** button's default color.  
  
 [in] <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> if the **Automatic** button is enabled; <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> if it is disabled.  
  
 [in] <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 The tooltip of the **Automatic** button.  
  
 [in] <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 Specifies whether the **Automatic** button is at the top, before color palette.  
  
 [in] <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> if the application draws a border around the color bar on the ribbon color button. Color bar displays the currently selected color. <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> if the application does not draw a border  
  
##  \<a name="cmfcribboncolorbutton__enableotherbutton">\</a>  CMFCRibbonColorButton::EnableOtherButton  
 Enables the **Other** button.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 The button's label.  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 The tooltip text for the **Other** button.  
  
### Remarks  
 The **Other** button is the button that is displayed below the group of colors. When the user clicks the **Other** button, it displays a color dialog.  
  
##  \<a name="cmfcribboncolorbutton__getautomaticcolor">\</a>  CMFCRibbonColorButton::GetAutomaticColor  
 Retrieves the current automatic-button color.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 An RGB color value that represents the current automatic-button color.  
  
### Remarks  
 The automatic-button color is set by the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> parameter passed to the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> method.  
  
##  \<a name="cmfcribboncolorbutton__getcolor">\</a>  CMFCRibbonColorButton::GetColor  
 Returns the currently selected color.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 The color selected by clicking the button.  
  
##  \<a name="cmfcribboncolorbutton__getcolorboxsize">\</a>  CMFCRibbonColorButton::GetColorBoxSize  
 Returns the size of the color elements that appear on the color bar.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 The size of the color buttons in the drop-down color palette.  
  
##  \<a name="cmfcribboncolorbutton__getcolumns">\</a>  CMFCRibbonColorButton::GetColumns  
 Gets the number of items in a row of the ribbon color button’s gallery display.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 Returns the number of icons in each row.  
  
### Remarks  
  
##  \<a name="cmfcribboncolorbutton__gethighlightedcolor">\</a>  CMFCRibbonColorButton::GetHighlightedColor  
 Returns the color of the currently selected element on the pop-up color palette.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 The color of currently selected element on the pop-up color palette.  
  
##  \<a name="cmfcribboncolorbutton__removeallcolorgroups">\</a>  CMFCRibbonColorButton::RemoveAllColorGroups  
 Removes all color groups from the regular color area.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
##  \<a name="cmfcribboncolorbutton__setcolor">\</a>  CMFCRibbonColorButton::SetColor  
 Selects a color from the regular color area.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 A color to set.  
  
##  \<a name="cmfcribboncolorbutton__setcolorboxsize">\</a>  CMFCRibbonColorButton::SetColorBoxSize  
 Sets the size of all the color elements that appear on the color bar.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 The new size of the color buttons in the color palette.  
  
##  \<a name="cmfcribboncolorbutton__setcolorname">\</a>  CMFCRibbonColorButton::SetColorName  
 Sets a new name for a specified color.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 The RGB value of a color.  
  
 [in] <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 The new name for the specified color.  
  
### Remarks  
 Because it calls <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>, this method changes the name of the specified color in all <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> objects in your application.  
  
##  \<a name="cmfcribboncolorbutton__setcolumns">\</a>  CMFCRibbonColorButton::SetColumns  
 Sets the number of columns displayed in the table of colors that is presented to the user during the user's color selection process.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 The number of color icons to display in each row.  
  
### Remarks  
  
##  \<a name="cmfcribboncolorbutton__setdocumentcolors">\</a>  CMFCRibbonColorButton::SetDocumentColors  
 Specifies a list of RGB values to display in the document color area.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 The text to be displayed with the document colors.  
  
 [in] <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 A reference to a list of RGB values.  
  
##  \<a name="cmfcribboncolorbutton__setpalette">\</a>  CMFCRibbonColorButton::SetPalette  
 Specifies the standard colors to display in the color table that the color button displays.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 A pointer to a color palette.  
  
### Remarks  
  
##  \<a name="cmfcribboncolorbutton__updatecolor">\</a>  CMFCRibbonColorButton::UpdateColor  
 Called by the framework when the user selects a color from the color table displayed when the user clicks the color button.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 A color selected by the user.  
  
### Remarks  
 The <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> method changes the currently selected button's color and notifies its parent by sending a <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> message with a <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> standard notification. Use the [GetColor](#cmfcribboncolorbutton__getcolor) method to retrieve the selected color.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCRibbonGallery](../vs140/cmfcribbongallery-class.md)