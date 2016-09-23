---
title: "How to: Format Numbers and Dates in a LightSwitch Application"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - lightswitch
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - ls.StringValueFormats
ms.assetid: 74c453a4-b24f-4763-a3c1-7d1a2546a610
caps.latest.revision: 18
translation.priority.ht: 
  - de-de
  - ja-jp
---
# How to: Format Numbers and Dates in a LightSwitch Application
By using the **Format Pattern** property, you can specify how numeric and date types appear in an application that you create in Visual Studio LightSwitch. For example, you might want to display a `Decimal` value as a percentage (0.12 as 12%) or display a `Date` that includes the day of the week (7/4/2011 as Monday, July 4, 2011).  
  
> [!IMPORTANT]
>  The **Format Pattern** property applies only to screens in desktop clients for LightSwitch applications. For screens in an HTML client, you can apply formatting by writing JavaScript code in the `postRender` method of a screen. See [Format a number](../vs140/how-to--modify-an-html-screen-by-using-code.md#Format) or [Format a Date](../vs140/how-to--modify-an-html-screen-by-using-code.md#Date).  
  
> [!TIP]
>  You'll often want to specify display formatting by using custom business types such as `Money` or `Percent`.  
  
 The **Format Pattern** property is available in the **Data Designer** for the following types:  
  
-   `Date`  
  
-   `Date Time`  
  
-   `Decimal`  
  
-   `Double`  
  
-   `Guid`  
  
-   `Integer`  
  
-   `Long Integer`  
  
-   `Short Integer`  
  
 To specify a format, you use the same notation as for the `IFormattable.ToString` method. For more information about formatting notation, see [Reference: Number and Date Formats](../vs140/reference--number-and-date-formats.md).  
  
### To format a number  
  
1.  In **Solution Explorer**, open the shortcut menu for an entity or table, and then choose **Open**.  
  
     The entity or table opens in the **Data Designer**.  
  
    > [!NOTE]
    >  For applications that have been upgraded to [!INCLUDE[vs2012_upd02](../vs140/includes/vs2012_upd02_md.md)], on the **Perspective** bar, choose the **Server** tab.  
  
2.  In the **Data Designer**, choose the field that you want to format.  
  
3.  On the menu bar, choose **View**, **Properties Window**.  
  
4.  In the **Properties** window, in the **Formatting** section, choose the **Format Pattern** property, and then specify a valid format string.  
  
     For more information about format strings, see [Reference: Number and Date Formats](../vs140/reference--number-and-date-formats.md).  
  
### To format a date  
  
1.  In **Solution Explorer**, open the shortcut menu for an entity or table, and then choose **Open**.  
  
     The entity or table opens in the **Data Designer**.  
  
    > [!NOTE]
    >  For applications that have been upgraded to [!INCLUDE[vs2012_upd02](../vs140/includes/vs2012_upd02_md.md)], on the **Perspective** bar, choose the **Server** tab.  
  
2.  In the **Data Designer**, choose a field of type `Date` or `Date Time` that you want to format.  
  
3.  On the menu bar, choose **View**, **Properties Window**.  
  
4.  In the **Properties** window, in the **Formatting** section, choose the **Format Pattern** property, and then specify a valid format string.  
  
     For more information about format strings, see [Reference: Number and Date Formats](../vs140/reference--number-and-date-formats.md).  
  
5.  In **Solution Explorer**, open the shortcut menu for a screen that displays the entity or table.  
  
     The screen opens in the **Screen Designer**.  
  
6.  In the **Screen Content Tree**, choose the item that represents the date field that you want to format.  
  
7.  In the list of formats, choose either `Label` or `TextBox`.  
  
    > [!NOTE]
    >  The `Date Picker`, `Date Time Picker`, `Date Time Viewer` and `Date Viewer` controls don't respect the **Format Pattern** property.  
  
## See Also  
 [Reference: Number and Date Formats](../vs140/reference--number-and-date-formats.md)   
 [How to: Design a Screen by Using the Screen Designer](../vs140/how-to--design-a-silverlight-screen-by-using-the-screen-designer.md)   
 [Data: The Information Behind Your Application](../vs140/data--the-information-behind-your-application.md)