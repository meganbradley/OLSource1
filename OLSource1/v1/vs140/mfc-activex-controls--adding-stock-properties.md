---
title: "MFC ActiveX Controls: Adding Stock Properties"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BackColor property"
  - "properties [MFC], adding stock"
  - "ForeColor property"
  - "MFC ActiveX controls, properties"
  - "foreground colors, ActiveX controls"
  - "foreground colors"
ms.assetid: 8b98c8c5-5b69-4366-87bf-0e61e6668ecb
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MFC ActiveX Controls: Adding Stock Properties
Stock properties differ from custom properties in that they are already implemented by the class <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> contains predefined member functions that support common properties for the control. Some common properties include the control's caption and the foreground and background colors. For information on other stock properties, see [Stock Properties Supported by the Add Property Wizard](#_core_stock_properties_supported_by_classwizard) later in this article. The dispatch map entries for stock properties are always prefixed by **DISP_STOCKPROP**.  
  
 This article describes how to add a stock property (in this case, Caption) to an ActiveX control using the Add Property Wizard and explains the resulting code modifications. Topics include:  
  
-   [Using the Add Property Wizard to add a stock property](#_core_using_classwizard_to_add_a_stock_property)  
  
-   [Add Property Wizard changes for stock properties](#_core_classwizard_changes_for_stock_properties)  
  
-   [Stock properties supported by the Add Property Wizard](#_core_stock_properties_supported_by_classwizard)  
  
-   [Stock properties and notification](#_core_stock_properties_and_notification)  
  
-   [Color properties](#_core_color_properties)  
  
    > [!NOTE]
    >  Visual Basic custom controls typically have properties such as Top, Left, Width, Height, Align, Tag, Name, TabIndex, TabStop, and Parent. ActiveX control containers, however, are responsible for implementing these control properties and therefore ActiveX controls should not support these properties.  
  
##  \<a name="_core_using_classwizard_to_add_a_stock_property">\</a> Using the Add Property Wizard to Add a Stock Property  
 Adding stock properties requires less code than adding custom properties because support for the property is handled automatically by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. The following procedure demonstrates adding the stock Caption property to an ActiveX control framework and can also be used to add other stock properties. Substitute the selected stock property name for Caption.  
  
#### To add the stock Caption property using the Add Property Wizard  
  
1.  Load your control's project.  
  
2.  In Class View, expand the library node of your control.  
  
3.  Right-click the interface node for your control (the second node of the library node) to open the shortcut menu.  
  
4.  From the shortcut menu, click **Add** and then click **Add Property**.  
  
     This opens the [Add Property Wizard](../vs140/names--add-property-wizard.md).  
  
5.  In the **Property Name** box, click **Caption**.  
  
6.  Click **Finish**.  
  
##  \<a name="_core_classwizard_changes_for_stock_properties">\</a> Add Property Wizard Changes for Stock Properties  
 Because <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> supports stock properties, the Add Property Wizard does not change the class declaration in any way; it adds the property to the dispatch map. The Add Property Wizard adds the following line to the dispatch map of the control, which is located in the implementation (.CPP) file:  
  
 [!code[NVC_MFC_AxUI#22](../vs140/codesnippet/CPP/mfc-activex-controls--adding-stock-properties_1.cpp)]  
  
 The following line is added to your control's interface description (.IDL) file:  
  
 [!code[NVC_MFC_AxUI#23](../vs140/codesnippet/CPP/mfc-activex-controls--adding-stock-properties_2.idl)]  
  
 This line assigns the Caption property a specific ID. Notice that the property is bindable and will request permission from the database before modifying the value.  
  
 This makes the Caption property available to users of your control. To use the value of a stock property, access a member variable or member function of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> base class. For more information on these member variables and member functions, see the next section, Stock Properties Supported by the Add Property Wizard.  
  
##  \<a name="_core_stock_properties_supported_by_classwizard">\</a> Stock Properties Supported by the Add Property Wizard  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> class provides nine stock properties. You can add the properties you want by using the Add Property Wizard.  
  
|Property|Dispatch map entry|How to access value|  
|--------------|------------------------|-------------------------|  
|**Appearance**|**DISP_STOCKPROP_APPEARANCE( )**|Value accessible as **m_sAppearance**.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|**DISP_STOCKPROP_BACKCOLOR( )**|Value accessible by calling <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|**DISP_STOCKPROP_BORDERSTYLE( )**|Value accessible as **m_sBorderStyle**.|  
|**Caption**|**DISP_STOCKPROP_CAPTION( )**|Value accessible by calling <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.|  
|**Enabled**|**DISP_STOCKPROP_ENABLED( )**|Value accessible as **m_bEnabled**.|  
|**Font**|**DISP_STOCKPROP_FONT( )**|See the article [MFC ActiveX Controls: Using Fonts](../vs140/mfc-activex-controls--using-fonts.md) for usage.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|**DISP_STOCKPROP_FORECOLOR( )**|Value accessible by calling <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.|  
|**hWnd**|**DISP_STOCKPROP_HWND( )**|Value accessible as <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.|  
|**Text**|**DISP_STOCKPROP_TEXT( )**|Value accessible by calling <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. This property is the same as **Caption**, except for the property name.|  
|**ReadyState**|**DISP_STOCKPROP_READYSTATE()**|Value accessible as m_lReadyState or <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|  
  
##  \<a name="_core_stock_properties_and_notification">\</a> Stock Properties and Notification  
 Most stock properties have notification functions that can be overridden. For example, whenever the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> property is changed, the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> function (a member function of the control class) is called. The default implementation (in <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>) calls <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. Override this function if you want to take additional actions in response to this situation.  
  
##  \<a name="_core_color_properties">\</a> Color Properties  
 You can use the stock <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> properties, or your own custom color properties, when painting the control. To use a color property, call the [COleControl::TranslateColor](../vs140/colecontrol--translatecolor.md) member function. The parameters of this function are the value of the color property and an optional palette handle. The return value is a **COLORREF** value that can be passed to GDI functions, such as <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
 The color values for the stock <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> properties are accessed by calling either the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> or the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> function, respectively.  
  
 The following example demonstrates using these two color properties when painting a control. It initializes a temporary **COLORREF** variable and a <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object with calls to <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>: one using the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> property and the other using the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> property. A temporary <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object is then used to paint the control's rectangle, and the text color is set using the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> property.  
  
 [!code[NVC_MFC_AxUI#24](../vs140/codesnippet/CPP/mfc-activex-controls--adding-stock-properties_3.cpp)]  
  
## See Also  
 [MFC ActiveX Controls](../vs140/mfc-activex-controls.md)   
 [MFC ActiveX Controls: Properties](../vs140/mfc-activex-controls--properties.md)   
 [MFC ActiveX Controls: Methods](../vs140/mfc-activex-controls--methods.md)   
 [COleControl Class](../vs140/colecontrol-class.md)