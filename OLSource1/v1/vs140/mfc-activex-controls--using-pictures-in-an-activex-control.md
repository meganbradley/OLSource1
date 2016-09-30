---
title: "MFC ActiveX Controls: Using Pictures in an ActiveX Control"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "LPPICTUREDISP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDraw method, MFC ActiveX controls"
  - "MFC ActiveX controls, pictures"
  - "OnDraw method"
  - "OnResetState method"
  - "CLSID_CPicturePropPage"
ms.assetid: 2e49735c-21b9-4442-bb3d-c82ef258eec9
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MFC ActiveX Controls: Using Pictures in an ActiveX Control
This article describes the common Picture type and how to implement it in your ActiveX control. Topics include:  
  
-   [Overview of Custom Picture Properties](#_core_overview_of_custom_picture_properties)  
  
-   [Implementing a Custom Picture Property in Your ActiveX Control](#_core_implementing_a_custom_picture_property_in_your_activex_control)  
  
-   [Additions to Your Control Project](#_core_additions_to_your_control_project)  
  
##  \<a name="_core_overview_of_custom_picture_properties">\</a> Overview of Custom Picture Properties  
 A Picture type is one of a group of types common to some ActiveX controls. The Picture type handles metafiles, bitmaps, or icons and allows the user to specify a picture to be displayed in an ActiveX control. Custom Picture properties are implemented using a picture object and Get/Set functions that allow the control user access to the Picture property. Control users access the custom Picture property using the stock Picture property page.  
  
 In addition to the standard Picture type, Font and Color types are also available. For more information on using the standard Font type in your ActiveX control, see the article [MFC ActiveX Controls: Using Fonts](../vs140/mfc-activex-controls--using-fonts.md).  
  
 The ActiveX control classes provide several components you can use to implement the Picture property within the control. These components include:  
  
-   The [CPictureHolder](../vs140/cpictureholder-class.md) class.  
  
     This class provides easy access to the picture object and functionality for the item displayed by the custom Picture property.  
  
-   Support for properties of type **LPPICTUREDISP**, implemented with Get/Set functions.  
  
     Using Class View you can quickly add a custom property, or properties, that supports the Picture type. For more information on adding ActiveX control properties with Class View, see the article [MFC ActiveX Controls: Properties](../vs140/mfc-activex-controls--properties.md).  
  
-   A property page that manipulates a control's Picture property or properties.  
  
     This property page is part of a group of stock property pages available to ActiveX controls. For more information on ActiveX control property pages, see the article [MFC ActiveX Controls: Using Stock Property Pages](../vs140/mfc-activex-controls--using-stock-property-pages.md)  
  
##  \<a name="_core_implementing_a_custom_picture_property_in_your_activex_control">\</a> Implementing a Custom Picture Property in Your ActiveX Control  
 When you have completed the steps outlined in this section, the control can display pictures chosen by its user. The user can change the displayed picture using a property page that shows the current picture and has a Browse button that allows the user to the select different pictures.  
  
 A custom Picture property is implemented using a process similar to that used for implementing other properties, the main difference being that the custom property must support a Picture type. Because the item of the Picture property must be drawn by the ActiveX control, a number of additions and modifications must be made to the property before it can be fully implemented.  
  
 To implement a custom Picture property, you must do the following:  
  
-   [Add code to your control project](#_core_additions_to_your_control_project).  
  
     A standard Picture property page ID, a data member of type <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, and a custom property of type **LPPICTUREDISP** with a Get/Set implementation must be added.  
  
-   [Modify several functions in your control class](#_core_modifications_to_your_control_project).  
  
     These modifications will be made to several functions that are responsible for the drawing of your ActiveX control.  
  
##  \<a name="_core_additions_to_your_control_project">\</a> Additions to Your Control Project  
 To add the property page ID for the standard Picture property page, insert the following line after the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> macro in the control implementation file (.CPP):  
  
 [!code[NVC_MFC_AxPic#1](../vs140/codesnippet/CPP/mfc-activex-controls--using-pictures-in-an-activex-control_1.cpp)]  
  
 You must also increment the count parameter of your <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> macro by one. The following line illustrates this:  
  
 [!code[NVC_MFC_AxPic#2](../vs140/codesnippet/CPP/mfc-activex-controls--using-pictures-in-an-activex-control_2.cpp)]  
  
 To add the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> data member to the control class, insert the following line under the protected section of the control class declaration in the control header file (.H):  
  
 [!code[NVC_MFC_AxPic#3](../vs140/codesnippet/CPP/mfc-activex-controls--using-pictures-in-an-activex-control_3.h)]  
  
 It is not necessary to name your data member <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; any name will suffice.  
  
 Next, add a custom property that supports a Picture type:  
  
#### To add a custom picture property using the Add Property Wizard  
  
1.  Load your control's project.  
  
2.  In Class View, expand the library node of your control.  
  
3.  Right-click the interface node for your control (the second node of the library node) to open the shortcut menu.  
  
4.  From the shortcut menu, choose **Add** and then **Add Property**.  
  
5.  In the **Property Name** box, type the property name. For example purposes, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is used in this procedure.  
  
6.  In the **Property Type** box, select **IPictureDisp\*** for the property type.  
  
7.  For **Implementation Type**, click **Get/Set Methods**.  
  
8.  Type unique names for your Get and Set Functions or accept the default names. (In this example, the default names <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> are used.)  
  
9. Click **Finish**.  
  
 The Add Property Wizard adds the following code between the dispatch map comments in the control header (.H) file:  
  
 [!code[NVC_MFC_AxPic#4](../vs140/codesnippet/CPP/mfc-activex-controls--using-pictures-in-an-activex-control_4.h)]  
  
 In addition, the following code was inserted in the dispatch map of the control implementation (.CPP) file:  
  
 [!code[NVC_MFC_AxPic#5](../vs140/codesnippet/CPP/mfc-activex-controls--using-pictures-in-an-activex-control_5.cpp)]  
  
 The Add Property Wizard also adds the following two stub functions in the control implementation file:  
  
 [!code[NVC_MFC_AxPic#6](../vs140/codesnippet/CPP/mfc-activex-controls--using-pictures-in-an-activex-control_6.cpp)]  
  
> [!NOTE]
>  Your control class and function names might differ from the example above.  
  
###  \<a name="_core_modifications_to_your_control_project">\</a> Modifications to Your Control Project  
 After you have made the necessary additions to your control project, you need to modify several functions that affect the rendering of your ActiveX control. These functions, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, and the Get/Set functions of a custom Picture property, are located in the control implementation file. (Note that in this example the control class is called <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> data member is called <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, and the custom picture property name is <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.)  
  
 In the control <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> function, add the following optional line after the call to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>:  
  
 [!code[NVC_MFC_AxPic#7](../vs140/codesnippet/CPP/mfc-activex-controls--using-pictures-in-an-activex-control_7.cpp)]  
  
 This sets the control's picture to a blank picture.  
  
 To draw the picture properly, make a call to [CPictureHolder::Render](../vs140/cpictureholder--render.md) in the control <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> function. Modify your function to resemble the following example:  
  
 [!code[NVC_MFC_AxPic#8](../vs140/codesnippet/CPP/mfc-activex-controls--using-pictures-in-an-activex-control_8.cpp)]  
  
 In the Get function of the control's custom picture property, add the following line:  
  
 [!code[NVC_MFC_AxPic#9](../vs140/codesnippet/CPP/mfc-activex-controls--using-pictures-in-an-activex-control_9.cpp)]  
  
 In the Set function of the control's custom Picture property, add the following lines:  
  
 [!code[NVC_MFC_AxPic#10](../vs140/codesnippet/CPP/mfc-activex-controls--using-pictures-in-an-activex-control_10.cpp)]  
  
 The picture property must be made persistent so that information added at design time will show up at run time. Add the following line to the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>-derived class's <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> function:  
  
 [!code[NVC_MFC_AxPic#11](../vs140/codesnippet/CPP/mfc-activex-controls--using-pictures-in-an-activex-control_11.cpp)]  
  
> [!NOTE]
>  Your class and function names might differ from the example above.  
  
 After you complete the modifications, rebuild your project to incorporate the new functionality of the custom Picture property and use Test Container to test the new property. See [Testing Properties and Events with Test Container](../vs140/testing-properties-and-events-with-test-container.md) for information on how to access the test container.  
  
## See Also  
 [MFC ActiveX Controls](../vs140/mfc-activex-controls.md)   
 [MFC ActiveX Controls: Using Fonts](../vs140/mfc-activex-controls--using-fonts.md)   
 [MFC ActiveX Controls: Property Pages](../vs140/mfc-activex-controls--property-pages.md)