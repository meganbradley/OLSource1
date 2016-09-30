---
title: "MFC ActiveX Controls: Advanced Property Implementation"
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
  - "MFC ActiveX controls, error codes"
  - "properties [MFC], ActiveX controls"
  - "MFC ActiveX controls, properties"
ms.assetid: ec2e6759-5a8e-41d8-a275-99af8ff6f32e
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MFC ActiveX Controls: Advanced Property Implementation
This article describes topics related to implementing advanced properties in an ActiveX control:  
  
-   [Read-only and write-only properties](#_core_read2donly_and_write2donly_properties)  
  
-   [Returning error codes from a property](#_core_returning_error_codes_from_a_property)  
  
##  \<a name="_core_read2donly_and_write2donly_properties">\</a> Read-Only and Write-Only Properties  
 The Add Property Wizard provides a quick and easy method to implement read-only or write-only properties for the control.  
  
#### To implement a read-only or write-only property  
  
1.  Load your control's project.  
  
2.  In Class View, expand the library node of your control.  
  
3.  Right-click the interface node for your control (the second node of the library node) to open the shortcut menu.  
  
4.  From the shortcut menu, click **Add** and then click **Add Property**.  
  
     This opens the [Add Property Wizard](../vs140/names--add-property-wizard.md).  
  
5.  In the **Property Name** box, type the name of your property.  
  
6.  For **Implementation Type**, click **Get/Set Methods**.  
  
7.  In the **Property Type** box, select the proper type for the property.  
  
8.  If you want a read-only property, clear the Set function name. If you want a write-only property, clear the Get function name.  
  
9. Click **Finish**.  
  
 When you do this, the Add Property Wizard inserts the function <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> in the dispatch map entry in place of a normal Set or Get function.  
  
 If you want to change an existing property to be read-only or write-only, you can edit the dispatch map manually and remove the unnecessary Set or Get function from the control class.  
  
 If you want a property to be conditionally read-only or write-only (for example, only when your control is operating in a particular mode), you can provide the Set or Get function, as normal, and call the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function where appropriate. For example:  
  
 [!code[NVC_MFC_AxUI#29](../vs140/codesnippet/CPP/mfc-activex-controls--advanced-property-implementation_1.cpp)]  
  
 This code sample calls <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> data member is **TRUE**. If **FALSE**, then the property is set to the new value.  
  
##  \<a name="_core_returning_error_codes_from_a_property">\</a> Returning Error Codes From a Property  
 To indicate that an error has occurred while attempting to get or set a property, use the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> function, which takes an <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> (status code) as a parameter. You can use a predefined <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> or define one of your own. For a list of predefined <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>s and instructions for defining custom <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>s, see [Handling Errors in Your ActiveX Control](../vs140/mfc-activex-controls--advanced-topics.md) in the article ActiveX controls: Advanced Topics.  
  
 Helper functions exist for the most common predefined <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>s, such as [COleControl::SetNotSupported](../vs140/colecontrol--setnotsupported.md), [COleControl::GetNotSupported](../vs140/colecontrol--getnotsupported.md), and [COleControl::SetNotPermitted](../vs140/colecontrol--setnotpermitted.md).  
  
> [!NOTE]
>  <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is meant to be used only as a means of returning an error from within a property's Get or Set function or an automation method. These are the only times that the appropriate exception handler will be present on the stack.  
  
 For more information on reporting exceptions in other areas of the code, see [COleControl::FireError](../vs140/colecontrol--fireerror.md) and the section [Handling Errors in Your ActiveX Control](../vs140/mfc-activex-controls--advanced-topics.md) in the article ActiveX Controls: Advanced Topics.  
  
## See Also  
 [MFC ActiveX Controls](../vs140/mfc-activex-controls.md)   
 [MFC ActiveX Controls: Properties](../vs140/mfc-activex-controls--properties.md)   
 [MFC ActiveX Controls: Methods](../vs140/mfc-activex-controls--methods.md)   
 [COleControl Class](../vs140/colecontrol-class.md)