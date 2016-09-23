---
title: "Reference: Data Designer Properties"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - lightswitch
ms.tgt_pltfrm: na
ms.topic: article
helpviewer_keywords: 
  - data [Visual Studio LightSwitch], configuring
  - data [Visual Studio LightSwitch], Properties window
  - Visual Studio LightSwitch, configuring
  - properties [Visual Studio LightSwitch]
  - Properties window [Visual Studio LightSwitch]
  - data [Visual Studio LightSwitch], properties
ms.assetid: 5bd7efd3-1125-4b59-b446-fc500081e946
caps.latest.revision: 25
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Reference: Data Designer Properties
You can modify the format and behavior of data by setting the value of properties in the **Properties** window. The following tables describe each property.  
  
## General Properties  
  
|Name|Description|  
|----------|-----------------|  
|**Default Screen**|If more than one **Details** screen is defined in the application, this property specifies which screen appears by default when a user opens a detail view of an item of data.|  
|**Plural Name**|The name used to describe a collection of the current type. This name appears in **Solution Explorer**. This name also appears in IntelliSense when you refer to the collection by using custom code.|  
|**Is Computed**|Indicates whether the value of the field is computed. For more information, see [How to: Add a Computed Field](../vs140/how-to--add-a-computed-field-in-a-lightswitch-database.md).|  
|**Is Searchable**|Indicates whether the contents of this field are searchable.|  
|**Name**|The name of the field, table, or entity.|  
|**Choice List**|A list of name value pairs. Create a *choice list* to enable users to select a value from a drop-down list. For more information, see [How to: Create a Choice List for an Entity Field](../vs140/how-to--create-a-list-of-values-for-a-field-in-a-lightswitch-application.md).|  
|**Include in Unique Index**|Ensures that the value of this field combined with the value of other fields in the unique index are unique. For more information about unique indexes, see [Unique Index Design Guidelines](http://go.microsoft.com/fwlink/?LinkID=207712).|  
|**Default Email Domain**|Applies to the **EmailAddress** business type. Appends an email domain to the end of a valid email address alias.|  
|**Enable Created/Modified properties**|When selected, adds four fields to the entity to identify the user who created or most recently updated the record and the time when the record was created or most recently updated. The time is stored as a `Date Time Offset` data type. See [How to: Provide an Audit Trail](../vs140/how-to--implement-row-tracking.md). **Note:**  The **Enable Created/Modified properties** property appears for tables in the intrinsic database only.|  
  
## Appearance Properties  
  
|Name|Description|  
|----------|-----------------|  
|**Description**|The text that appears as the default tooltip for this item in a screen. If you add text to the **Description** property of a control that displays this item, then that description is used as the tooltip instead.|  
|**Display Name**|Enter the name that is displayed on a screen for the field, table, or entity.|  
|**Summary Property**|When the entity or table appears in a group that uses the **Summary** control type, this property specifies which field of the entity or table appears in each row of the group. For more information about the **Summary** control type, see [Reference: Screen Designer Properties](../vs140/reference--screen-designer-properties.md).|  
|**Display by Default**|Specifies whether the currently selected field appears in screens. If you clear the Display by Default check box, and you want this field to appear in a screen, you will have to drag this field from the screen members list to the screen content tree in the screen designer.|  
|**Currency Symbol**|Applies to the **Money** business type. The name of the locale for the currency. For example, if your currency is listed in United States Dollars, specify **en-US**.|  
|**Decimal Digits**|Applies to the **Money** business type. The number of decimal digits to display. For example, specify **2** to display two digits after the decimal.|  
|**Is Formatted**|Applies to the **Money** business type. Specifies whether to display the currency symbol, digit grouping separator, and custom decimal digits. You can then decide which of these three items you want to display by modifying the **Symbol Mode**, **Is Grouped**, and **Decimal Digits** properties.|  
|**Is Grouped**|Applies to the **Money** business type. Displays a digit grouping separator. For example, if you select this option, a monetary value will display as **1,234.56** rather than **1234.56**.|  
|**Symbol Mode**|Applies to the **Money** business type. Displays the currency symbol from this drop-down list. To display the currency symbol, select **Currency Symbol** or **ISO Currency Symbol**. To stop the display of the currency symbol, select **No Currency Symbol**.|  
|**Percent Decimal Places**|Applies to the **Percent** business type. The number of decimal digits to display. For example, specify **2** to display two digits after the decimal.|  
|**Phone Number Formats**|Applies to the **PhoneNumber** business type. Specifies how you want to validate and display phone numbers. You specify the format for the phone number using the letters **C** for country code, **A** for area or city code, and **N** for local number, and any symbols that are currently used to display phone numbers, such as **+**, **-**, **(**, **)**, **.**, and spaces. For example, to display a North American phone number, you specify any of the following formats:<br /><br /> 1.  C-AAA-NNN-NNNN<br />2.  AAA-NNN-NNNN<br />3.  (AAA) NNN-NNNN<br />4.  AAA.NNN.NNNN<br /><br /> When users type a phone number, the application first tries to validate the phone number against the first format in the list. If the digits match the format, then the phone number appears in that format. Otherwise, the application tries to validate the phone number against the remaining formats in the list until a match is made.|  
  
## Formatting Properties  
  
|Name|Description|  
|----------|-----------------|  
|**Format Pattern**|Specifies the display format for numeric and date data types. For example, you might want to display a Decimal value as a percentage (12.2%), or display a date that includes the day of the week (Monday, July 4, 2011). For more information, see [How to: Format Numbers and Dates](../vs140/how-to--format-numbers-and-dates-in-a-lightswitch-application.md)|  
  
## Validation Properties  
  
|Name|Description|  
|----------|-----------------|  
|**Is Required**|Indicates whether the field must have a value. If a value is required, select this check box.|  
|**Maximum Length**|Specifies the maximum length of the field in characters.|  
|**Maximum Value**|Specifies the maximum value of the field.|  
|**Minimum Value**|Specifies the minimum value of the field.|  
|**Precision**|Specifies the maximum number of digits for the value of the field. This includes digits both left of and right of the decimal point.|  
|**Scale**|Specifies the maximum number of digits to the right of the decimal point for the value of the field.|  
|**Require Email Domain**|Applies to the **EmailAddress** business type. Indicates whether the user must provide an email domain as part of an email address that they type into a field of type `EmailAddress`.|  
  
## See Also  
 [Reference: Screen Designer Properties](../vs140/reference--screen-designer-properties.md)   
 [Reference: Query Designer Properties](../vs140/reference--query-designer-properties.md)   
 [Data and Entities: The Information Behind Your Application](../vs140/data--the-information-behind-your-application.md)